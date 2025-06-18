using System;

// Define a class named Employee
public class Employee
{
    // Property to store the employee's unique identifier
    public int Id { get; set; }

    // Property to store the employee's first name
    public string FirstName { get; set; }

    // Property to store the employee's last name
    public string LastName { get; set; }

    // Overload the == operator to compare two Employee objects based on their Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // If both are null, return true
        if (ReferenceEquals(emp1, emp2))
            return true;

        // If one is null, return false
        if (emp1 is null || emp2 is null)
            return false;

        // Return true if their Ids are equal
        return emp1.Id == emp2.Id;
    }

    // Overload the != operator as a required pair for ==
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Return the opposite of the == operator result
        return !(emp1 == emp2);
    }

    // Override Equals method to be consistent with the == operator
    public override bool Equals(object obj)
    {
        // Use the overloaded == operator for comparison
        if (obj is Employee other)
            return this == other;

        return false;
    }

    // Override GetHashCode to ensure consistency with Equals
    public override int GetHashCode()
    {
        // Return hash code based on Id
        return Id.GetHashCode();
    }
}

