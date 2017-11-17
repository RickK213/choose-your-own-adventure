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
        private string storyBlock;
        private string question;
        private string optionA;
        private string optionB;
        private int nextNodeA;
        private int nextNodeB;
        private bool isSolution;
        private int gameOverNode = 999;


        //constructor
        public StoryNode(string storyBlock, string question, string optionA, string optionB, int nextNodeA, int nextNodeB, bool isSolution)
        {
            this.storyBlock = storyBlock;
            this.question = question;
            this.optionA = optionA;
            this.optionB = optionB;
            this.nextNodeA = nextNodeA;
            this.nextNodeB = nextNodeB;
            this.isSolution = isSolution;
        }


        //member methods
        public void DisplayStoryNode()
        {
            Console.Clear();
            Console.WriteLine(storyBlock + "\n");
            if (!isSolution)
            {
                Console.WriteLine(question + "\n");
                Console.WriteLine("A) " + optionA + "\n");
                Console.WriteLine("B) " + optionB + "\n");
            }
        }

        public int GetNextStoryNode()
        {
            if (!isSolution)
            {
                string userSelection = Console.ReadKey().KeyChar.ToString();
                if (!(userSelection == "a" || userSelection == "b"))
                {
                    DisplayStoryNode();
                }
                switch (userSelection)
                {
                    case "a":
                        return nextNodeA;
                    case "b":
                        return nextNodeB;
                    default:
                        return gameOverNode;
                }
            }
            else
            {
                return gameOverNode;
            }
        }

    }
}
