namespace TreeApp.Test;

public class UnitTest1
{
    [Fact]
    public void HeightTest()
    {
        BinaryTree mainTree = new BinaryTree();

        mainTree.Insert(4);
        mainTree.Insert(5);
        mainTree.Insert(2);
        mainTree.Insert(3);
        mainTree.Insert(6);

        Assert.Equal(2, mainTree.Height());
    }

    [Fact]
    public void InOrderTest()
    {
        BinaryTree mainTree = new BinaryTree();

        mainTree.Insert(4);
        mainTree.Insert(5);
        mainTree.Insert(2);
        mainTree.Insert(3);
        mainTree.Insert(6);

        Assert.Equal("2 3 4 5 6", mainTree.InOrder());
    }
}
