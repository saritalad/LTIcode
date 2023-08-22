1. Write a program in C# Sharp to create a blank file in the disk newly. Go to the editor
Expected Output :

 A file created with name mytest.txt  
 

2. Write a program in C# Sharp to remove a file from the disk. Go to the editor
Expected Output :

 Remove a file from the disk (at first create the file ) :                                                    
--------------------------------------------------------------                                                
 The file mytest.txt deleted successfully.
 
  Remove a file from the disk (at first create the file ) :                                                    
--------------------------------------------------------------                                                
 File does not exist 
 

3. Write a program in C# Sharp to create a blank file in the disk if the same file already exists. Go to the editor
Expected Output :

 A file created with name mytest.txt  
 

4. Write a program in C# Sharp to create a file and add some text. Go to the editor
Expected Output:

 A file created with content name mytest.txt 
 

5. Write a program in C# Sharp to create a file with text and read the file. Go to the editor
Expected Output :

 Here is the content of the file mytest.txt :                                                                 
 Hello and Welcome                                                                                            
 It is the first content                                                                                      
 of the text file mytest.txt 
 

6. Write a program in C# Sharp to create a file and write an array of strings to the file. Go to the editor
Test Data :
Input number of lines to write in the file :2
Input 2 strings below :
Input line 1 : this is 1st line
Input line 2 : this is 2nd line
Expected Output :

 The content of the file is  :                                                                                
----------------------------------                                                                            
 this is 1st line                                                                                             
 this is 2nd line 
 

7. Write a program in C# Sharp to create and write some line of text into a file which does not contain a given string in a line. Go to the editor
Test Data :
Input the string to ignore the line : fox
Input number of lines to write in the file : 2
Input 2 strings below :
Input line 1 : the quick brown fox jumps
Input line 2 : over the lazy dog.
Expected Output :

The line have ignored which contain the string 'fox'.                                                        
 The content of the file is  :                                                                                
----------------------------------                                                                            
 over the lazy dog.                                                      
 

8. Write a program in C# Sharp to append some text to an existing file. Go to the editor
Expected Output :

 Here is the content of the file mytest.txt :                                                                 
 Hello and Welcome                                                                                            
 It is the first content                                                                                      
 of the text file mytest.txt                                                                                  

 Here is the content of the file after appending the text :                                                   
 Hello and Welcome                                                                                            
 It is the first content                                                                                      
 of the text file mytest.txt                                                                                  
 This is the line appended at last line. 
 

9. Write a program in C# Sharp to create and copy the file to another name and display the content. Go to the editor
Expected Output :

 Here is the content of the file mytest.txt :                                                                 
 Hello and Welcome                                                                                            
 It is the first content                                                                                      
 of the text file mytest.txt                                                                                  

 The file mytest.txt successfully copied to the name mynewtest.txt in the same directory.                     
 Here is the content of the file mynewtest.txt :                                                              
 Hello and Welcome                                                                                            
 It is the first content                                                                                      
 of the text file mytest.txt
 


10. Write a program in C# Sharp to create a file and move the file into the same directory to another name. Go to the editor
Expected Output:

Here is the content of the file mytest.txt :                                                                 
 Hello and Welcome                                                                                            
 It is the first content                                                                                      
 of the text file mytest.txt                                                                                  

 The file mytest.txt successfully moved to the name mynewtest.txt in the same directory.                      
 Here is the content of the file mynewtest.txt :                                                              
 Hello and Welcome                                                                                            
 It is the first content                                                                                      
 of the text file mytest.txt 
 

11. Write a program in C# Sharp to read the first line from a file. Go to the editor
Expected Output:

 Here is the content of the file mytest.txt :                                                                 
 test line 1                                                                                                  
 test line 2                                                                                                  
 Test line 3                                                                                                  

 The content of the first line of the file is :                                                               
 test line 1 
 

12. Write a program in C# Sharp to create and read the last line of a file. Go to the editor
Test Data
Input number of lines to write in the file :3
Input 3 strings below :
Input line 1 : line1
Input line 2 : line2
Input line 3 : line3
Expected Output:

 The content of the last line of the file mytest.txt is  :                                                    
 line3  
 

13. Write a program in C# Sharp to read a specific line from a file. Go to the editor
Test Data and Expected Output :

Input number of lines to write in the file  :3                                                               
 Input 3 strings below:                                                                                      
 Input line 1 : line1                                                                                         
 Input line 2 : line2                                                                                         
 Input line 3 : line3                                                                                         
  
 Input which line you want to display  :3                                                                     

 The content of the line 3 of the file mytest.txt is :                                                        
 line3          
 

14. Write a program in C# Sharp to create and read last n number of lines of a file. Go to the editor
Test Data and Expected Output :

 Input number of lines to write in the file :5                                                               
 Input 5 strings below :                                                                                      
 Input line 1 : line1                                                                                         
 Input line 2 : line2                                                                                         
 Input line 3 : line3                                                                                         
 Input line 4 : line4                                                                                         
 Input line 5 : line5                                                                                         
 
 Input last how many numbers of lines you want to display  :3                                                  

 The content of the last 3 lines of the file mytest.txt is :                                                  
 The last no 3 line is : line3                                                                                
 The last no 2 line is : line4                                                                                
 The last no 1 line is : line5          
 

15. Write a program in C# Sharp to count the number of lines in a file. Go to the editor
Expected Output:

 Here is the content of the file mytest.txt :                                                                 
 test line 1                                                                                                  
 test line 2                                                                                                  
 Test line 3                                                                                                  
 test line 4                                                                                                  
 test line 5                                                                                                  
 Test line 6                                                                                                  
 The number of lines in  the file mytest.txt is : 6         
