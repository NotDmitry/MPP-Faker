using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Tests;

public class CycleB
{
    bool isHappy;
    CycleC NextC { get; set; }

}
