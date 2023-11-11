/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: adding three items to the list with priority values of 1, 2 and, 3
        // Expected Result: remove the item with the priority of 3
        Console.WriteLine("Test 1");
        Console.WriteLine(priorityQueue);
        priorityQueue.Enqueue("some guy", 1);
        priorityQueue.Enqueue("some dude", 2);
        priorityQueue.Enqueue("some girl", 3);

        Console.WriteLine($"{priorityQueue.Dequeue()} has been removed from the list.");
        Console.WriteLine(priorityQueue);
        // priorityQueue.Dequeue();
        // priorityQueue.Dequeue();





        // Defect(s) Found: Nothing was being removed from the list, but it is now solved

        Console.WriteLine("---------");

        // Test 2
        // Scenario: adding three items to the list with priority values of 1, 3 and, 3
        // Expected Result: the item in the list with the highest priority value 
        // and that appears before any other mathing priority value will be removed
        Console.WriteLine("Test 2");
        Console.WriteLine(priorityQueue);

        priorityQueue.Enqueue("not this one", 1);
        priorityQueue.Enqueue("THIS ONE", 3);
        priorityQueue.Enqueue("not this one", 3);

        Console.WriteLine($"{priorityQueue.Dequeue()} has been removed from the list.");
        Console.WriteLine(priorityQueue);


        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}