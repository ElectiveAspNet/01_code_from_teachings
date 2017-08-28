class Person
{
    // Java metoden
    private string name;
    public Person(string name)
    {
        this.name = name;
    }

    // Getters og Setters - 
    // Properties - (prop)
    public string Name { get; set; }
    public int Age { get; set; }

    public string getName(){
        return this.name;
    }
    


}