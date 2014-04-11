using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise30 {
    class SolutionRunner {
        public void Run() {
            HumanSolution h1 = new HumanSolution(GenderSolution.Male, EyeColorSolution.Brown, HairColorSolution.Black, HeightCategorySolution.Short);
            HumanSolution h2 = new HumanSolution(GenderSolution.Female, EyeColorSolution.Green, HairColorSolution.Blond, HeightCategorySolution.VeryTall);

            Console.WriteLine(h1.GetDescription());
            Console.WriteLine(h2.GetDescription());
        }
    }

    enum GenderSolution { Male, Female };
    enum EyeColorSolution { Green, Blue, Black, Brown };
    enum HairColorSolution { Brown, Black, Blond };
    enum HeightCategorySolution { VeryShort, Short, MediumHeight, Tall, VeryTall };

    class HumanSolution {
        private GenderSolution gender;
        private EyeColorSolution eyeColor;
        private HairColorSolution hairColor;
        private HeightCategorySolution heightCategory;

        public HumanSolution(GenderSolution gender, EyeColorSolution eyeColor, HairColorSolution hairColor, HeightCategorySolution heightCategory) {
            this.gender = gender;
            this.eyeColor = eyeColor;
            this.hairColor = hairColor;
            this.heightCategory = heightCategory;
        }

        public string GetDescription() {
            string description = "You got a " + gender;
            description = description + ", with " + eyeColor + " eyes";
            description = description + ", " + hairColor + " hair";
            description = description + ", who is " + heightCategory;
            return description;
        }
    }
}
