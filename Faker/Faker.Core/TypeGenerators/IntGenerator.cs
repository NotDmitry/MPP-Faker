using Faker.Core.Interface;
using Faker.Core.Other;

namespace Faker.Core.TypeGenerators;

public class IntGenerator : IValueGenerator
{
    // Check if int generation available
    public bool CanGenerate(Type type) => type == typeof(int);

    // Generate random int
    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return context.Random.Next(int.MinValue, int.MaxValue);
    }
}
