using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingDewey.Shared.Tree
{
    public class TreeDataStructure
    {
        public Node Root;
        public static List<int> CallNumbers = new();

        public TreeDataStructure()
        {
            Root = null;
        }

        //Populating the tree with the text file
        public bool Insert(string fileLine)
        {
            //Passing in the line from the file and then splitting up the number and description
            var lineArray = fileLine.Split(':');
            var number = Convert.ToInt32(lineArray[0]);
            var thirddescription = lineArray[1];
            var seconddescription = lineArray[2];
            var firstdescription = lineArray[3];

            CallNumbers.Add(number);

            Node before = null;
            Node after = Root;
            while (after is not null)
            {
                before = after;
                if (number < after.Data)
                {
                    after = after.Left;
                }
                else if (number > after.Data)
                {
                    after = after.Right;
                }
                else
                {
                    return false;
                }
            }

            Node newNode = new();
            newNode.Data = number;
            newNode.FirstLevelDescription = firstdescription;
            newNode.SecondLevelDescription = seconddescription;
            newNode.ThirdLevelDescription = thirddescription;
            if (Root is null)
            {
                Root = newNode;
            }
            else
            {
                if (number < before.Data)
                {
                    before.Left = newNode;
                }
                else
                {
                    before.Right = newNode;
                }
            }
            return true;
        }

        //Searches the tree for the node

        public Node Search(int value)
        {
            return Search(value, Root);
        }

        public Node Search(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Data)
                {
                    return parent;
                }
                if (value < parent.Data)
                {
                    return Search(value, parent.Left);
                }
                else
                {
                    return Search(value, parent.Right);
                }
            }
            return null;
        }
    }
}
