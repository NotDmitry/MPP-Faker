using Faker.Core.Interface;
using Faker.Core.Other;
using Faker.Core.TypeGenerators;

namespace Faker.Core;

public class Faker : IFaker
{
    private readonly List<IValueGenerator> _valueGenerators;
    private readonly GeneratorContext _context;
    private readonly NestedClassGuard _classGuard;

    Faker()
    {
        _valueGenerators = new List<IValueGenerator> {new BoolGenerator(), new ByteGenerator(),
            new CharGenerator(), new DecimalGenerator(), new DoubleGenerator(), new FloatGenerator(),
            new IntGenerator(), new ListGenerator(), new LongGenerator(), new PointGenerator(),
            new ShortGenerator(), new StringGenerator()};
        _context = new GeneratorContext(new Random(), this);
        _classGuard = new NestedClassGuard(4);
    }

    public T Create<T>() => (T)Create(typeof(T));

    public object Create(Type t)
    {
        _classGuard.ChangeOccurance(t, NestedClassGuard.Operation.Add);
        if (_classGuard.IsStuck(t))
            return null;

        var valueGenerator = _valueGenerators.FirstOrDefault(g => g.CanGenerate(t), new ObjectGenerator());

        _classGuard.ChangeOccurance(t, NestedClassGuard.Operation.Delete);

        return valueGenerator.Generate(t, _context);
        
    }
}
