using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Node
    {
        int data;
        Node left;
        Node right;

        public Node Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }
    }
}
