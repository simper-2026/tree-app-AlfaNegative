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
        int links = 0;
        if (this.Root == null)
        {
            return "graph TD\n empty[\"(empty tree)\"]";
        }
        else
        {
            return $"graph TD; \n {ToMermaidRecursively(Root, ref links)}";
        }
    }

    private string ToMermaidRecursively(Node Current, ref int links)
    {
        string result = string.Empty;
        if (Current.Left != null)
        {
            result += $"{Current.Value} --> {Current.Left.Value} \n"; //result += $"{Current.Value} --> {Current.Left.Value}[{Current.Left.Value} h:{{Current.Left.Height} d:{{Current.Left.Depth}}] \n";
            links++;
            result += ToMermaidRecursively(Current.Left, ref links);
        }
        else 
        {
            result += $"{Current.Value} --> _phr{Current.Value}[ ] \n";
            result += $"linkStyle {links} stroke:none,stroke-width:0,fill:none \n";
            result += $"style _phr{Current.Value} fill:none,stroke:none,color:none \n";
            links++;
        }
        if (Current.Right != null)
        {
            result += $"{Current.Value} --> {Current.Right.Value} \n";
            links++;
            result += ToMermaidRecursively(Current.Right, ref links);
        }
        else
        {
            result += $"{Current.Value} --> _phr{Current.Value}[ ] \n";
            result += $"linkStyle {links} stroke:none,stroke-width:0,fill:none \n";
            result += $"style _phr{Current.Value} fill:none,stroke:none,color:none \n";
            links++;
        }
        return result;
    }
}
