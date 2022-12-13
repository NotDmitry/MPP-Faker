using Faker.Core.Interface;
using Faker.Core.Other;

namespace Faker.Core.TypeGenerators;

public class ByteGenerator : IValueGenerator
{
    // Check if byte generation available
    public bool CanGenerate(Type type) => type == typeof(byte);

    // Generate random byte
    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return (byte)context.Random.Next(byte.MinValue, byte.MaxValue);
    }
}
