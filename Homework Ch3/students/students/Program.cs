using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[5]{ new User("Tom" , 23),  
                                         new User("Max" , 20),
                                         new User("Eli" , 25),
                                         new User("Marve" , 22),
                                         new User("Adi" , 19)};
            
                
                foreach (User user in users)
                {
                    Console.WriteLine( user.Name + user.Age + " ");
                }


            int maxAge = users.Where(x => x.Name.Contains('a')).Max(user => user.Name.Count());

                foreach (User user in users)
                {
                    if (user.Age > maxAge)
                    {
                        maxAge = user.Age;
                    }
                   
                }
                Console.WriteLine("Age maxim {0}", maxAge);


                int minAge = users.Max(user => user.Age);

                foreach (User user in users)
                {
                    if (user.Age < minAge)
                    {
                        minAge = user.Age;
                    }
                   
                }
                Console.WriteLine("Age minim {0}", minAge);
            

            Console.ReadLine();

        }
    }

}
