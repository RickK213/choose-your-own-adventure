using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYOAdventure
{
    class StoryNode
    {
        //member variables
        public string storyBlock;
        public string question;
        public string optionA;
        public string optionB;
        public int nextNodeA;
        public int nextNodeB;
        public bool isSolution;


        //constructor
        public StoryNode(string storyBlock, string question, string optionA, string optionB, int nextNodeA, int nextNodeB, bool isSolution)
        {

        }


        //member methods
        public int Start()
        {
            Console.Clear();
            Console.WriteLine(storyBlock + "\n");
            if (!isSolution) {
                Console.WriteLine(question + "\n");
                Console.WriteLine("A) " + optionA + "\n");
                Console.WriteLine("B) " + optionB + "\n");
                string userSelection = Console.ReadKey().KeyChar.ToString();
                if (userSelection !="a" || userSelection!="b") {
                    Start();
                }
                switch (userSelection)
                {
                    case "a":
                        return nextNodeA;
                        break;
                    case "b":
                        return nextNodeB;
                        break;
                    default:
                        return 999;
                }
            }
            else
            {
                return 999;
            }
        }
    }
}
