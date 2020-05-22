namespace Person
{
    public  class Persons
{
     string FirstName; 
    string LastName; 
    public Persons(string firstName, string lastName) 
      => (FirstName, LastName) = (firstName, lastName);
    public void Deconstruct(out string firstName, out string lastName) 
      => (firstName, lastName) = (FirstName, LastName);
    /* private readonly string firstName;
    private readonly string lastName; */
    
    /* public string FirstName 
    { 
        get => firstName; 
        init => firstName = (value ?? throw new ArgumentNullException(nameof(FirstName)));
    }
    public string LastName 
    { 
        get => lastName; 
        init => lastName = (value ?? throw new ArgumentNullException(nameof(LastName)));
    } */
}
}