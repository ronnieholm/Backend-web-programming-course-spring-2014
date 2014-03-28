using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise18b {
    class Runner {
        public void Run() {
            NumberGenerator theNumberGenerator = new NumberGenerator();
            BattleLog theLog = new BattleLog();

            Hero theHero = new Hero(theNumberGenerator, theLog);
            Beast theBeast = new Beast(theNumberGenerator, theLog);

            // Now battle...How do we do that (Hint: You need a loop)
            // YOUR JOB: Insert code here to make theHero and theBeast battle

            theLog.PrintEntireBattleLog();
        }
    }
}
