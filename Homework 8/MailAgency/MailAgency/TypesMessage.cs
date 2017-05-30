using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAgency
{
 public class TypesMessage
    {
        private string telegram;
        private string internletter;
        private string internpackage;
        private string externpackage;
        private string internpackageconf;
        

        public string Telegram 
        {
            get 
            {
                return telegram;
            }
            set 
            {
                telegram = value;
            }
        }
        public string InternLetter
        {
            get
            {
                return internletter;
            }
            set
            {
                internletter = value;
            }
        }
        public string InternPackage
        {
            get
            {
                return internpackage;
            }
            set
            {
                internpackage = value;
            }
        }
        public string ExternPackage
        {
            get
            {
                return externpackage;
            }
            set
            {
                externpackage = value;
            }
        }
        public string InternPackageConf
        {
            get
            {
                return internpackageconf;
            }
            set
            {
                internpackageconf = value;
            }
        }

        public void MethodTelegram(string character)
        {
           // length = 100;
            double price = 10;
           
           foreach(char charac in character)
            {

                if (charac < 100)
                {
                    Console.WriteLine("You have one hundred characters at a price {0}", price);
                }
                else
                {

                }

                   
            }
        
        }
    }
}
