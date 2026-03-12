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

    public string InOrder() // Returns all values as a space-separated string in ascending order.
    {
        if (Root != null)
        {
            return InOrderRecursively(Root);
        }
        else
        {
            return string.Empty;
        }
    }

    private string InOrderRecursively(Node Current)
    {
        string result = string.Empty;
        if (Current.Left != null)
        {
            result += InOrderRecursively(Current.Left) + " ";
        }
        result += Current.Value.ToString();
        if (Current.Right != null)
        {
            result += " " + InOrderRecursively(Current.Right);
        }
        return result;
    }

    public int Height() // Returns the height of the tree (−1 for an empty tree).
    {
        if (this.Root != null)
        {
            return HeightRecursively(Root);
        }
        else
        {
            return -1;
        }
    }

    public int HeightRecursively(Node Current)
    {
        if (Current.Left != null)
        {
            return HeightRecursively(Current.Left) + 1;
        }
        else
        {
            return 1;
        }
    }

    public string ToMermaid() //Returns a Mermaid graph TD definition string representing the tree structure (see format below).
    {
        if (this.Root == null)
        {
            return "graph TD\n empty[\"(empty tree)\"]";
        }
        return null;
    }
}