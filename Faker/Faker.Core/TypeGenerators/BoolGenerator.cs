using Faker.Core.Interface;
using Faker.Core.Other;

namespace Faker.Core.TypeGenerators;

public class BoolGenerator : IValueGenerator
{
    public bool CanGenerate(Type type) => type == typeof(bool);

    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return context.Random.Next(2) == 1;
    }
}
