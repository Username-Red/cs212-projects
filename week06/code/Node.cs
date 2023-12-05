public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }

        else if (value == Data) {

        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (Data == value) {
            return true;
        }

        else if (value < Data && Left != null) {
            return Left.Contains(value);
        }

        else if (value > Data && Right != null) {
            return Right.Contains(value);
        }
        
        return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4

        if (Left is not null && Right is not null)
        {
            // int leftSubtreeHeight = Left.GetHeight();
            // int rightSubtreeHeight = Right.GetHeight();

            // Return the height of the subtree rooted at this node
            // var height = 1 + Math.Max(leftSubtreeHeight, rightSubtreeHeight);
            // return height;
        }


        int leftSubtreeHeight = 0;
        int rightSubtreeHeight = 0;
        if (Left is not null) {
            leftSubtreeHeight = Left.GetHeight();
        }

        if (Right is not null) {
            rightSubtreeHeight = Right.GetHeight();
        }

        var height = 1 + Math.Max(leftSubtreeHeight, rightSubtreeHeight);
        return height;

        // Replace this line with the correct return statement(s)
    }
}