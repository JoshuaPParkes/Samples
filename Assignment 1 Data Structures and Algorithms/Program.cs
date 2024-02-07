using System;
namespace Assignment_1_Data_Structures_and_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            CustomerRecord customerlist = new CustomerRecord();

            ToolCatergories gardeningtools = new ToolCatergories();
            ToolCatergories flooringtools = new ToolCatergories();
            ToolCatergories fencingtools = new ToolCatergories();
            ToolCatergories measuringtools = new ToolCatergories();
            ToolCatergories cleaningtools = new ToolCatergories();
            ToolCatergories paintingtools = new ToolCatergories();
            ToolCatergories electronicttools = new ToolCatergories();
            ToolCatergories electricitytools = new ToolCatergories();
            ToolCatergories automotivetools = new ToolCatergories();

            while (running == true)
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine("Welcome to the Tool Library");
                Console.WriteLine("************************************************************");
                Console.WriteLine("Please choose an Option:\n\n1.Add New Tool to library\n2.Rent Out Tool to Customer\n3.Return Tool From Customer\n4.View Tool Inventory\n5.View List of Current Customers\n>>>");
                bool worked = int.TryParse(Console.ReadLine(), out int menuchoice);
                Console.Clear();

                if (worked == true && menuchoice >= 1 && menuchoice <= 5)
                {
                    Console.Clear();
                }
                else
                {

                }
                //ADD TOOL
                if (menuchoice == 1)
                { //SELECT TOOL TYPE
                    Console.WriteLine("You have selected to add a new tool to the Tool Library");
                    int cat = Catergories();
                    if (cat == 1)
                    {
                        Console.WriteLine("You have selected gardening tools \n ");
                        AddTool(gardeningtools);
                    }
                    else if (cat == 2)
                    {
                        Console.WriteLine("You have selected flooring tools \n ");
                        AddTool(flooringtools);
                    }
                    else if (cat == 3)
                    {
                        Console.WriteLine("You have selected fencing tools \n ");
                        AddTool(fencingtools);
                    }
                    else if (cat == 4)
                    {
                        Console.WriteLine("You have selected measuring tools \n ");
                        AddTool(measuringtools);
                    }
                    else if (cat == 5)
                    {
                        Console.WriteLine("You have selected cleaning tools \n ");
                        AddTool(cleaningtools);
                    }
                    else if (cat == 6)
                    {
                        Console.WriteLine("You have selected painting tools \n ");
                        AddTool(paintingtools);
                    }
                    else if (cat == 7)
                    {
                        Console.WriteLine("You have selected electronic tools \n ");
                        AddTool(electronicttools);
                    }
                    else if (cat == 8)
                    {
                        Console.WriteLine("You have selected electricity tools \n ");
                        AddTool(electricitytools);
                    }
                    else if (cat == 9)
                    {
                        Console.WriteLine("You have selected automotive tools \n ");
                        AddTool(automotivetools);
                    }
                }

                else if (menuchoice == 2)
                {    // RENT TOOL
                    Console.WriteLine("You have selected to rent a tool to a customer\n");
                    Console.WriteLine("Add full name of customer >>>");
                    string nameof = Console.ReadLine();
                    while (nameof.Length <= 0)
                    {
                        Console.WriteLine("\nA valid name is required!\a");
                        nameof = Console.ReadLine();
                    }
                    Console.WriteLine("add phone number >>>");
                    bool work = int.TryParse(Console.ReadLine(), out int numberof);
                    while (work == false || numberof <= 0)
                    {
                        Console.WriteLine("\nPlease enter a valid phone number!\a");
                        work = int.TryParse(Console.ReadLine(), out numberof);
                    }
                    //SELECT TOOL TYPE
                    int customerselection = Catergories();
                    Console.Clear();

                    if (customerselection == 1)
                    {
                        RentTool(nameof, numberof, gardeningtools, customerlist);
                    }
                    else if (customerselection == 2)
                    {
                        RentTool(nameof, numberof, flooringtools, customerlist);
                    }
                    else if (customerselection == 3)
                    {
                        RentTool(nameof, numberof, fencingtools, customerlist);
                    }
                    else if (customerselection == 4)
                    {
                        RentTool(nameof, numberof, measuringtools, customerlist);
                    }
                    else if (customerselection == 5)
                    {
                        RentTool(nameof, numberof, cleaningtools, customerlist);
                    }
                    else if (customerselection == 6)
                    {
                        RentTool(nameof, numberof, paintingtools, customerlist);
                    }
                    else if (customerselection == 7)
                    {
                        RentTool(nameof, numberof, electronicttools, customerlist);
                    }
                    else if (customerselection == 8)
                    {
                        RentTool(nameof, numberof, electricitytools, customerlist);
                    }
                    else if (customerselection == 9)
                    {
                        RentTool(nameof, numberof, automotivetools, customerlist);
                    }
                }

                else if (menuchoice == 3)
                {   //RETURN TOOL
                    Console.WriteLine("Please enter the full name of the customer that is returning tool >>>");
                    string returnname = Console.ReadLine();

                    //CHECK TO SEE IF CUSTOMER EXISTS
                    int exists = customerlist.Find(returnname);


                    if (exists == 0)
                    {   //FINDS ARRAY INDEX NUMBER FOR THAT TOOL
                        int indexnumber = customerlist.FindIndex(returnname);

                        //CREATES A NEW TOOL WHICH IS A COPY OF THE TOOL IN ARRAY
                        Tool copy = customerlist.ReturnTool(returnname);

                        //DISPLAYS TOOL THAT IS BEING RETURNED
                        Console.WriteLine("\nThis customer is returning the following tool from the Tool Libray:\n\n {0}", copy);

                        //SELECTS WHAT TOOL TYPE THE TOOL CATERGORY IS TO BE RETURNED TO
                        Console.WriteLine("\nPlease select the type of tool that it belongs to >>>");
                        int customerselection = Catergories();
                        if (customerselection == 1)
                        {
                            ReturnTool(copy, gardeningtools, customerlist, indexnumber);
                        }
                        else if (customerselection == 2)
                        {
                            ReturnTool(copy, flooringtools, customerlist, indexnumber);
                        }
                        else if (customerselection == 3)
                        {
                            ReturnTool(copy, fencingtools, customerlist, indexnumber);
                        }
                        else if (customerselection == 4)
                        {
                            ReturnTool(copy, measuringtools, customerlist, indexnumber);
                        }
                        else if (customerselection == 5)
                        {
                            ReturnTool(copy, cleaningtools, customerlist, indexnumber);
                        }
                        else if (customerselection == 6)
                        {
                            ReturnTool(copy, paintingtools, customerlist, indexnumber);
                        }
                        else if (customerselection == 7)
                        {
                            ReturnTool(copy, electronicttools, customerlist, indexnumber);
                        }
                        else if (customerselection == 8)
                        {
                            ReturnTool(copy, electricitytools, customerlist, indexnumber);
                        }
                        else if (customerselection == 9)
                        {
                            ReturnTool(copy, automotivetools, customerlist, indexnumber);
                        }
                    }
                    else
                    {
                        Console.WriteLine("sorry that customer name is not in the inventory managment system");
                    }
                    Console.WriteLine("Press any key to return to the main menu");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (menuchoice == 4)
                {
                    Console.WriteLine("You have selected to view the tool inventory");
                    int cat = Catergories();
                    Console.WriteLine("*****************************************************************************");
                    Console.WriteLine("The following is a list of all available tools of this tool type");
                    Console.WriteLine("*****************************************************************************\n");
                    if (cat == 1)
                    {
                        //SORTS TOOL TYPE ARRAY INTO ALPHABETICAL ORDER
                        gardeningtools.Sort();

                        // DISPLAYS TOOL TYPE ARRAY
                        gardeningtools.Display();
                    }
                    else if (cat == 2)
                    {
                        flooringtools.Sort();
                        flooringtools.Display();
                    }

                    else if (cat == 3)
                    {
                        fencingtools.Sort();
                        fencingtools.Display();
                    }
                    else if (cat == 4)
                    {
                        measuringtools.Sort();
                        measuringtools.Display();
                    }
                    else if (cat == 5)
                    {
                        cleaningtools.Sort();
                        cleaningtools.Display();
                    }
                    else if (cat == 6)
                    {
                        paintingtools.Sort();
                        paintingtools.Display();
                    }
                    else if (cat == 7)
                    {
                        electronicttools.Sort();
                        electronicttools.Display();
                    }
                    else if (cat == 8)
                    {
                        electricitytools.Sort();
                        electricitytools.Display();
                    }
                    else if (cat == 9)
                    {
                        automotivetools.Sort();
                        automotivetools.Display();
                    }
                    Console.WriteLine("\nPress any key to return to the main menu");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (menuchoice == 5)
                {
                    //DISPLAY ALL CUSTOMERS IN CUSTOMER RECORD
                    Console.WriteLine("*****************************************************************************");
                    Console.WriteLine("The following is a list of all customers that are currently renting a tool:");
                    Console.WriteLine("*****************************************************************************\n");
                    customerlist.Display();
                    Console.WriteLine("\nPress any key to return to the main menu");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }     

        public static int ToolQuantity()// check for compile errors, else statement may need fixing
        {
            Console.WriteLine("\nEnter tool quantity >>>");
            bool valid = int.TryParse(Console.ReadLine(), out int quant);
            if (valid == false || quant <= 0)
            {
                Console.WriteLine("Invalid response! Please enter only whole positive numbers \a");
                ToolQuantity();
            }
            return quant;
        }
        public static int Catergories()
        {
            Console.WriteLine("\nSelect Tool Type:\n\n1.gardening tools \n2.flooring tools \n3.fencing tools \n4.measuring tools \n5.cleaning tools \n6.painting tools \n7.electronic tools \n8.electricity tools \n9.automotive tools. ");
            Console.WriteLine("************************************************************");
            Console.WriteLine("Enter number to coresponding tool catergotry");
            bool worked = int.TryParse(Console.ReadLine(), out int cat);
            Console.Clear();
            while (worked == false || cat < 1 || cat > 9)
            {
                
                Console.WriteLine("Please enter valid value between 1 and 9!\n\a");
                Console.WriteLine("Select Tool Type:\n\n1.gardening tools \n2.flooring tools \n3.fencing tools \n4.measuring tools \n5.cleaning tools \n6.painting tools \n7.electronic tools \n8.electricity tools \n9.automotive tools. ");
                Console.WriteLine("************************************************************");
                worked = int.TryParse(Console.ReadLine(), out cat);
                Console.Clear();
            }
            return cat;
        }

        public static void AddTool(ToolCatergories type)
        {
            Console.WriteLine("Add tool name >>>");
            string names = Console.ReadLine();
            // CHECK TO SEE IF EXISTS
            int exists = type.Find(names);
            if (exists == 0)
            {
                Console.WriteLine("\nThis tool currently exists in the tool library. You need to change only the quantity of this tool");

                //FINDS INDEX OF ARRAY AND COPIES TO INT VARIABLE
                int indexnumber = type.FindIndex(names);

                // CHANGES QUANTITY OF TOOL
                type.Addquantity(indexnumber);
            }
            else if (exists == 1)
            {
                Console.WriteLine("\nThis tool doesn't currently exist in the tool library. Please add both a description and a quantity of this tool\n");
                Console.WriteLine("Enter tool desciption >>>");
                string descriptions = Console.ReadLine();
                int quantites = ToolQuantity();
                //CREATES TOOL AND INSERTS INTO TOOL TYPE ARRAY
                type.Insert(names, quantites, descriptions);
                Console.WriteLine("\nThis tool has now been added to the inventory\n");
                Console.WriteLine("Press any key to return to the main menu");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void RentTool(string name, int number, ToolCatergories type, CustomerRecord people)
        {
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("The following is a list of all available tools of this tool type");
            Console.WriteLine("*****************************************************************************\n");
            type.Display();

            Console.WriteLine("\nWhich tool would you like to rent?\nPlease enter tool name or press 1 to exit >>>");
            string nameoftool = Console.ReadLine();
            if (nameoftool == "1")
            {
                Console.Clear();
            }
            else
            {
                while (nameoftool.Length <= 0)
                {
                    Console.WriteLine("Invalid selection!\nInput is required!\a\n");
                    nameoftool = Console.ReadLine();
                }

                if (nameoftool != "1")
                {
                    // FIND IF TOOL EXISTS IN CATERGORIE
                    int exists = type.Find(nameoftool);

                    if (exists == 0)
                    {   //FINDS ARRAY INDEX NUMBER FOR THAT TOOL
                        int indexnumber = type.FindIndex(nameoftool);

                        //CREATES A NEW TOOL WHICH IS A COPY OF THE TOOL IN ARRAY
                        Tool copy = type.ReturnTool(nameoftool);
                        Console.WriteLine("\nYou have selected the following tool from the Tool Libray:\n" + copy);

                        //MAKES SURE RENTED TOOL HAS A QUANTITY OF ONLY 1
                        if (copy.ToolQuantity == 0)
                        {
                            Console.WriteLine("Invalid selection!\nThat Tool does not exist in the Tool Library!\a");
                        }
                        if
                        (copy.ToolQuantity >= 2 && copy.ToolQuantity <= 1)
                        {
                            copy.ToolQuantity = 1;
                        }
                        else
                        {
                            copy.ToolQuantity = 1;
                        }

                        //CREATES A NEW CUSTOMER THAT HAS THE USER INPUT AND TOOL IS A COPY OF TOOL IN ARRAY WITH QTY 1
                        Customers Cust = new Customers(name, number, copy);
                        Console.WriteLine("\nThe new customer record will be\n\n" + Cust);

                        //INSERTS NEW CUSTOMER INTO CUSTOMER LIST
                        people.InsertCustomeralt(Cust);


                        //THE DELETES THE TOOL FROM TOOL TYPE ARRAY OR DECREASES QTY OF TOOL IF MORE THAN 1
                        type.Delete(indexnumber);
                    }
                    if (exists == 1)
                    {
                        Console.WriteLine("\nSorry that tool does not exist in the inventory");
                    }
                
                }
                Console.WriteLine("Press any key to return to the main menu");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void ReturnTool(Tool tool, ToolCatergories type, CustomerRecord people, int indexnumber)
{                           
 					//COPIES TOOL NAME INTO NEW STRING VARIABLE				
					string toollook = tool.ToolName;

                            //FINDS IF TOOL IS ALREADY IN INVENTORY
                            int isthere = type.Find(toollook);
                            if (isthere == 0)
                            {
                                Console.WriteLine("This tool is aready in the inventory management stystem. You must change the quantity. Press any key to add quantity of tool by 1");

                                ///FINDS ARRAY INDEX NUMBER FOR THAT TOOL
                                int index = type.FindIndex(toollook);

                                //THIS EDITS THE QUANTITY OF TOOL 
                                type.Addquantity(index);

                                //REMOVES CUSTOMER FROM CUSTOMER RECORD
                                people.Delete(indexnumber);
                            }
                            else
                            {   //INSERTS TOOL INTO TOOL TYPE ARRAY
                                type.InsertTool(tool);

                                //REMOVES CUSTOMER FROM CUSTOMER RECORD
                                people.Delete(indexnumber);
                            }
                        
                        
                    }

    }
}


