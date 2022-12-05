using Faker.Core.Interface;
using Faker.Core.Other;

namespace Faker.Core.TypeGenerators;

public class ByteGenerator : IValueGenerator
{
    public bool CanGenerate(Type type) => type == typeof(byte);

    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return (byte)context.Random.Next(byte.MinValue, byte.MaxValue);
    }
}
