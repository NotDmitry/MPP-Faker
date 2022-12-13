using Faker.Core.Interface;
using Faker.Core.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Core.TypeGenerators;

public class CharGenerator : IValueGenerator
{
    private readonly string _perfectPangram = "Th;1e* q.ui2ck( bro) -3w>n4 +f5ox _6 =jumps7 o<ve,8r ?9a :l0azy 5dog " +
        "B]OT6H& 7FI0^ CKLE% 8DW[A91 $RVES2} #JINX @MY3{ !PIG Q4UIZ ";

    // Check if char generation available
    public bool CanGenerate(Type type) => type == typeof(char);

    // Generate random char
    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        int position = context.Random.Next(0, _perfectPangram.Length);
        return _perfectPangram[position];
    }
}
