using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    class LinkedList
    {
      
        private Node _head = null;

        public void printAllNodes()
        {
            Node _current = _head;
            while (_current != null)
            {
                Console.WriteLine(_current.Data);
                _current = _current.next;
            }
        
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();
            toAdd.Data = data;
            toAdd.next = _head;
            _head = toAdd;
        
        }
        public void AddLast(Object data)
        {
            if (_head == null)
            {
                _head = new Node();
                _head.Data = data;
                _head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.Data = data;

                Node _current = _head;
                while(_current.next!=null)
                {

                    _current = _current.next;

                }
                _current.next = toAdd;
            }
        
        }
       
    }
}
