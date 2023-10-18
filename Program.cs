using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upravljanjeGreskama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int godR;
            bool kontrola = false;

            
            do {
                Console.Write("Upisi svoju godinu rođenja: ");
                try
                {
      
                    godR = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Roden si: " + godR + " god.");
                    kontrola = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }while(kontrola==false);
            Console.ReadKey();








        }
    }
}
