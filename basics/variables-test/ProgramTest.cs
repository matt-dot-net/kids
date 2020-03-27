using System;
using Xunit;
using variables;

namespace variables_test
{
    public class ProgramTest
    {
        [Fact]
        public void A_Plus_B_Equals_C()
        {
            var result = Program.A_Plus_B(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void A_Plus_B_Equas_C_2()
        {
            var result = Program.A_Plus_B(1, 1);
            Assert.Equal(2,result);
        }
    }
}
