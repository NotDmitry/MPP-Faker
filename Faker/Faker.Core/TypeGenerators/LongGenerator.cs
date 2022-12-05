using Faker.Core.Interface;
using Faker.Core.Other;

namespace Faker.Core.TypeGenerators;

public class LongGenerator : IValueGenerator
{
    public bool CanGenerate(Type type) => type == typeof(long);

    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return context.Random.NextInt64(long.MinValue, long.MaxValue);
    }
}
