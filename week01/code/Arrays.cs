public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Create a new double array with the size provided by length.
        // Step 2: Use a loop to go through each position of the array.
        // Step 3: For each position, calculate the multiple of the number.
        //         Since arrays start at index 0, use (i + 1) to get the correct multiple.
        // Step 4: Store each calculated multiple inside the array.
        // Step 5: Return the completed array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;

    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Determine how many items are in the list.
        // Step 2: Identify the last "amount" items in the list.
        //         These are the items that need to move to the front.
        // Step 3: Store those last items in a temporary list.
        // Step 4: Remove those last items from their original position.
        // Step 5: Insert the temporary list at the beginning of the original list.
        // Step 6: Since List is dynamic, modify the existing list directly.

        int count = data.Count;

        List<int> itemsToMove = data.GetRange(count - amount, amount);

        data.RemoveRange(count - amount, amount);

        data.InsertRange(0, itemsToMove);
    }
}
