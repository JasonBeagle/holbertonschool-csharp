public enum Rating
{
    Good,
    Great,
    Excellent
}

public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string _name, float _age, string _owner, Rating _rating)
    {
        this.name = _name;
        this.age = _age;
        this.owner = _owner;
        this.rating = _rating;
    }

    public override string ToString()
    {
        return $"Name: {name}, Age: {age}, Owner: {owner}, Rating: {rating}";
    }
}
