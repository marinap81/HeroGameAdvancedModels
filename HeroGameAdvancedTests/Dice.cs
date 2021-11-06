using System;
using System.Collections.Generic;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests
{
    public class DiceTests
    {
       [Fact]
        public void DiceTest()
        {
                Dice d = new Dice(1,6); 
                     
                int diceRollresult = d.Roll(); // object d. method//roll will return a random number within dice range.
                       
               Assert.InRange(diceRollresult,1,6); //passes- within range
        } 

            [Fact]
            public void DiceTest2()
            {
                Dice d2 = new Dice(1,10);

               int rolled = d2.Roll();

               //Assert.InRange(rolled,1,10);//will always pass because its inside the range of min/max.
               Assert.InRange(rolled,1,3); //testing against range 1-3, dice roll will either fail or pass, may take a few attempts to get a pass.
               Assert.InRange(rolled,0,0); // will always fail
             }


    }
}
