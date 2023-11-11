/// <summary>
/// This queue is circular.  When people are added via add_person, then they are added to the 
/// back of the queue (per FIFO rules).  When get_next_person is called, the next person
/// in the queue is displayed and then they are placed back into the back of the queue.  Thus,
/// each person stays in the queue and is given turns.  When a person is added to the queue, 
/// a turns parameter is provided to identify how many turns they will be given.  If the turns is 0 or
/// less than they will stay in the queue forever.  If a person is out of turns then they will 
/// not be added back into the queue.
/// </summary>
public class TakingTurnsQueue {
    private readonly PersonQueue _people = new();

    public int Length => _people.Length;

    /// <summary>
    /// Add new people to the queue with a name and number of turns
    /// </summary>
    /// <param name="name">Name of the person</param>
    /// <param name="turns">Number of turns remaining</param>
    public void AddPerson(string name, int turns) {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    /// <summary>
    /// Get the next person in the queue and display them.  The person should
    /// go to the back of the queue again unless the turns variable shows that they 
    /// have no more turns left.  Note that a turns value of 0 or less means the 
    /// person has an infinite number of turns.  An error message is displayed 
    /// if the queue is empty.
    /// </summary>
    public void GetNextPerson() {
        // If there is nobody in the que, display the error message
        if (_people.IsEmpty())
            Console.WriteLine("No one in the queue.");

        // if there IS someone in the que
        else {
            //Take the person out of the que
            Person person = _people.Dequeue();
            // Check the person's number of turns. 
            if (person.Turns > 1) {
                // If greater than 1, remove one turn from their turn count 
                // and put them back at the end of the queue
                person.Turns -= 1;
                _people.Enqueue(person);
            }

            // Solution test 1
            else if (person.Turns <= 0) {
                _people.Enqueue(person);
            }

            Console.WriteLine($"{person.Name}, {person.Turns}");
        }
    }

    // public void IterateTurns() {
    //     foreach(Person person in _people)
    // }

    public override string ToString() {
        return _people.ToString();
    }
}