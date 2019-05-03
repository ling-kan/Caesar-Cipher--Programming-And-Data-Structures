# Caesar-Cipher--Programming-And-Data-Structures


Caesar cipher decryption
In cryptography, a Caesar cipher, also known as shift cipher, is one of the simplest and most widely known encryption techniques. It is a type of encryption in which each letter in the plaintext is replaced by a letter some fixed number of positions down the alphabet. For example, with a left shift of 3, D would be replaced by A, E would become B, and so on. In this assessment, you are asked to write a program to perform decryption of a Caesar Ciphered string of data to produce a decrypted version of readable text. The specific tasks include
• Open a file (“caesarShiftEncoded.txt”) that contains an encrypted message
• Read in the data
• Write a loop statement to advance through the alphabet and find a way to shift n places to
arrive at the decrypted answers

Display all possible shifts, E.g, for the ciphertext "exxeg oe xsrgi"
Decryption shift (left) 0
Candidate plaintext exxego ex srgi dwwdfn dw rqfh cvvcem cv qpeg buubdl bu podf attack at once zsszbj zs nmbd yrryai yr mlac
1
2
3
4
5
6 ......
23 haahjr ha vujl
24 gzzgiq gz utik
25 fyyfhp fy tshj
• Output the decrypted message and its shift key to the screen, and also write the plaintext to an output file (“caesarShiftPlainText.txt”).
• A better version of the program can be achieved by building a separate class for the decryption (and possibly encryption) with its associated methods for each detailed task.
Enhancing your submission
It is strongly recommended that you complete the tasks listed above to ensure that you have a working application. The main weakness of Caesar cipher is that although the letters themselves change, their frequency does not. So, any enthusiastic cryptographer could crack the code using frequency analysis tables of the original plaintext language. For further marks in this assignment, you can extend the program to perform frequency analysis on the provided encrypted data (the advanced version) to find the most efficient solution possible in deciphering the data. You could use methods such as Exception Handling to detect errors in the execution and to deal with them, and the output could be formatted and displayed using a web page.
Efficiency could be measured in a number of ways. For example, the time taken to run the various decryption methods could be measured. The lowest time being the most efficient. The ‘correctness’ of the plaintext output could also be assessed. The more correct an output is, the more efficient it is at decrypting tasks.
For even more of a challenge, and a chance to enhance your submission even further, there is another encoded text file, (“caesarShiftEnhancedEncoding.txt”) which doesn’t use a simple letter shift to encode the text, but rather a more complex (but linear) encoding system. Determine the encoding transformation, and decode the text.
