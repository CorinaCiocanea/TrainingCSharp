using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Linq;
//using System.Data.DataSetExtensions;
//using System.Core;
using System.Data.Entity;


namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dataContext = new DataContext(@"Integred Security=SSPI; database= Database1; sever=(local)\SQLEXPRESS");
            Table<Student> stud = dataContext.GetTable<Student>();
        }
    }
}
