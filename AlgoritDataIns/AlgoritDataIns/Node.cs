using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritDataIns
{
    public class Node
    {
        public int data;
        public Node? nextNode;
        public Node(int value)
        {
            nextNode = null;
            data = value;   
        }  
    }
}
