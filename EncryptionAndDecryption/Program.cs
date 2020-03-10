using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var encryption = CryptoEngine.Encrypt(input);
            var decryption = CryptoEngine.Decrypt(encryption);
            Console.WriteLine(encryption);
            Console.WriteLine(decryption);  
        }
    }
}
