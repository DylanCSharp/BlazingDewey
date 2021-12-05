using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingDewey.Shared.Tree
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Data { get; set; }
        public string FirstLevelDescription { get; set; }
        public string SecondLevelDescription { get; set; }
        public string ThirdLevelDescription { get; set; }
    }
}
