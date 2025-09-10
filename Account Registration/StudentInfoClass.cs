using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Registration
{
    public class StudentInfoClass
    {
        public delegate int DelegateNumber(int number);
        public delegate string DelegateText(string text);

        //String      
        public static string FullName = "";
        public static string Program = "";
        public static string Address = "";
        public static string Gender = "";
        public static string Birthday = "";
        public static string Age = "";
        //int
        public static int ContactNo = 0;
        public static int StudentNo = 0;

        // Setters
        //Ints
        public int SetStudentNo = 0;
        public int SetContactNo = 0;
        //Strings
        public string SetFullName = "";
        public string SetProgram = "";
        public string SetAddress = "";
        public string SetGender = "";
        public string SetBirthday = "";

        //Return types

        public static string GetFullName(string FullName)
        {
            return FullName;
        }
        
        public static string GetProgram(string Program)
        {
            return Program;
        }
        public static string GetAddress(string Address)
        {
            return Address;
        }
        public static string GetGender(string Gender)
        {
            return Gender;
        }
        public static string GetBirthday(string Birthday)
        {
            return Birthday;
        }
        public static string GetAge(string Age)
        {
            return Age;
        }
        public static int GetContactNo(int ContactNo)
        {
            return ContactNo;
        }
        public static int GetStudentNo(int StudentNo)
        {
            return StudentNo;
        }


    }

}
