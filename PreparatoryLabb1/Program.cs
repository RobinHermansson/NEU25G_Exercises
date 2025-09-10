namespace PreparatoryLabb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         while (true)
            {
                Console.WriteLine("=================================================\n" +
                    "\nHello, select a number from the below list: \n" +
                    "\n1.  Letter by Letter - Until Space" +
                    "\n2.  Letter by Letter - Line Break on Space" +
                    "\n3.  Letter by Letter - Every Other Star" +
                    "\n4.  Letter by Letter - Green o's, Red l's" +
                    "\n5.  Letter by Letter - Doubles in Green" +
                    "\n6.  Letter by Letter - Green Substring" +
                    "\n7.  Letter by Letter - Green Substring 2" +
                    "\n8.  Letter by Letter - Green Substring 3" +
                    "\n9.  Letter Pyramid" +
                    "\n10. Word Pyramid" +
                    "\n11. Word Pyramid 2" +
                    "\n12. Red-Highlighted Words" +
                    "\n13. Red-Highlighted Letters" +
                    "\n14. Red-Highlighted Letters 2" +
                    "\n15. Red-Highlighted Letters 3\n" +
                    "\n=================================================\n");

                int selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        LetterByLetterUntilSpace();
                        break;
                    case 2:
                        LetterByLetterLineBreakOnSpace();
                        break;
                    case 3:
                        LetterByLetterEveryOtherStar();
                        break;
                    case 4:
                        LetterByLetterGreenOsRedLs();
                        break;
                    case 5:
                        LetterByLetterDoublesInGreen();
                        break;
                    case 6:
                        LetterByLetterGreenSubstring();
                        break;
                    case 7:
                        LetterByLetterGreenSubstring2();
                        break;
                    case 8:
                        LetterByLetterGreenSubstring3();
                        break;
                    case 9:
                        LetterPyramid();
                        break;
                    case 10:
                        WordPyramid();
                        break;
                    case 11:
                        WordPyramid2();
                        break;
                    case 12:
                        RedHighlightedWords();
                        break;
                    case 13:
                        RedHighlightedLetters();
                        break;
                    case 14:
                        RedHighlightedLetters2();
                        break;
                    case 15:
                        RedHighlightedLetters3();
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Try again.");
                        break;


                }

            }
        }
        static void LetterByLetterUntilSpace()
        {
            // Exercise goal:
            // Start with the string (create a variable with) "Hello World!", print out the entire string letter by letter, but stop when there's a space. (So it should only print "Hello").

            string helloWorld = "Hello World!";

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == ' ')
                {
                    break;
                }
                Console.Write(helloWorld[i]);
            }
            Console.WriteLine();

        }

        static void LetterByLetterLineBreakOnSpace()
        {
            //  Exercise goal:
            // Start with the string "This is just some other text". Print out the string letter by letter, but when there's a space, make a line break instead. (You should get one word per line).

            string exerciseString = "This is just some other text";
            for (int i = 0; i < exerciseString.Length; i++)
            {
                if (exerciseString[i] == ' ')
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(exerciseString[i]);
                }
            }
            Console.WriteLine();
        }

        static void LetterByLetterEveryOtherStar()
        {
            // Exercise goal:
            // Start with the string "This is exercise 3". Print letter by letter. But if the index is an even number, print * instead.
        }

        static void LetterByLetterGreenOsRedLs()
        {
            // Exercise goal:
            // Start with the string "Hello world!". Print letter by letter. All 'o's should be green, all 'l's should be red. Other letters are white/gray.
        }

        static void LetterByLetterDoublesInGreen()
        {
            // Exercise goal:
            // Start with the string "Hello world". Print letter by letter. If two characters in a row are the same, these should be green. Other letters are white/gray.
        }

        static void LetterByLetterGreenSubstring() 
        {
           // Exercise goal:
           // Start with the string "How much wood would a woodchuck chuck if a woodchuck could chuck wood?", and the smaller string "oo". Print out the long string letter by letter.
           // Every time the smaller string occurs (two 'o's in a row), these should be green. Other letters are white/gray.
        }
        static void LetterByLetterGreenSubstring2() 
        {
            // Exercise goal:
            // Same as exercise 6, but the smaller string is "chuck" instead of "oo". That is, every time "chuck" appears in the longer string, these are written with green text.
        }

        static void LetterByLetterGreenSubstring3() 
        {
            // Exercise goal:
            // Same as exercise 6 again, but this time the user can enter the shorter string, i.e., any text to be searched for (colored green) in the longer text.
        }

        static void LetterPyramid() 
        {
            // Exercise goal:
            // Start with the string "Hello world!". Make a program that prints the first letter once on the first line. The second letter 2 times on the second line. The third 3 times on the next line, etc. So:
            // H
            // ee
            // lll
            // etc...
        }
        static void WordPyramid() 
        {
            // Exercise goal:
            // Start with the string "How much wood would a woodchuck chuck if a woodchuck could chuck wood?".
            // Make a program that prints the first word once on the first line; the second word twice on the next line. The third word three times on the next. etc. so:
            // <span style="color:red; font-weight:bold">How</span> much wood would a woodchuck chuck if a woodchuck could chuck wood?  
            //How <span style="color:red; font-weight:bold">much</span> wood would a woodchuck chuck if a woodchuck could chuck wood?  
            //How much <span style="color:red; font-weight:bold">wood</span> would a woodchuck chuck if a woodchuck could chuck wood? 
        }

        static void WordPyramid2()
        {
            // Exercise goal:
            // Start with the string "How much wood would a woodchuck chuck if a woodchuck could chuck wood?".
            // Make a program that prints the first word on the first line. On the next line, print the first two words,
            // then the first three words on the next line, and so on until you reach the line that prints out the entire sentence. So:
            //
            //How
            //How much
            //How much wood
            //... etc

           
        }

        static void RedHighlightedWords()
        {
            // Exercise goal:
            // Use the same string again, but this time the program should print the entire string on each line.
            // On the first line, the first word should be red (others white), on the second line, the second word should be red.
            // On the third line, the third word should be red, etc. So:
            
            // <RED>How</RED> much wood would a woodchuck chuck if a woodchuck could chuck wood?
            // How <RED>much</RED> wood would a woodchuck chuck if a woodchuck could chuck wood?
            // How much <RED>wood</RED would a woodchuck chuck if a woodchuck could chuck wood?
            // ... etc            
            //
        }
        static void RedHighlightedLetters()
        {
            // Exercise goal:
            // Start with the string "abcdefghijklmnopqrstuvwxyz". The entire string is printed on each line. On the first line,
            // the first 5 characters are red. On the next line, "bcdef" are red, then "cdefg", etc. So always 5 characters,
            // but they move one step to the right for each line, until the last line has "vwxyz" colored red. So:

            // <span style="color:red; font-weight:bold">abcde</span>fghijklmnopqrstuvwxyz  
            //a<span style="color:red; font-weight:bold">bcdef</span>ghijklmnopqrstuvwxyz  
            //ab<span style="color:red; font-weight:bold">cdefg</span>hijklmnopqrstuvwxyz  
            //... etc.

            //    
           
        }
        static void RedHighlightedLetters2()
        {
            // Exercise goal:
            // The user enters any string. The program prints the entire string letter by letter.
            // All letters are red until you encounter a character that is the same as the first character in the string.
            // After that, it prints the rest of the letters with white/gray color. Some examples with different inputs/runs:

            //<span style="color:red; font-weight:bold">ajdfhva</span>jhdfd
            //<span style="color:red; font-weight:bold">hh</span>fgijff  
            //<span style="color:red; font-weight:bold">fjpdpog</span> 

            //   
        }
        static void RedHighlightedLetters3() 
        {  
            //  Exercise goal:
            // The user enters any string. The program then prints the entire string multiple times.
            // On the first line, it starts writing with red color on the first letter and continues until it finds the same letter again.
            // On the second line, it starts writing with red color on the second letter and continues until it finds the same letter again.
            // On the third line, it starts writing with red text on the third letter and continues until it finds the same again... etc.
            // If you enter "ajdfhvajhdfd" it becomes:
            // <span style="color:red; font-weight:bold">ajdfhva</span>jhdfd  
            // a<span style="color:red; font-weight:bold">jdfhvaj</span>hdfd  
            // aj<span style="color:red; font-weight:bold">dfhvajhd</span>fd  
            // ajd<span style="color:red; font-weight:bold">fhvajhdf</span>d 
            // ... etc
        }


    }
}
