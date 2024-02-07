using System;
namespace Assignment_1_Data_Structures_and_Algorithms
{
    internal class ToolCatergories
    {
        private Tool[] tools;
        private int noTools;

        public ToolCatergories()
        {
            tools = new Tool[10];
            noTools = 0;
        }
        public void Insert(string toolName, int toolQuantity, string toolDescription)
        {
            Tool aTool = new Tool(toolName, toolQuantity, toolDescription);
            tools[noTools] = aTool;
            noTools++;
        }
        public void InsertTool(Tool tool)
        {
            tools[noTools] = tool;
            noTools++;
        }
        public void Display()
        {
            for (int i = 0; i < noTools; i++)
                if (tools[i].ToolQuantity != 0)
                { 
                    Console.WriteLine(tools[i]); 
                }
        }
        public int Find(string toolName)
        {
            Tool aTool = new Tool(toolName, 0, " ");
            for (int i = 0; i < noTools; i++)
                if (tools[i].CompareTo(aTool) == 0)
                {
                    return 0;
                }
            return 1;
        }
        public void Sort()
        {
            int min;
            Tool temp;
            for (int i = 0; i <= (noTools - 2); i++)
            {
                min = i;
                for (int j = (i + 1); j <= (noTools - 1); j++)
                    if (tools[j].CompareTo(tools[min]) == -1)
                        min = j;
                temp = tools[i];
                tools[i] = tools[min];
                tools[min] = temp;
            }
        }
        public Tool ReturnTool(string toolName)
        {
            Tool aTool = new Tool(toolName, 0, " ");
            for (int i = 0; i < noTools; i++)
                while (tools[i].CompareTo(aTool) == 0)
                {
                    Tool found = tools[i];
                    return found;
                }
            Tool empty = null;
            return empty;
        }
        public int FindIndex(string toolName)
        {
            Tool aTool = new Tool(toolName, 0, " ");
            for (int i = 0; i < noTools; i++)
                while (tools[i].CompareTo(aTool) == 0)
                {
                    return i;
                }
            return 999999;
        }
        public void Addquantity(int indexnumber)
        {
            Console.WriteLine("\nTo add quantity by 1 press A or to decrease qantity by 1 press D");
            string answer = Console.ReadLine();
            if (tools[indexnumber].ToolQuantity <= 0)
            {
                Console.WriteLine("\nTool quantity can not be less than 0!\a");
            }
            else
            {
                if (answer == "A" || answer == "a")
                {
                    tools[indexnumber].ToolQuantity++;
                    Console.WriteLine("\nThe new entry is:\n\n" + tools[indexnumber]);
                }
                else if (answer == "D" || answer == "d")
                {
                    tools[indexnumber].ToolQuantity--;
                    if (tools[indexnumber].ToolQuantity == 0)
                    {
                        Tool aTool = new Tool();
                        tools[indexnumber] = aTool;
                        Console.WriteLine("\nThe new entry is:\n\n" + tools[indexnumber]);
                    }
                }
                else
                {
                    Console.WriteLine("invalid Response! Please try again!\a");
                    Addquantity(indexnumber);
                }
            }
                Console.WriteLine("\nPress any key to return to the main menu");
                Console.ReadLine();
                Console.Clear();
        }
        public void Delete(int indexnumber)
        {
            int j = tools[indexnumber].ToolQuantity;
            if (j <= 1)
            {
                Tool aTool = new Tool();
                tools[indexnumber] = aTool;  
            }
            else
            {  
                tools[indexnumber].ToolQuantity --;  
            }
        }
    }
}

