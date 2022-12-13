using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Tests;

public class CycleA
{
    public string hello;
    public CycleB NextB { get; set; }
}
