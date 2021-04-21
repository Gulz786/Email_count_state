//People class read data of people file and stored it in people variables


using System;
using System.Collections.Generic;
using System.Text;

namespace Email_count_state
{
    class People
    {

        public static int count = 0;
        public String FName { get; set; }
        public String LName { get; set; }
        public String Email { get; set; }
        public String State { get; set; }



        //Constructor
        public People(String DataLines)
        {
            string[] RowData = DataLines.Split(';');


            this.FName = RowData[0];
            this.LName = RowData[1];
            this.Email = RowData[2];
            this.State = RowData[3];



            count++;

        }

        // Fuction to Read line by line data of File
        public static void LoadPeopleData(string[] DataString, List<People> PplClass)
        {
            // Read one line one by and adding the values in constructor
            for (int i = 1; i < DataString.Length; i++)
            {
                // adding line and calling constructor to set the values of each line
                People people = new People(DataString[i]);

                // Adding data in the list of people class
                PplClass.Add(people);


            }
        }
        // Fuction is used to sending data line by line to verify
        public static void SharingObjValue (List<People> PplClass)
            {

            for (int j = 0; j < PplClass.Count; j++)
            {
                Allowed.GetState(PplClass[j].Email, PplClass[j].State);
            }


        }




    }
}
