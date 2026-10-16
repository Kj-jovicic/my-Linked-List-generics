namespace MyLinkedListApp;

public class Node<T>
{
    #region Properties

    public Node<T> Prev { get; set; }
    public Node<T> Next { get; set; }
    public T Data { get; }

    #endregion

    #region Constructors & ToString

    public Node(T data)
    {
        if (data == null)
        {
            throw new ArgumentNullException(nameof(data), "Invalid Parameter");
        }
        Data = data;
    }

    public override string ToString()
    {
        return Data.ToString();
    }
    #endregion
}
