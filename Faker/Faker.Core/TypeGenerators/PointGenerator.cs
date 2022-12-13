using Faker.Core.Interface;
using Faker.Core.Other;
using System.Drawing;

namespace Faker.Core.TypeGenerators;

public class PointGenerator : IValueGenerator
{
    // Check if Point generation available
    public bool CanGenerate(Type type) => type == typeof(Point);

    // Generate random Point (x - lower 16 bits, y - higher)
    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return new Point(context.Random.Next(int.MinValue, int.MaxValue));
    }
}
