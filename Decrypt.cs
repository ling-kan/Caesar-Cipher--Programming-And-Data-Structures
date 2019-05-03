using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assessment1
{
    class Decrypt
    {
        public string decrypt(int shift, char[] letters, string file)
        {

            char chars = ' ';
            string decryption = "";
            int position = 0;
            
            foreach (char c in file)

            {
                chars = c;
                if (letters.Contains(chars))
                {
                    position = Array.IndexOf(letters, chars);
                    position = position + shift;
                    
                    // Defining how many positions the text should be shifted
                    if (position > 25)
                    {
                        // If the position ifs more than 25, subtract the number by 26
                        position = position - 26;
                    }

                    else if (position < 0)
                    {
                        // If the position is below 0, then add 26
                        position += 26;
                    }
                    // Add both data sets together
                    decryption += letters[position];
                }
            }
            // Show the number of shifts
            Console.WriteLine("\nNumber of shift: " + shift);
            // Print the decryption options
            Console.WriteLine(decryption);
           return decryption;


        }
    }
}
