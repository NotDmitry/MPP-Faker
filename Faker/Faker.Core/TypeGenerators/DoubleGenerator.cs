using Faker.Core.Interface;
using Faker.Core.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Core.TypeGenerators;

public class DoubleGenerator : IValueGenerator
{
    private readonly double _max = 100.0;

    private readonly double _min = 0.0;

    public bool CanGenerate(Type type) => type == typeof(double);

    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        return context.Random.NextDouble() * (_max - _min) + _min;
    }
}
