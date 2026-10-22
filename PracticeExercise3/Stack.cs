namespace PracticeExercise3;

public class Stack<T> : IStack<T>
{
    private LinkedList<T> linkedList = new LinkedList<T>();

    /// <summary>
    /// True if the stack contains no items; otherwise false.
    /// </summary>
    public bool IsEmpty => linkedList.Count == 0;

    /// <summary>
    /// The number of items currently in the stack.
    /// </summary>
    public int Count => linkedList.Count;

    /// <summary>
    /// Returns the item on top of the stack without removing it.
    /// </summary>
    /// <returns>The most recently pushed item.</returns>
    /// <exception cref="EmptyStackException">Thrown if the stack is empty.</exception>
    public T Peek()
    {
        if(IsEmpty)
        {
            throw new EmptyStackException();
        }
        return linkedList.First!.Value;
    }

    /// <summary>
    /// Removes and returns the item on top of the stack.
    /// </summary>
    /// <returns>The most recently pushed item.</returns>
    /// <exception cref="EmptyStackException">Thrown if the stack is empty.</exception>
    public T Pop()
    {
        if(IsEmpty)
        {
            throw new EmptyStackException();
        }
        T topOfStack = linkedList.First!.Value;

        linkedList.RemoveFirst();

        return topOfStack;
    }

    /// <summary>
    /// Adds an item to the top of the stack.
    /// </summary>
    /// <param name="item">The item to add.</param>
    public void Push(T item)
    {
        linkedList.AddFirst(item);
    }

    /// <summary>
    /// Removes all items from the stack. Clearing an empty stack does nothing.
    /// </summary>
    public void Clear()
    {
        linkedList.Clear();
    }

    /// <summary>
    /// Returns the items from top to bottom, one per line, with each item
    /// followed by a newline (e.g. "3\n2\n1\n"). An empty stack returns "".
    /// </summary>
    public override string ToString()
    {
        string result = "";

        var currentNode = linkedList.First;

        while (currentNode != null)
        {
            result += currentNode.Value + "\n";
            currentNode = currentNode.Next;
        }

        return result;
    }
}
