using Faker.Core.Interface;
using Faker.Core.Other;

namespace Faker.Core.TypeGenerators;

public class DecimalGenerator : IValueGenerator
{
    public bool CanGenerate(Type type) => type == typeof(decimal);

    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return context.Random.Next(int.MinValue, int.MaxValue);
    }
}
