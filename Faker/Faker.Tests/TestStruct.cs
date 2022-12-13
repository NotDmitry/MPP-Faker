namespace Faker.Tests;

struct TestStruct
{
    public char Id { get; set; }
    public string? Name { get; set; }
    public string? Value{ get; set; }

    public TestStruct(char id, string name)
    {
        Id = id;
        Name = name;
        Value = null;
    }

    public TestStruct(char id, string name, string value)
    {
        Id = id; 
        Name = name; 
        Value = value;
    }

    public TestStruct(char id)
    {
        Id= id;
        Name = null;
        Value = null;
    }

}
