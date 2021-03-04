using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Reto
{
    public class ReverseIterator
    {
        private Node currentNode;

        public ReverseIterator(Node currentNode)
        {
            this.currentNode = currentNode;
        }

        public ReverseIterator(ReverseIterator reverseIterator)
        {
            currentNode = reverseIterator.currentNode;
        }

        public Boolean hasNext()
        {
            return currentNode != null;
        }

        public int next()
        {
            int data = currentNode.getData();

            currentNode = currentNode.getPrevious();

            return data;
        }

        Node getCurrentNode()
        {
            return currentNode;
        }

    }
}
