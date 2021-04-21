/*
*   This is the main file of Project in which I passed the files to read. I also have two classes in this project. One is 'Allowed' and other is
    'People'. 
*   People class will handle properties of People file and Allowed will handle other file properties.

*    In this project logic is to read files and store values by using constructor. In allowed class constructor, a list of 
*    email with true values also stored in a list 'TrueEmail' variable. after reading all values from people file we compare
     email with list of true email by using below logic

*    'var MatchingValues = TrueEmails.Exists(stringToCheck => stringToCheck.Equals(searchEmail))'
     than create a list of True states.

*     and print TrueState list by using groupby function

*/

using System;
using System.Collections.Generic;
using System.IO;

namespace Email_count_state
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               //Read CSV Files 

                string[] ReadFile1 = File.ReadAllLines(@"C:\Users\njaf\Desktop\Tikean Oy\people.csv");
                string[] ReadFile2 = File.ReadAllLines(@"C:\Users\njaf\Desktop\Tikean Oy\allowed.csv");

                // Create New list of People class
                var PplClass = new List<People>();
               
                //Load Data into List of People class and calling Constructor
                People.LoadPeopleData(ReadFile1, PplClass);

                //Load Data into List of Allowed class and calling Constructor
                Allowed.LoadAllowedData(ReadFile2);


                //sharing data by using loop
                People.SharingObjValue(PplClass);
            
                Allowed.PrintState();
                
            }      
            catch (Exception e)
            {
                Console.WriteLine("File cannot be read");
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();



        }


    }
}

