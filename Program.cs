using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the first Employee object and set its property values
        Employee employee1 = new Employee
        {
            Id = 1001,
            FirstName = "Alice",
            LastName = "Johnson"
        };

        // Create the second Employee object with the same Id but different name
        Employee employee2 = new Employee
        {
            Id = 1001,
            FirstName = "Bob",
            LastName = "Smith"
        };

        // Compare employee1 and employee2 using the overloaded == operator
        if (employee1 == employee2)
        {
            // This block runs if both employees have the same Id
            Console.WriteLine("Employee1 and Employee2 are equal (same Id).");
        }
        else
        {
            // This block runs if they have different Ids
            Console.WriteLine("Employee1 and Employee2 are NOT equal (different Ids).");
        }

        // Also compare them using the overloaded != operator
        if (employee1 != employee2)
        {
            // If they are not equal, this block runs
            Console.WriteLine("Employee1 and Employee2 are NOT equal (checked using !=).");
        }
        else
        {
            // If they are equal, this block runs
            Console.WriteLine("Employee1 and Employee2 are equal (checked using !=).");
        }
    }
}
