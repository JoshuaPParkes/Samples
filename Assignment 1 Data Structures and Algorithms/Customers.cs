using System;
namespace Assignment_1_Data_Structures_and_Algorithms
{
    internal class Customers
    {
        private string fullName;
        private int phoneNumber;
        private Tool tool;
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public Tool Tool
        {
            get { return tool; }
            set { tool = value; }
        }
        public Customers(string name, int number, Tool tool)
        {
            fullName = name;
            phoneNumber = number;
            Tool = tool;
        }
        public Customers()
        {

        }
        public int CompareTo(Customers another) 
        {
            if (this.fullName.CompareTo(another.fullName) < 0)
            {
                return -1;
            }
            else if (this.fullName.CompareTo(another.fullName) > 0)
            {
                return 1;
            }
            else if
                (this.fullName.CompareTo(another.fullName) == 0)
            {

                return 0;
            }
            else return 0;
        }
        public override string ToString()
        {
            return $"CUSTOMER NAME:{fullName}       CUSTOMER PHONE NUMBER: {phoneNumber}        {tool}\n";
        }
    }
}
