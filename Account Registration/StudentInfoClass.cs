﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Registration
{
    public class StudentInfoClass
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string text);

        //String
        public static string FirstName = "";
        public static string LastName = "";
        public static string MiddleName = "";
        public static string Program = "";
        public static string Address = "";
        //Long
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;
        //Return types
        public static string GetFirstName(string FirstName) =>FirstName;
        public static string GetLastName(string LastName) => LastName;
        public static string GetMiddleName(string MiddleName) => MiddleName;
        public static string GetProgram(string Program) => Program;
        public static string GetAddress(string Address) => Address;
        public static long GetAge(long Age) => Age;
        public static long GetContactNO(long ContactNo) => ContactNo;
        public static long GetStudentNo(long StudentNo) => StudentNo;

    }
}
