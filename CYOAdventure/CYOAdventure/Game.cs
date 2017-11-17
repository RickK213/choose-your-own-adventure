using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYOAdventure
{
    class Game
    {

        public bool isGameOver = false;
        public int currentNode = 1;
        public int gameOverNode = 999;

        private void RestartGame()
        {
            Console.WriteLine("\nWould you like to play again? Press 'y' or 'n'");
            string userSelection = Console.ReadKey().KeyChar.ToString();
            if (!(userSelection == "y" || userSelection == "n"))
            {
                Console.Clear();
                RestartGame();
            }
            switch (userSelection)
            {
                case "y":
                    Console.Clear();
                    isGameOver = false;
                    currentNode = 1;
                    Start();
                    break;
                case "n":
                    return;
            }
        }

        private void DisplayIntro()
        {
            Console.WriteLine("Welcome to The Mystery of the Missing Instructor--a choose-your-own adventure game. The ultimate goal of the game is to solve the mystery but there are other outcomes that are considered a \"win.\"\n\nThroughout the game you will have 2 options: A or B\n\nSimply type the key of your choice and you will be taken to the next part of the story.\n\nType any key to start.");
            Console.ReadKey();
            Console.Clear();
        }

        public void Start()
        {

            DisplayIntro();

            StoryGenerator mainStoryGenerator = new StoryGenerator();
            List<StoryNode> storyNodes = mainStoryGenerator.CreateStoryNodes();

            while (!isGameOver)
            {
                storyNodes[currentNode - 1].DisplayStoryNode();
                int nextNode = storyNodes[currentNode - 1].GetNextStoryNode();
                if (nextNode == gameOverNode)
                {
                    isGameOver = true;
                }
                else
                {
                    currentNode = nextNode;
                }  
            }

            RestartGame();
        }
    }
}
