class Node<T> where T : struct
{
    private char value;
    private Node<T> next = null;

    public Node(char value)
    {
        this.SetValue(value);
    }

    public void SetNext(Node<T> next)
    {
        this.next = next;
    }

    public Node<T> Next()
    {
        return this.next;
    }

    public char GetValue()
    {
        return this.value;
    }

    public void SetValue(char value)
    {
        this.value = value;
    }
}