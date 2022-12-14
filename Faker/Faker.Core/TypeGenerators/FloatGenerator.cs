using Faker.Core.Interface;
using Faker.Core.Other;

namespace Faker.Core.TypeGenerators;

public class FloatGenerator : IValueGenerator
{
    private readonly double _max = 100.0;

    private readonly double _min = 0.0;

    // Check if float generation available
    public bool CanGenerate(Type type) => type == typeof(float);

    // Generate random float
    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return (float)(context.Random.NextDouble() * (_max - _min) + _min);
    }
}
