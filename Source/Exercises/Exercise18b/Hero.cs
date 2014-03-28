﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise18b {
    // This class implements a simple game character
    // 1) The character has a certain number of "hit points"
    // 2) The character can deal damage
    // 3) The character can receive damage, causing the hit points to decrease
    class Hero {
        private int currentHitPoints;
        private NumberGenerator generator;
        private BattleLog log;

        // Create a Hero, using references to a random number generator and a battle log
        public Hero(NumberGenerator generator, BattleLog log) {
            this.generator = generator;
            this.log = log;
            Reset();
        }

        // Reset the Hero's state to the original state
        public void Reset() {
            currentHitPoints = 100;
        }

        // Returns the amount of points a Hero deals in damage.
        // This damage could then be received by another character
        public int DealDamage() {
            int damage = generator.GetRandomNumberInInterval(10, 30);
            string message = "Hero dealt " + damage + " damage!";
            log.Save(message);
            return damage;
        }

        // The Hero receives the amount of damage specified in the parameter.
        // The number of hit points will decrease accordingly
        public void ReceiveDamage(int points) {
            currentHitPoints = currentHitPoints - points;
            string message = "Hero receives " + points + " damage, and is down to " + currentHitPoints + " hit points";
            log.Save(message);

            if (IsDead()) {
                log.Save("Hero died!");
            }
        }

        // Checks if the Hero is dead, defined as having 0 or less hit points...
        public bool IsDead() {
            return currentHitPoints <= 0;
        }
    }
}
