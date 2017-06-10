using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Xml;


namespace MailAgency
{
    class PostalAgency2
    {
        const string TextFileName2 = "doc2.txt";
        const string XmlFileName2 = "doc2.xml";
        const string XmlFileName3 = "doc3.xml";
         List<PostalMessage> message;

         public PostalAgency2(List<PostalMessage> message)
         {
             this.message = message;
         
         }
         public void PrintDocument(DocumentType docType)
         {
             if (File.Exists(TextFileName2))
                 File.Delete(TextFileName2);

             foreach (PostalMessage msg in message)
             {
                 string shipping = string.Format("{0} | Cost: {1:0.00}\n", msg.RecipientAddress.ToString(), msg.GetPrice());

                 File.AppendAllText(TextFileName2, shipping);
             }
            
         }
         public void PrintDocument2(DocumentType docType)
         {
             if (File.Exists(XmlFileName2))
                 File.Delete(XmlFileName2);

             XDocument document = new XDocument(
                 new XDeclaration("1.0", "utf-8", "yes"),
                 new XComment("Jason's xml"),

                 new XElement("PostalMessages",
                     from elem in message
                     select new XElement("PostalMessage",

                           new XElement("RecipientAddress", elem.RecipientAddress),
                           new XElement("GetPrice", elem.GetPrice())
                            )
                        )
                  );

             document.Save(XmlFileName2);

         }

         public void PrintDocument3(DocumentType docType)
         {
             XmlReader xRead = XmlReader.Create(XmlFileName2);
             XElement xElem = XElement.Load(xRead);
             Console.WriteLine(xElem);
             xRead.Close();
             xElem.Save(XmlFileName3);
         }
               
                 
                

               
    }
}
