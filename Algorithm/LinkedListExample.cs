//LinkedListExample.LinkedList linkedList = new LinkedListExample.LinkedList();
//linkedList.AddNodeToFront(5);
//linkedList.AddNodeToFront(7);
//linkedList.AddNodeToFront(1);
//linkedList.AddNodeToFront(5);
//linkedList.AddNodeToFront(10);
//linkedList.AddNodeToFront(15);
//linkedList.AddNodeToFront(4);
//linkedList.AddNodeToFront(2);
//linkedList.AddNodeToFront(87);
//linkedList.PrintList();
//Console.ReadLine();

public class LinkedListExample
{
    public class LinkedListNode
    {
        public int data;
        public LinkedListNode? next;

        public LinkedListNode(int x)
        {
            data = x;
            next = null;
        }
    }

    public class LinkedList
    {
        int count;
        LinkedListNode head;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public void AddNodeToFront(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;
            head = node;
            count++;
        }

        public void PrintList()
        {
            LinkedListNode runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }
    }
}
