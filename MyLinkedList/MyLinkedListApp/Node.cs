namespace MyLinkedListApp;

public class Node
{
    #region Properties

    public Node Prev { get; set; }
    public Node Next { get; set; }
    public Book Data { get; }

    #endregion

    #region Constructors & ToString

    public Node(Book data)
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
