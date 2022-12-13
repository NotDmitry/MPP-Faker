using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Tests; 

public class CycleC 
{ 
    public char firstLetter { get; set; }
    public char secondLetter { get; set; }
    CycleA NextA { get; set; }
}
