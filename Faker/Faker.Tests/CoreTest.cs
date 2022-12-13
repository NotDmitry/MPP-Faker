using System.Diagnostics.Metrics;
using System.Drawing;
using Faker.Core.TypeGenerators;

namespace Faker.Tests
{
    [TestClass]
    public class CoreTest
    {
        [TestMethod]
        public void Test_Bool_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            bool[] foo = new bool[20];
            int count = 0;

            // Act
            for (int i = 0; i < foo.Length; i++)
            {
                foo[i] = faker.Create<bool>();
                if (foo[i]) 
                {
                    count++;
                }
            }

            //Assert
            Assert.AreNotEqual(0, count);
        }

        [TestMethod]
        public void Test_Byte_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            byte[] foo = new byte[10];
            int count = 0;

            // Act
            for (int i = 0; i < foo.Length; i++)
            {
                foo[i] = faker.Create<byte>();
                if (foo[i] != (byte)ObjectGenerator.GetDefaultValue(foo[i].GetType()))
                {
                    count++;
                }
            }

            //Assert
            Assert.AreNotEqual(0, count);
        }

        [TestMethod]
        public void Test_Char_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            char[] foo = new char[15];
            int count = 0;

            // Act
            for (int i = 0; i < foo.Length; i++)
            {
                foo[i] = faker.Create<char>();
                if (foo[i] != (char)ObjectGenerator.GetDefaultValue(foo[i].GetType()))
                {
                    count++;
                }
            }

            // Assert
            Assert.AreNotEqual(0, count);
        }

        [TestMethod]
        public void Test_Decimal_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            decimal[] foo = new decimal[5];
            int count = 0;

            // Act
            for (int i = 0; i < foo.Length; i++)
            {
                foo[i] = faker.Create<decimal>();
                if (foo[i] != (decimal)ObjectGenerator.GetDefaultValue(foo[i].GetType()))
                {
                    count++;
                }
            }

            // Assert
            Assert.AreNotEqual(0, count);
        }

        [TestMethod]
        public void Test_Double_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            double[] foo = new double[10];
            int count = 0;

            // Act
            for (int i = 0; i < foo.Length; i++)
            {
                foo[i] = faker.Create<double>();
                if (Math.Abs(foo[i] - (double)ObjectGenerator.GetDefaultValue(foo[i].GetType())) > 0.01 )
                {
                    count++;
                }
            }

            // Assert
            Assert.AreNotEqual(0, count);
        }

        public void Test_Float_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            float[] foo = new float[10];
            int count = 0;

            // Act
            for (int i = 0; i < foo.Length; i++)
            {
                foo[i] = faker.Create<float>();
                if (Math.Abs(foo[i] - (float)ObjectGenerator.GetDefaultValue(foo[i].GetType())) > 0.01)
                {
                    count++;
                }
            }

            // Assert
            Assert.AreNotEqual(0, count);
        }

        [TestMethod]
        public void Test_Int_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            int[] foo = new int[10];
            int count = 0;

            // Act
            for (int i = 0; i < foo.Length; i++)
            {
                foo[i] = faker.Create<int>();
                if (foo[i] != (int)ObjectGenerator.GetDefaultValue(foo[i].GetType()))
                {
                    count++;
                }
            }

            // Assert
            Assert.AreNotEqual(0, count);
        }

        [TestMethod]
        public void Test_Long_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            long[] foo = new long[10];
            int count = 0;

            // Act
            for (int i = 0; i < foo.Length; i++)
            {
                foo[i] = faker.Create<long>();
                if (foo[i] != (long)ObjectGenerator.GetDefaultValue(foo[i].GetType()))
                {
                    count++;
                }
            }

            // Assert
            Assert.AreNotEqual(0, count);
        }

        [TestMethod]
        public void Test_Short_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            short[] foo = new short[10];
            int count = 0;

            // Act
            for (int i = 0; i < foo.Length; i++)
            {
                foo[i] = faker.Create<short>();
                if (foo[i] != (short)ObjectGenerator.GetDefaultValue(foo[i].GetType()))
                {
                    count++;
                }
            }

            // Assert
            Assert.AreNotEqual(0, count);
        }

        [TestMethod]
        public void Test_String_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            string foo;

            // Act
            foo = faker.Create<string>();

            // Assert
            Assert.AreNotEqual(ObjectGenerator.GetDefaultValue(foo.GetType()), foo);
        }

        [TestMethod]
        public void Test_Point_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            Point[] foo = new Point[6];
            int count = 0;

            // Act
            for (int i = 0; i < foo.Length; i++)
            {
                foo[i] = faker.Create<Point>();
                if (foo[i].X != (int)ObjectGenerator.GetDefaultValue(foo[i].X.GetType()) &&
                    foo[i].Y != (int)ObjectGenerator.GetDefaultValue(foo[i].Y.GetType()))
                {
                    count++;
                }
            }

            // Assert
            Assert.AreNotEqual(0, count);
        }

        [TestMethod]
        public void Test_List_Int_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            List<int> foo = faker.Create<List<int>>();
            int count = 0;

            // Act
            foreach (int item in foo)
            {
                if (item != (int)ObjectGenerator.GetDefaultValue(item.GetType()))
                {
                    count++;
                }
            }

            // Assert
            Assert.AreNotEqual(0, count);
            Assert.AreNotEqual(ObjectGenerator.GetDefaultValue(foo.GetType()), foo);
        }

        [TestMethod]
        public void Test_ComplexObject_Properties_Generation_Count()
        {
            // Arrange
            var faker = new Core.Faker();
            A foo = faker.Create<A>();
            int count = 0;

            // Act
            var properties = foo.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.GetValue(foo) == ObjectGenerator.GetDefaultValue(property.PropertyType))
                {
                    count++;
                }
            }

            // Assert
            Assert.AreEqual(3, properties.Length);
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void Test_ComplexObject_List_Field_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            B foo = faker.Create<B>();
            int count = 0;

            // Act
            foreach (var symbol in foo.list)
            {
                if (symbol != (char)ObjectGenerator.GetDefaultValue(foo.list.First().GetType()))
                {
                    count++;
                }
            }

            // Assert
            Assert.AreNotEqual(0, count);
        }

        [TestMethod]
        public void Test_CycleClass_Generation_NoExeption()
        {
            // Arrange
            var faker = new Core.Faker();
            CycleA foo;
           
            try
            {
                // Act
                foo = faker.Create<CycleA>();
            }
            catch (Exception ex)
            {
                // Assert
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void Test_Struct_SeveralCtors()
        {
            // Arrange
            var faker = new Core.Faker();
            TestStruct foo;
            int count = 0;
            foo = faker.Create<TestStruct>();

            // Act
            var properties = foo.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.GetValue(foo) == ObjectGenerator.GetDefaultValue(property.PropertyType))
                {
                    count++;
                }
            }

            // Assert
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void Test_List_Of_ComplexObject_Generation()
        {
            // Arrange
            var faker = new Core.Faker();
            List<A> foo = faker.Create<List<A>>();
            int count = 0;

            // Act
            foreach (var obj in foo)
            {
                if (obj != ObjectGenerator.GetDefaultValue(foo.First().GetType()))
                {
                    count++;
                }
            }

            // Assert
            Assert.AreNotEqual(0, count);
        }
    }


}