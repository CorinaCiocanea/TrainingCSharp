using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MailAgency
{
    class PostalAgency
    {
        const string TextFileName = "ShippingDoc.txt";
        const string XmlFileName = "ShippingDoc.xml";

        List<PostalMessage> messages;

        public PostalAgency(List<PostalMessage> messages)
        {
            this.messages = messages;
        }

        public void PrintDocument(DocumentType docType)
        {
            if (messages == null)
            {
                Console.WriteLine("Messages list cannot be empty");
                return;
            }

            if (docType == DocumentType.Text)
            {
                if (File.Exists(TextFileName))
                    File.Delete(TextFileName);

                foreach (PostalMessage msg in messages)
                {
                    string shipping = string.Format("{0} | Cost: {1:0.00}\n", msg.RecipientAddress.ToString(), msg.GetPrice());

                    File.AppendAllText(TextFileName, shipping);
                }
            }
            else
            {
                if (File.Exists(XmlFileName))
                    File.Delete(XmlFileName);

                XmlDocument doc = new XmlDocument();

                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(xmlDeclaration, root);

                XmlElement rootNode = doc.CreateElement(string.Empty, "shippingList", string.Empty);
                doc.AppendChild(rootNode);

                foreach (PostalMessage msg in messages)
                {
                    XmlElement itemNode = doc.CreateElement(string.Empty, "item", string.Empty);
                    rootNode.AppendChild(itemNode);

                    XmlElement recipientDataNode = doc.CreateElement(string.Empty, "recipientData", string.Empty);
                    XmlText text1 = doc.CreateTextNode(msg.RecipientAddress.ToString());
                    recipientDataNode.AppendChild(text1);
                    itemNode.AppendChild(recipientDataNode);

                    XmlElement costNode = doc.CreateElement(string.Empty, "cost", string.Empty);
                    XmlText text2 = doc.CreateTextNode(string.Format("{0:0.00}", msg.GetPrice()));
                    costNode.AppendChild(text2);
                    itemNode.AppendChild(costNode);
                }

                doc.Save(XmlFileName);
            }
        }
    }
}
