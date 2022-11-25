using Faker.Core.Interface;

namespace Faker.Core.Other;

public class GeneratorContext
{
    // For saving random generator state
    // and getting different values for each call
    public Random Random { get; }

    // Provide access to Faker methods
    public IFaker Faker { get; }

    public GeneratorContext(Random random, IFaker faker)
    {
        Random = random;
        Faker = faker;
    }
}
