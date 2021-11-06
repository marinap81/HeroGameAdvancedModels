using System;
using System.Collections.Generic;
using Xunit;
using HeroGameAdvancedLib;


namespace HeroGameAdvancedTests
{
   /* public class VillainTests
    {
        
        public VillainTests(){}
        // applies amount of damage to Hitpoints.
        // if damage is greater that Hitpoints, Hitpoints should be set to 0 (zero)

        [Theory]
        [InlineData(10,10,0)]
        [InlineData(10,12,2)]
        [InlineData(0,0,0)]
        [InlineData(5,-2,0)]
        [InlineData(5,1,0)]
        [InlineData(5,1,4)]
        public void DamageTest(int damageAmount, int hitpoints, int expected)
        {
             // Arrange - set the test up
            Villain v = new Villain(1,"testVillain",hitpoints);

            // Act -  call the method to be tested
            v.Damage(damageAmount);

            int result = v.Hitpoints;
           
            // Assert - check is the answer is correct
            Assert.Equal(expected, result);
          

        }
    }*/
}
