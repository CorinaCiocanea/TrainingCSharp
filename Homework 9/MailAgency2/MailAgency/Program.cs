using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MailAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            // Telegrams
            Address address1 = new Address("Adrian", "Bucuresti", "Bucuresti", "Stefan cel mare", "789231");
            Telegram telegram1 = new Telegram(address1, "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?");

            // Letters
            Address address2 = new Address("Cristian", "Dolj", "Craiova", "Mihai Eminescu", "335353");
            Letter letter1 = new InternalLetter(address2);

            Address address3 = new Address("Adrian", "Iasi", "Iasi", "Tudor Vladimirescu", "236737");
            Letter letter2 = new InternalLetterConfirm(address3);

            // Packages
            Address address4 = new Address("Gabriel", "Timis", "Timisoara", "Dimitrie Cantemir", "395737");
            Package package1 = new InternalPackage(address4, 12.8);

            Address address5 = new Address("Daniel", "Iasiiiiii", "Iasi", "Pacurari", "663137");
            Package package2 = new ExternalPackage(address5, 5.2);

            List<PostalMessage> messages = new List<PostalMessage>();
            messages.Add(telegram1);
            messages.Add(letter1);
            messages.Add(letter2);
            messages.Add(package1);
            messages.Add(package2);

            PostalAgency agency = new PostalAgency(messages);
            //agency.PrintDocument(DocumentType.Text);
            //agency.PrintDocument(DocumentType.Xml);
            
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Jason's xml"),
                new XElement("Address",
                    new XElement("name", "Dan"),
                    new XElement("county", "Iasi"),
                    new XElement("locality", "Iasi"),
                    new XElement("street", "Pacurari"),
                    new XElement("zipcode", "1232312"),
                    new XElement("Telegram",
                        new XElement("recipientAddress"),
                        new XElement ("message")
                        
                        
                        )

                    )
                );
            xmlDocument.Save("Document.xml");

            PostalAgency2 ag = new PostalAgency2(messages);
            ag.PrintDocument(DocumentType.Text);
            ag.PrintDocument2(DocumentType.Xml);
            ag.PrintDocument3(DocumentType.Xml);
            //ag.PrintDocument3();
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
           
        }
    }

