namespace Faker.Core.Interface;

// Provide basic Faker functionality for use in different places
public interface IFaker
{
    T Create<T>();

    object Create(Type t);

}
