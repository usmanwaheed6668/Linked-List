class DoublyList
{
    public DoublyList Previous;
    public int Data;
    public DoublyList Next;
    public DoublyList(int data)
    {
        this.Data = data;
        Previous = null;
        Next = null;
    }

}
class DoublyLinkedList
{
    public DoublyList Head;
    public DoublyList Tail;

    public void InsertAtBeginning(int value)
    {
        DoublyList newNode = new DoublyList(value);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }
    }
    public void InsertAtEnd(int value)
    {
        DoublyList newNode = new DoublyList(value);
        if (Tail == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            newNode.Previous = Tail;
            Tail = newNode;
        }
    }
    public void InsertAtPosition(int position, int value)
    {

        if (position == 0)
        {
            InsertAtBeginning(value);
            return;
        }
        DoublyList Current = Head;
        for (int i = 0; i < position - 1; i++)
        {
            if (Current != null)
                Current = Current.Next;
        }
        if (Current == null || Current.Next == null)
        {
            InsertAtEnd(value);
            return;
        }
        DoublyList newNode = new DoublyList(value);
        newNode.Next = Current.Next;
        newNode.Previous = Current;
        Current.Next.Previous = newNode;
        Current.Next = newNode;

    }
    // Deletion 
    public void DeleteAtBeginning()
    {
        if (Head == null)
        {
            Console.WriteLine("List is empty. Nothing to delete.");
            return;
        }

        Console.WriteLine($"Deleted {Head.Data} from the beginning.");
        if (Head == Tail)
        {
            Head = Tail = null; // Only one node was present
        }
        Head = Head.Next;
        Head.Previous = null;
    }
    public void DeleteAtEnd()
    {
        if (Tail == null)
        {
            Console.WriteLine("List is empty. Nothing to delete.");
            return;
        }
        if (Head == Tail)
        {
            Console.WriteLine($"Deleted {Tail.Data} from the end.");
            Head = Tail = null; // Only one node was present
            return;
        }
        Tail = Tail.Previous;
        Tail.Next = null;
    }
    public void DeleteAtPosition(int position)
    {
        if (position == 0)
        {
            DeleteAtBeginning();
            return;
        }
        DoublyList Current = Head;
        for (int i = 0; i < position; i++)
        {
            if (Current != null)
                Current = Current.Next;
        }
        if (Current == Tail)
        {
            DeleteAtEnd();
            return;
        }
        if (Current == null)
        {
            Console.WriteLine("Position out of bounds. Nothing to delete.");
            return;
        }
        Current.Previous.Next = Current.Next;
        Current.Next.Previous = Current.Previous;
    }
    public void Search(int value)
    {
        DoublyList Current = Head;
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
        Console.WriteLine($"Value {value} not found in the list.");
    }
    public void TraverseForward()
    {
        DoublyList Current = Head;
        while (Current != null)
        {
            Console.Write(Current.Data + " ");
            Current = Current.Next;
        }
        Console.WriteLine();
    }
    public void TraverseBackward()
    {
        DoublyList Current = Tail;
        while (Current != null)
        {
            Console.Write(Current.Data + " ");
            Current = Current.Previous;
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        DoublyLinkedList list = new DoublyLinkedList();

        // Insert at End
        list.InsertAtEnd(10);
        list.InsertAtEnd(20);
        list.InsertAtEnd(30);
        list.InsertAtEnd(40);
        list.InsertAtEnd(50);
        Console.WriteLine("After InsertAtEnd (10..50):");
        list.TraverseForward();      // 10 20 30 40 50
        list.TraverseBackward();     // 50 40 30 20 10

        // Insert at Beginning
        list.InsertAtBeginning(5);
        Console.WriteLine("\nAfter InsertAtBeginning(5):");
        list.TraverseForward();      // 5 10 20 30 40 50

        // Insert at Position
        list.InsertAtPosition(3, 25);
        Console.WriteLine("\nAfter InsertAtPosition(3, 25):");
        list.TraverseForward();      // 5 10 20 25 30 40 50
        list.TraverseBackward();

        // Search
        Console.WriteLine();
        list.Search(30);             // found at position 4
        list.Search(99);             // not found

        // Delete at Beginning
        Console.WriteLine();
        list.DeleteAtBeginning();
        list.TraverseForward();      // 10 20 25 30 40 50

        // Delete at End
        list.DeleteAtEnd();
        Console.WriteLine("\nAfter DeleteAtEnd:");
        list.TraverseForward();      // 10 20 25 30 40

        // Delete at Position (middle)
        list.DeleteAtPosition(2);    // removes 25
        Console.WriteLine("\nAfter DeleteAtPosition(2):");
        list.TraverseForward();      // 10 20 30 40
        list.TraverseBackward();     // 40 30 20 10

        Console.ReadLine();
    }
}