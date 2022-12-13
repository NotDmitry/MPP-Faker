using Faker.Core.Interface;
using Faker.Core.Other;
using System.Text;

namespace Faker.Core.TypeGenerators;

public class StringGenerator : IValueGenerator
{
    // Pangram which contains all basic alphabet, numbers and symbols
    private readonly string _perfectPangram = "Th;1e* q.ui2ck( bro) -3w>n4 +f5ox _6 =jumps7 o<ve,8r ?9a :l0azy 5dog " +
    "B]OT6H& 7FI0^ CKLE% 8DW[A91 $RVES2} #JINX @MY3{ !PIG Q4UIZ ";
    
    // Check if string generation available
    public bool CanGenerate(Type type) => type == typeof(string);
    
    // Generate random string
    public object Generate(Type typeToGenerate, GeneratorContext context)
    {
        int length = context.Random.Next(10, 51);
        StringBuilder builder = new();

        for (int i = 0; i < length; i++)
            builder.Append(_perfectPangram[context.Random.Next(0, _perfectPangram.Length)]);
        
        return builder.ToString();
    }
}
