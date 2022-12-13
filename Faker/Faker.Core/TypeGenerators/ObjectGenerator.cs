using Faker.Core.Interface;
using Faker.Core.Other;
using System.Reflection;

namespace Faker.Core.TypeGenerators;

public class ObjectGenerator : IValueGenerator
{
    public bool CanGenerate(Type type) => !type.IsEnum;

    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        object? target = InvokeCtors(typeToGenerate, context);
        target = InitFields(target, typeToGenerate, context) ?? null;
        return target;
    }

    public object InvokeCtors(Type typeToGenerate, GeneratorContext context)
    {
        var constructors = typeToGenerate.GetConstructors()
            .OrderByDescending(ctor => ctor.GetParameters().Length).ToList();

        foreach (var ctor in constructors)
        {
            try
            {
                return ctor.Invoke(ctor.GetParameters()
                    .Select(c => context.Faker.Create(c.ParameterType)).ToArray());
            }
            catch
            {
            }
        }

        var initializer = Activator.CreateInstance(typeToGenerate);
        if (initializer is null)
        {
            throw new Exception($"Can't initialize object of {typeToGenerate} type\n");
        }
        return initializer;
    }

    public object InitFields(object target, Type type, GeneratorContext context)
    {
        var properties = type.GetProperties(BindingFlags.Public| BindingFlags.Instance)
            .Where(p => p.GetSetMethod() is not null);
        foreach (var property in properties)
        {
            try
            {
                if (Equals(property.GetValue(target), GetDefaultValue(property.PropertyType)))
                    property.SetValue(target, context.Faker.Create(property.PropertyType));
            }
            catch
            {
            }
        }

        var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
        foreach (var field in fields)
        {
            try
            {
                if (Equals(field.GetValue(target), GetDefaultValue(field.FieldType)))
                    field.SetValue(target, context.Faker.Create(field.FieldType));
            }
            catch
            {
            }
        }
        
        return target;
    }

    private static object? GetDefaultValue(Type t)
    {
        if (t.IsValueType)
            return Activator.CreateInstance(t);
        else
            return null;
    }
}
