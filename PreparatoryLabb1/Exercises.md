# Preparatory Exercises - Lab 1

Here are more practice exercises with loops and string indexing. These can be good to solve before tackling lab 1, as you will learn some things that can help you on the lab.

**NOTE!** *Color coding in markdown doesn't seem to be displayed on GitHub. Check out and view this file in Visual Studio or Visual Studio Code instead!*

## 1. Letter by Letter - Until Space
Start with the string (create a variable with) "Hello World!", print out the entire string letter by letter, but stop when there's a space. (So it should only print "Hello").

## 2. Letter by Letter - Line Break on Space
Start with the string "This is just some other text". Print out the string letter by letter, but when there's a space, make a line break instead. (You should get one word per line).

## 3. Letter by Letter - Every Other Star
Start with the string "Detta är uppgift 3". Print letter by letter. But if the index is an even number, print * instead.

## 4. Letter by Letter - Green o's, Red l's
Start with the string "Hello world!". Print letter by letter. All 'o's should be green, all 'l's should be red. Other letters are white/gray.

## 5. Letter by Letter - Doubles in Green
Start with the string "Hello world". Print letter by letter. If two characters in a row are the same, these should be green. Other letters are white/gray.

## 6. Letter by Letter - Green Substring
Start with the string "How much wood would a woodchuck chuck if a woodchuck could chuck wood?", and the smaller string "oo". Print out the long string letter by letter. Every time the smaller string occurs (two 'o's in a row), these should be green. Other letters are white/gray.

## 7. Letter by Letter - Green Substring 2
Same as exercise 6, but the smaller string is "chuck" instead of "oo". That is, every time "chuck" appears in the longer string, these are written with green text.

## 8. Letter by Letter - Green Substring 3
Same as exercise 6 again, but this time the user can enter the shorter string, i.e., any text to be searched for (colored green) in the longer text.

## 9. Letter Pyramid
Start with the string "Hello world!". Make a program that prints the first letter once on the first line. The second letter 2 times on the second line. The third 3 times on the next line, etc. So:
```
H
ee
lll
... etc
```

## 10. Word Pyramid
Start with the string "How much wood would a woodchuck chuck if a woodchuck could chuck wood?". Make a program that prints the first word once on the first line; the second word twice on the next line. The third word three times on the next. etc. so:

```
How
much much
wood wood wood
... etc
```

## 11. Word Pyramid 2
Start with the string "How much wood would a woodchuck chuck if a woodchuck could chuck wood?". Make a program that prints the first word on the first line. On the next line, print the first two words, then the first three words on the next line, and so on until you reach the line that prints out the entire sentence. So:
```
How
How much
How much wood
... etc
```

## 12. Red-Highlighted Words
Use the same string again, but this time the program should print the entire string on each line. On the first line, the first word should be red (others white), on the second line, the second word should be red. On the third line, the third word should be red, etc. So:

<span style="color:red; font-weight:bold">How</span> much wood would a woodchuck chuck if a woodchuck could chuck wood?  
How <span style="color:red; font-weight:bold">much</span> wood would a woodchuck chuck if a woodchuck could chuck wood?  
How much <span style="color:red; font-weight:bold">wood</span> would a woodchuck chuck if a woodchuck could chuck wood?   
... etc

## 13. Red-Highlighted Letters
Start with the string "abcdefghijklmnopqrstuvwxyz". The entire string is printed on each line. On the first line, the first 5 characters are red. On the next line, "bcdef" are red, then "cdefg", etc. So always 5 characters, but they move one step to the right for each line, until the last line has "vwxyz" colored red. So:

<span style="color:red; font-weight:bold">abcde</span>fghijklmnopqrstuvwxyz  
a<span style="color:red; font-weight:bold">bcdef</span>ghijklmnopqrstuvwxyz  
ab<span style="color:red; font-weight:bold">cdefg</span>hijklmnopqrstuvwxyz  
... etc

## 14. Red-Highlighted Letters 2
The user enters any string. The program prints the entire string letter by letter. All letters are red until you encounter a character that is the same as the first character in the string. After that, it prints the rest of the letters with white/gray color. Some examples with different inputs/runs:

<span style="color:red; font-weight:bold">ajdfhva</span>jhdfd  
<span style="color:red; font-weight:bold">hh</span>fgijff  
<span style="color:red; font-weight:bold">fjpdpog</span> 

## 15. Red-Highlighted Letters 3
The user enters any string. The program then prints the entire string multiple times. On the first line, it starts writing with red color on the first letter and continues until it finds the same letter again. On the second line, it starts writing with red color on the second letter and continues until it finds the same letter again. On the third line, it starts writing with red text on the third letter and continues until it finds the same again... etc. If you enter "ajdfhvajhdfd" it becomes:

<span style="color:red; font-weight:bold">ajdfhva</span>jhdfd  
a<span style="color:red; font-weight:bold">jdfhvaj</span>hdfd  
aj<span style="color:red; font-weight:bold">dfhvajhd</span>fd  
ajd<span style="color:red; font-weight:bold">fhvajhdf</span>d 
... etc