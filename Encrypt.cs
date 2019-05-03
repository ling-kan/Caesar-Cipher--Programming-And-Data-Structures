using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Encrypt
    {
        public void encrypt(int shift, char[] letters, string file)
        {
            char chars = ' ';
            string encryption = "";
            int position = 0;
            foreach (char c in file)
            {
                chars = c;

                for (int i = 0; i < 26; i++)
                {
                    if (chars==letters[i])
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
                        encryption += letters[position];
                    }
                }
            }
             // Display the decryption
            Console.WriteLine(encryption);
            Console.ReadLine();
        }
    }
}

