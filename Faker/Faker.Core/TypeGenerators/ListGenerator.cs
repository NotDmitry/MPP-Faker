﻿using Faker.Core.Interface;
using Faker.Core.Other;
using System.Collections;

namespace Faker.Core.TypeGenerators;

public class ListGenerator : IValueGenerator
{
    public bool CanGenerate(Type type) => type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>);

    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        int length = context.Random.Next(2, 9);
        Type argumentType = typeToGenerate.GetGenericArguments().First();
        var list = Activator.CreateInstance(typeToGenerate) as IList;
        
        if (list is not null)
            for (int i = 0; i < length; i++)
                list.Add(context.Faker.Create(argumentType));

        return list;
    }
}
