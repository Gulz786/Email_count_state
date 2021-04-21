//Allowed class read data of Allowed file and stored it in Allowed variables .Main logic of processing is also in this class.


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Email_count_state
{
    class Allowed
    {


        public String TestEmail { get; set; }
        public bool IsAllowed { get; set; }
        public static int count = 0;
        // list to hold  true emails
        static List<string> TrueEmails = new List<string>();
        //list to hold allowed states
        static List<string> TrueStates = new List<string>();


        // Constructor used to initialize the values of variables
        public Allowed(String DataLines)
        {

            string[] RowData = DataLines.Split(';');

            this.TestEmail = RowData[0];
            this.IsAllowed = Convert.ToBoolean(RowData[1]);

            // Taking allowed Emails and copy it into an array
            if (RowData[1] == "True")
            {

                TrueEmails.Add(RowData[0]);

            }

            // keep the Number of Records
            count++;

        }

        public static void LoadAllowedData(string[] DataString)
         {
            // Read one line one by and adding the values in constructor
            for (int i = 1; i < DataString.Length; i++)
            {   
                // adding line and calling constructor to set the values of each line
                Allowed Allow = new Allowed(DataString[i]);

            }

        }
        // Fuction is used to match email and find find true states and add it into list 
        public static void GetState(String searchEmail, String State)
        {

            //compare value with list of email with true values 
            var MatchingValues = TrueEmails.Exists(stringToCheck => stringToCheck.Equals(searchEmail));

            //when matching value return true states are added into list
            if (MatchingValues==true)
            {
                TrueStates.Add(State);
                
            }


            
        }
        // Function is used to print list of allowed states with count
        public static void PrintState()
        {
            Console.WriteLine("State Name        : Email Count ");


            foreach (var grp in TrueStates.GroupBy(i => i))
            {
                Console.WriteLine("{0}        : {1}", grp.Key, grp.Count());
            }



        }

    }
}
