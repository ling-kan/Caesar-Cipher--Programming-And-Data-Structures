using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1
{
    class MainClass
    {
        public static string userInput;
        public static int shift;
        public static void Main()
        {
            Decrypt dec = new Decrypt();
            Encrypt enc = new Encrypt();
            char[] alphabet = new char[26];
            alphabet = alphabetMaker();
            // string[] str = new string[26];

            bool correct = false;
            while (correct == false)
            {
               
                
                Console.WriteLine("Type...\n'F' - ceaserShiftEncoded.txt.\n'T' - type in your own passage to encyrpt\n'Q' to exit application.");
                string option = Convert.ToString(Console.ReadLine()).ToUpper();


                // Menu options for application 
                switch (option)
                {
                    // Open File Option
                    case "F":
                        Console.WriteLine("\n---CaesarShiftEncodedText.txt file---\n");
                        string file = File.ReadAllText(@"caesarShiftEncodedText.txt");

                        int[] f = new int[(int)char.MaxValue];
                        

                        // Frequency Analysis table for each letter in the file 
                        Console.WriteLine("\n---Frequency Analysis ---\n");
                        foreach (char frequencyAnaylsis in file)
                        {
                            //Count all the frequencies
                            f[(int)frequencyAnaylsis]++;
                        }

                        // Find the frequency of each letter
                        for (int i = 0; i < (int)char.MaxValue; i++)
                        {
                            if (f[i] > 0 && char.IsLetterOrDigit((char)i))
                            {
                                // Display the frequency of each character in a table
                                Console.WriteLine("Letter: {0}  Frequency: {1}",
                                    (char)i, f[i]);
                            }
                        }
                        Console.WriteLine("\n---Decryption---");
                        // Read file (line by line), and store it as a list
                        List<string> list = new List<string>();
                        Console.WriteLine("Open ");
                        // Decrypt File
                        //Clear output file
                        StreamWriter outputFile = new StreamWriter("outputtext.txt");
                        outputFile.Close();
         
                        //Open file - append privilidges
                        StreamWriter outputFile2 = new StreamWriter("outputtext.txt", true);

                        for (int i = 0; i < 26; i++)
                        {
                            outputFile2.WriteLine("Shift: {0}", i);
                            outputFile2.WriteLine(dec.decrypt(i, alphabet, file));
                        }
                        outputFile2.Close();
                      
                        correct = true;
                        Console.ReadLine();
                        break;
                        
                    // Type own text to encrypt and decrypt
                    case "T":

                        {
                            bool correctD = false;
                            while (correctD == false)
                            {
                                // Option to Encrypt or Decrypt
                                Console.WriteLine("Type E to Encrypt  or D Decrypt ?: ");
                                string choice = Convert.ToString(Console.ReadLine()).ToUpper();
                                bool eAndD = false;
                                switch (choice)
                                {
                                    case "E":
                                        // Redirect to encryption class
                                        eAndD = true;
                                        choiceOfEAndD(eAndD);
                                        correctD = true;
                                        enc.encrypt(shift, alphabet, userInput);
                                        Console.ReadLine();
                                        break;

                                    case "D":
                                        // Redirect to encryption class
                                        eAndD = false;
                                        choiceOfEAndD(eAndD);
                                        correctD = true;
                                        dec.decrypt(shift, alphabet, userInput);
                                        Console.ReadLine();
                                        break;

                                    default:
                                        // Error Message for invalid value
                                        Console.WriteLine("Error");
                                        break;
                                }
                            }
                            correct = true;
                            break;
                        }
                     // Type 'Q' to exit application
                    case "Q":
                        {
                            Environment.Exit(0);
                            break;
                        }
 
                    // Error Message if unkown case is entered
                    default:
                        Console.WriteLine("Please enter the correct character");
                        break;
                }
            }
        }



        public static char[] alphabetMaker()
        {
            // char array of 26 characters (A-Z)
            char[] letters = new char[26];
            for (int i = 0; i < 26; i++)
            {
                // Using ASCII to determine the letters
                letters[i] = ((char)(i + 65));
            }
            return letters;
        }
        public static void choiceOfEAndD(bool eAndD)
        {
            Console.Write("Enter a Passage(Letters only):");
            userInput = Console.ReadLine();
            //Error checking for Only letters between A-Z
            foreach (char c in userInput)
            {
                int d = (int)c;
                // If the ASCII code is inbetween 65 and 90 (lowercase letters) the program will use this formula to display letters
                if (d < 64 && d > 91)
                {
                    userInput += c;
                }
                // If the ASCII code is between 96 and 123 (symbols), it will be igrnored
                else if (d < 96 && d > 123)
                {
                    userInput += c;
                }
            }
            // Convert to userInput to uppercase letters
            userInput = userInput.ToUpper();
            // Creating a true and false statement
            bool intInput = false;
            while (intInput == false)
            {
                Console.WriteLine("How many characters would you like to shift?:");
                string shiftInput = Console.ReadLine();
                // Checks whether the number is between 1 and 26
                intInput = int.TryParse(shiftInput, out shift);
                if (intInput == true)
                {

                    shift = int.Parse(shiftInput);
                    if (shift >= 1 && shift <= 26)
                    {
                        shift = int.Parse(shiftInput);
                    }
                    else
                    {
                        // Error message for invalid characters
                        Console.WriteLine("Please enter a number between 1 and 26.");
                        intInput = false;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 26.");
                }

            }
        }
    }
}