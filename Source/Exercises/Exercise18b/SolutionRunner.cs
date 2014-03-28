using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise18b {
    class SolutionRunner {
        public void Run() {
            NumberGenerator theNumberGenerator = new NumberGenerator();
            BattleLog theLog = new BattleLog();

            Hero theHero = new Hero(theNumberGenerator, theLog);
            Beast theBeast = new Beast(theNumberGenerator, theLog);

            while (!theHero.IsDead() && !theBeast.IsDead()) {
                // Let hero deal damage to beast:
                theBeast.ReceiveDamage(theHero.DealDamage());

                // Let beast deal damage to hero (if it is not dead...)
                if (!theBeast.IsDead()) {
                    theHero.ReceiveDamage(theBeast.DealDamage());
                }
            }

            theLog.PrintEntireBattleLog();
        }
    }
}
