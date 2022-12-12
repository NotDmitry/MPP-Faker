using Faker.Core.Interface;
using Faker.Core.Other;
using System.Drawing;

namespace Faker.Core.TypeGenerators;

public class PointGenerator : IValueGenerator
{
    public bool CanGenerate(Type type) => type == typeof(Point);

    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return new Point(context.Random.Next(int.MinValue, int.MaxValue));
    }
}
