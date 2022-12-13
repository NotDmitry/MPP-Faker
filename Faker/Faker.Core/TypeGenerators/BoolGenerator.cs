using Faker.Core.Interface;
using Faker.Core.Other;

namespace Faker.Core.TypeGenerators;

public class BoolGenerator : IValueGenerator
{
    // Check if bool generation available
    public bool CanGenerate(Type type) => type == typeof(bool);

    // Generate random bool
    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return context.Random.Next(2) == 1;
    }
}
