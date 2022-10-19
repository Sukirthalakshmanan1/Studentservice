using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentservice.Test
{
    [TestFixture]
   public class Test1
    {
        int s;
        [SetUp]
        public void Add()
        {
          int i = 10;
        int j = 20;
        s=i+j;
            Console.WriteLine(s);
}
    [Test]
    public void subtract()
    {
        int p = s - 10;
            Console.WriteLine(p);
        Assert.AreEqual(p, 20);
    }
    [Test]
    [TearDown]

public void Multiply()
    {
        int x = 100;
        int y = 20;
        int result = x * y;
            Console.WriteLine(result);
        Assert.AreEqual(result, 2000);
    }
      
} 

}
