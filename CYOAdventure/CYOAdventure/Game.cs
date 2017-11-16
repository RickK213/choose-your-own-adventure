using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYOAdventure
{
    class Game
    {
        //member variables

        public bool gameOver = false;

        //NODE 1
        public string storyBlock1 = "It’s a typical Monday morning as you slog through morning traffic and arrive at devCodeCamp at 7:04 AM. You wipe the last bit of sleep out of your eyes as you make it to your workstation and open up Slack to check for new notifications.\n\nThat’s when you realize something is off. Andrew is typically the first instructor to arrive on Mondays but today Alicia is fielding questions from the throng of bewildered students.";
        public string question1 = "Do you:";
        public string optionA1 = "Wait in the growing line of students to ask Alicia why Andrew is missing?";
        public string optionB1 = "Start working on your Javascript dice game?";
        public int nextNodeA1 = 2;
        public int nextNodeB1 = 3;
        public bool isSolution1 = false;

        //NODE 2
        public string storyBlock2 = "After waiting for 10 minutes while Eric tries to figure out his dice baseball game, you finally arrive at the front of the line and greet an obviously agitated Alicia.\n\n\"What's up? Make it quick.\" she says.\n\nHmm. That's not like her. Maybe she had a bad weekend.";
        public string question2 = "Do you:";
        public string optionA2 = "Ask her how her weekend went?";
        public string optionB2 = "Ask her where Andrew is?";
        public bool isSolution2 = false;

        
        //member methods
        public void Start()
        {
            //Introduction. User presses any key to start
            Console.WriteLine("Welcome to The Mystery of the Missing Instructor. A choose-your-own adventure game.\n\nThroughout the game you will have 2 options: A or B\n\nSimply type the key of your choice and you will be taken to the next part of the story.\n\nType any key to start.");
            Console.ReadKey();

            StoryNode nextNode = new StoryNode(storyBlock1, question1, optionA1, optionB1, nextNodeA1, nextNodeB1, isSolution1);
            int userSelection = nextNode.Start();
            while (!gameOver)
            {
                //get the next story node
            }
            //switch (userSelection)
            //{
            //    case "a":
            //        nextNode = StoryNode(storyBlock2, question2, optionA2, optionB2);
            //        userSelection = nextNode.Start();
            //        break;
            //    case "b":
            //        nextNode = StoryNode(storyBlock3, question3, optionA3, optionB3);
            //        nextNode.Start();
            //        break;
            //    case "c":
            //        nextNode = StoryNode(storyBlock3, question3, optionA3, optionB3);
            //        nextNode.Start();
            //        break;
            //}
        }
    }
}
