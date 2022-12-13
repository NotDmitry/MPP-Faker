using Faker.Core.Interface;
using Faker.Core.Other;
using Faker.Core.TypeGenerators;

namespace Faker.Core;

public class Faker : IFaker
{
    private readonly List<IValueGenerator> _valueGenerators;
    private readonly GeneratorContext _context;

    Faker()
    {
        _valueGenerators = new List<IValueGenerator> {new BoolGenerator(), new ByteGenerator(),
            new CharGenerator(), new DecimalGenerator(), new DoubleGenerator(), new FloatGenerator(),
            new IntGenerator(), new ListGenerator(), new LongGenerator(), new PointGenerator(),
            new ShortGenerator(), new StringGenerator()};
        _context = new GeneratorContext(new Random(), this);
    }

    public T Create<T>() => (T)Create(typeof(T));

    public object Create(Type t)
    {
        
    }
}
