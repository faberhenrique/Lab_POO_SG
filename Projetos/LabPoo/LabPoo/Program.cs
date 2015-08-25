using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace LabPoo
{
    public class inicio
    {
         static void Main()
        {
            Criptografia cypher = new Criptografia();
            string a = "test";
            string b = cypher.CifraCesar(a, 18); // Ok
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
