using System;
namespace Assignment_1_Data_Structures_and_Algorithms
{
    internal class CustomerRecord
    {
        private Customers[] customers;
        private int noCustomers;

        public CustomerRecord()
        {
            customers = new Customers[10];
            noCustomers = 0;
        }
        public void InsertCustomeralt(Customers customer)
        {
            Customers aCustomer = new Customers();
            aCustomer = customer;
            customers[noCustomers] = aCustomer;
            noCustomers++;
        }
        public void Display()
        {
            for (int i = 0; i < noCustomers; i++)
                if(customers[i].PhoneNumber != 0)
            {
                Console.Write(customers[i]);
            }
        }
        public int Find(string fullname)
        {
            Tool aTool = new Tool();
            Customers aCustomer = new Customers(fullname, 0, aTool);
            for (int i = 0; i < noCustomers; i++)
                if (customers[i].CompareTo(aCustomer) == 0)
                {
                    return 0;
                }

            return 1;
        }
        public int FindIndex(string fullname)
        {
            Tool aTool = new Tool(" ", 0, " ");
            Customers aCustomer = new Customers(fullname, 0, aTool);
            for (int i = 0; i < noCustomers; i++)
                while (customers[i].CompareTo(aCustomer) == 0)
                {
                    return i;
                }
            return 999999;
        }
        public Tool ReturnTool(string fullname)
        {
            Tool aTool = new Tool(" ", 0, " ");
            Customers aCustomer = new Customers(fullname, 0, aTool);
            for (int i = 0; i < noCustomers; i++)
                while (customers[i].CompareTo(aCustomer) == 0)
                {
                    Customers temp = customers[i];
                    Tool found = temp.Tool;
                    return found;
                }
            Tool empty = null;
            return empty;
        }
        public void Delete(int indexnumber)
        {
            Console.WriteLine("The following customer record has been removed from the inventory management system:\n\n {0}" + "\nThe tool has now been returned to the Tool Libray\n", customers[indexnumber]);
            Tool aTool = new Tool();
            Customers aCustomer = new Customers();
            customers[indexnumber] = aCustomer;
        }
    }
}
