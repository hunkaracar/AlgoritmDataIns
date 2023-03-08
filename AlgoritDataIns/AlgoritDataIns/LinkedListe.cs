using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgoritDataIns
{
    public class LinkedListe
    {
        public Node? beginning;

        public LinkedListe()
        {
            beginning = null;   
        }

        public LinkedListe(int value)
        {
            beginning = new Node(value);
        }


        public void AddtoEnd(int value) 
        {
            Node willAddNode = new Node(value); 
            //add to start node if no element has been added before
            if (beginning == null)
            {
                beginning = willAddNode;
                return;
            }

            //find the last node add to it
            Node temp = beginning;
            while (temp.nextNode != null)
            {
                temp = temp.nextNode;   
            }

            temp.nextNode = willAddNode;
        }

        public void AddtoHead(int value) 
        {
            Node willAddNode = new Node(value);
            willAddNode.nextNode = beginning;
            beginning = willAddNode; 
            
        }

        public void Delete(int value)
        {
            //Origin node is assigned a value
            Node? temp = beginning;
            Node? previousNode = null;

            //If the sought value is the origin node, the start
            //The next node becomes the starting node.

            if (temp != null && temp.data == value)
            {
                this.beginning = temp.nextNode;
                return;
            }

            //Rotate until you find the searched value or reach the end of the list
            while(temp != null && temp.data != value) 
            {
                previousNode = temp;
                temp = temp.nextNode;    
            }

            //If the searched value is not in the array, do nothing.
            if (temp == null) return;
            //The next node of the previous node of the sought value
            //sync address to next node address of searched value
            previousNode.nextNode = temp.nextNode;
        }

        public void DeletefromIndex(int indexValue)
        {
            //if you want to delete the top node
            if (indexValue == 0)
            {
                this.beginning = beginning.nextNode;
                return;
            }
            Node? temp = beginning;
            Node? previousNode = temp;

            int nowIndex = 0;
            //Rotate until you reach the desired index value

            while (temp != null && indexValue != nowIndex)
            {
                previousNode = temp;
                temp = temp.nextNode;
                nowIndex++;
            }

            //If the current index value is the desired index value, make the assignment
            if (indexValue == nowIndex)
            {
                previousNode.nextNode = temp.nextNode;
            }
        }

        public void print()
        {
            Node? temp = beginning;

            while (temp != null)
            {
                Console.WriteLine(" => {0} ",temp.data);
                temp = temp.nextNode;   
            }
        }
    }
}
