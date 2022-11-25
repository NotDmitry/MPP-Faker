using Faker.Core.Other;

namespace Faker.Core.Interface;

// Basic interface for Reflection replacement
public interface IValueGenerator
{
    object Generate(Type typeToGenerate, GeneratorContext context);

    bool CanGenerate(Type type);
}
