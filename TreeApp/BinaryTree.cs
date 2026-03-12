public class BinaryTree
{
    public Node? Root { get; private set; }

    public BinaryTree()
    {
        Root = null;
    }

    public void Insert(int value)
    {
        if (Root == null)
        {
            Root = new Node(value);
        }
        else
        {
            InsertRecursively(Root, value);
        }
    }

    private void InsertRecursively(Node Current, int value)
    {
        if (value > Current.Value)
        {
            if (Current.Right == null)
            {
                Current.Right = new Node(value);
            }
            else
            {
                InsertRecursively(Current.Right, value);
            }
        }
        else if (value < Current.Value)
        {
            if (Current.Left == null)
            {
                Current.Left = new Node(value);
            }
            else
            {
                InsertRecursively(Current.Left, value);
            }
        }
    }

    public string InOrder()
    {
        
    }

    private string InOrderRecursively()
    {
        
    }

    public int Height()
    {
        
    }

    public int HeightRecursively()
    {
        
    }

    public string ToMermaid()
    {
        if (this.Root == null)
        {
            return "graph TD\n empty[\"(empty tree)\"]";
        }
    }
}