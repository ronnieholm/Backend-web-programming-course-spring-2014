using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise30 {
    class Runner {
        public void Run() {
            Human h1 = new Human(true, "Brown", "Black", 1);
            Human h2 = new Human(false, "White", "Blue", 4);
            Human h3 = new Human(true, "Blond", "Green", 8);

            Console.WriteLine(h1.GetDescription());
            Console.WriteLine(h2.GetDescription());
            Console.WriteLine(h3.GetDescription());
        }
    }

    class Human {
        private bool maleOrFemale;
        private string eyeColor;
        private string hairColor;
        private int heightCategory;

        public Human(bool maleOrFemale, string eyeColor, string hairColor, int heightCategory) {
            this.maleOrFemale = maleOrFemale;
            this.eyeColor = eyeColor;
            this.hairColor = hairColor;
            this.heightCategory = heightCategory;
        }

        public string GetDescription() {
            string description = "You got a " + GetGenderDescription();
            description = description + ", with " + eyeColor + " eyes";
            description = description + ", " + hairColor + " hair";
            description = description + ", who is " + GetHeightDescription();
            return description;
        }

        public string GetGenderDescription() {
            if (maleOrFemale) {
                return "man";
            }
            else {
                return "woman";
            }
        }

        public string GetHeightDescription() {
            switch (heightCategory) {
                case 0:
                    return "Very short";
                case 1:
                    return "Short";
                case 2:
                    return "Medium height";
                case 3:
                    return "Tall";
                case 4:
                    return "Very tall";
                default:
                    return "Unknown height";
            }
        }
    }
}
