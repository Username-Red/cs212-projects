public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        //Set up some variables to use for list navigation
        var result = new int[select.Length];
        var l1Idx = 0;
        var l2Idx = 0;

        //open a for loop to loop through the select list
        for (var i = 0; i < select.Length; i++)
        {
            //if the select list item is equal to 1, use list1 to add to result
            if (select[i] == 1) {
                result[i] = list1[l1Idx++];
            }
                
            //if the select list item is equal to 2, use list2 to add to the result
            else if (select[i] == 2) {
                result[i] = list2[l2Idx++];
            }

            //if there is something wrong with the select list, throw an error to the screen explaining the problem
            else{
                Console.WriteLine("An error has occured with the selector list. Please ensure that the selector list only contains 1s and 2s.");
            }
                
        }

        //return the final result
        return result;
    }
}