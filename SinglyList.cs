class Node
{
    public int Data;
    public Node Next;
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class SinglyLinkedList
{
    public Node Head;

    public void InsertAtBeginning(int value)
    {
        Node newNode = new Node(value);
        newNode.Next = Head;        // list khali ho to Head null hai, wo bhi theek hai
        Head = newNode;
    }

    public void InsertAtEnd(int value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            return;
        }
        Node Current = Head;
        while (Current.Next != null)
            Current = Current.Next;
        Current.Next = newNode;
    }

    public void InsertAtPosition(int position, int value)
    {
        if (position == 0)
        {
            InsertAtBeginning(value);
            return;
        }
        Node Current = Head;
        for (int i = 0; i < position - 1 && Current != null; i++)
            Current = Current.Next;

        if (Current == null) return;    // invalid position

        Node newNode = new Node(value);
        newNode.Next = Current.Next;
        Current.Next = newNode;
    }

    public void DeleteAtBeginning()
    {
        if (Head == null) return;
        Head = Head.Next;
    }

    public void DeleteAtEnd()
    {
        if (Head == null) return;
        if (Head.Next == null)          // sirf 1 node
        {
            Head = null;
            return;
        }
        Node Current = Head;
        while (Current.Next.Next != null)
            Current = Current.Next;
        Current.Next = null;
    }

    public void DeleteAtPosition(int position)
    {
        if (Head == null) return;
        if (position == 0)
        {
            Head = Head.Next;
            return;
        }
        Node Current = Head;
        for (int i = 0; i < position - 1 && Current != null; i++)
            Current = Current.Next;

        if (Current == null || Current.Next == null) return;   // invalid position

        Current.Next = Current.Next.Next;   // target ko skip kar do
    }

    public void Search(int value)
    {
        Node Current = Head;
        int position = 0;
        while (Current != null)
        {
            if (Current.Data == value)
            {
                Console.WriteLine($"Value {value} found at position {position}.");
                return;
            }
            Current = Current.Next;
            position++;
        }
        Console.WriteLine($"Value {value} not found.");
    }

    public void Display()
    {
        Node Current = Head;
        while (Current != null)
        {
            Console.Write(Current.Data + " ");
            Current = Current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        SinglyLinkedList list = new SinglyLinkedList();

        list.InsertAtEnd(10);
        list.InsertAtEnd(20);
        list.InsertAtEnd(30);
        list.InsertAtEnd(40);
        list.InsertAtEnd(50);
        list.Display();                 // 10 20 30 40 50

        list.InsertAtBeginning(5);
        list.Display();                 // 5 10 20 30 40 50

        list.InsertAtPosition(3, 25);
        list.Display();                 // 5 10 20 25 30 40 50

        list.Search(30);                // found at position 4
        list.Search(99);                // not found

        list.DeleteAtBeginning();
        list.Display();                 // 10 20 25 30 40 50

        list.DeleteAtEnd();
        list.Display();                 // 10 20 25 30 40

        list.DeleteAtPosition(2);
        list.Display();                 // 10 20 30 40

        Console.ReadLine();
    }
}