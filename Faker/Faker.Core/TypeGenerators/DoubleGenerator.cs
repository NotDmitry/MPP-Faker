using Faker.Core.Interface;
using Faker.Core.Other;

namespace Faker.Core.TypeGenerators;

public class DoubleGenerator : IValueGenerator
{
    private readonly double _max = 100.0;

    private readonly double _min = 0.0;

    // Check if double generation available
    public bool CanGenerate(Type type) => type == typeof(double);

    // Generate random double
    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return context.Random.NextDouble() * (_max - _min) + _min;
    }
}
