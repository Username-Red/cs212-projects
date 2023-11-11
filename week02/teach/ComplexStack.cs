/*
 * CSE212 
 * (c) BYU-Idaho
 * 03-Teach - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */

public static class ComplexStack {
    public static bool DoSomethingComplicated(string line) {

        // Creating a new stack
        var stack = new Stack<char>();

        // Loop through each character in 'line'
        foreach (var item in line) {

            // If the character is an opening bracket, push it to the stack
            if (item is '(' or '[' or '{') {
                stack.Push(item);
            }

            // If there is no matching bracket, or the stack count is 0, return false
            else if (item is ')') {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        // Return a true boolean value if there are no mismatched brackets
        return stack.Count == 0;
    }
}