using Faker.Core.Interface;
using Faker.Core.Other;

namespace Faker.Core.TypeGenerators;

public class ShortGenerator : IValueGenerator
{
    public bool CanGenerate(Type type) => type == typeof(short);

    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return context.Random.Next(short.MinValue, short.MaxValue);
    }
}
