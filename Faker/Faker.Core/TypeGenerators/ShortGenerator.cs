using Faker.Core.Interface;
using Faker.Core.Other;

namespace Faker.Core.TypeGenerators;

public class ShortGenerator : IValueGenerator
{
    // Check if short generation available
    public bool CanGenerate(Type type) => type == typeof(short);

    // Generate random short
    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return (short)context.Random.Next(short.MinValue, short.MaxValue);
    }
}
