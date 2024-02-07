using System;
namespace Assignment_1_Data_Structures_and_Algorithms
{
    internal class Tool
    {
        private string toolName;
        private string toolDescription;
        private int toolQuantity;

        public string ToolName
        {
            get
            { return toolName; }

            set
            { toolName = value; }
        }

        public string ToolDescription
        {
            get
            { return toolDescription; }

            set
            { toolDescription = value; }
        }

        public int ToolQuantity
        {
            get
            { return toolQuantity; }

            set
            { toolQuantity = value; }
        }
        public Tool(string name, int quantity, string descrip)
        {
            toolName = name;
            toolDescription = descrip;
            toolQuantity = quantity;

        }
        public Tool()
        {
            toolName = "";
            toolDescription = "";
            toolQuantity = 0;
        }
        public int CompareTo(Tool another) 
        {
            if (this.toolName.CompareTo(another.toolName) < 0)
            {
                return -1;
            }
            else if (this.toolName.CompareTo(another.toolName) > 0)
            {
                return 1;
            }
            else if
                (this.toolName.CompareTo(another.toolName) == 0) 
            {
                return 0;
            }
            else return 0;
        }
        public override string ToString()
        {
            return $"TOOL NAME: {toolName}       TOOL DESCRIPTION: {toolDescription}        QUANTITY: {toolQuantity}\n";
        }
    }
}
