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
        public int currentNode = 1;

        public List<StoryNode> CreateStoryNodes()
        {

            StoryNode node1 = new StoryNode(
                "It’s a typical Monday morning as you slog through morning traffic and arrive at devCodeCamp at 7:04 AM. You wipe the last bit of sleep out of your eyes as you make it to your workstation and open up Slack to check for new notifications.\n\nThat’s when you realize something is off. Andrew is typically the first instructor to arrive on Mondays but today Alicia is fielding questions from the throng of bewildered students.",
                "Do you:",
                "Wait in the growing line of students to ask Alicia why Andrew is missing?",
                "Start working on your Javascript dice game?",
                2,
                3,
                false
            );

            StoryNode node2 = new StoryNode(
                "After waiting for 10 minutes while Eric tries to figure out his dice baseball game, you finally arrive at the front of the line and greet an obviously agitated Alicia.\n\n\"What's up? Make it quick.\" she says.\n\nHmm. That's not like her. Maybe she had a bad weekend.",
                "Do you:",
                "Ask her how her weekend went?",
                "Ask her where Andrew is?",
                4,
                5,
                false
            );

            StoryNode node3 = new StoryNode(
                "You decide that Andrew is probably fine and just stayed up late last night playing Overwatch and guzzling 16oz cans of Monster Energy Drink. Right after you start up your awesome Mac and get into jamming out some code in Sublime, Alex sits down and he's obviously excited. \"Dude...I found something and you're not going to believe it.\" You look up from your code as he drops the bombshell. \"It's a secret GitHub account full of pre-written Capstone Projects.\"",
                "Do you say:",
                "\"Holy crap! Give me the URL!\"",
                "\"That's cray, but I'm here to learn.I'll do my own Capstone.\"",
                6,
                7,
                false
            );

            StoryNode node4 = new StoryNode(
                "\"How was your weekend, Alicia ?\" you ask. \"I told you to make it quick.I don't have time for chit-chat. Let's just say The Milwaukee River gets real cold in the wee hours of the morning.\" Alicia responds. \"Look, Mike just got here...why don't you ask him your question.\"",
                "Do you:",
                "Ask Mike about Andrew's disappearance?",
                "Get some coffee and ponder Alicia's response?",
                8,
                9,
                false
            );

            StoryNode node5 = new StoryNode(
                "\"I noticed Andrew isn't here, what's up with that ?\" you say. \"It's not my job to babysit Andrew.\" Alicia replies in a nervous tone. \"That guy takes a lot of risks...maybe the Monster Energy Drinks finally caught up with him.\"",
                "Do you say:",
                "\"That's a reach, Alicia. Is there something you're not telling me ?\"",
                "\"I'm sure you're right.Have you seen Brit this morning ? I've got some questions about her Capstone.\"",
                10,
                11,
                false
            );

            StoryNode node6 = new StoryNode(
                "\"No problemo, homie!\" Alex says as he opens up his admittedly mediocre Windows PC and pulls up GitHub. \"The URL is 'github.com/RickK213/sweet-sweet-treasure'-- just be sure not to share it with EVERYONE!\"\n\nWhat a morning!You walked into devCodeCamp thinking you would have to bust your butt for 12 weeks and now you've got the ultimate treasure in your Chrome bookmarks.\n\nYou win the game!",

               "Do you:",
                "",
                "",
                0,
                0,
                true
            );

            StoryNode node7 = new StoryNode(
                "",
                "Do you:",
                "",
                "",
                0,
                0,
                false
            );

            StoryNode node8 = new StoryNode(
                "",
                "Do you:",
                "",
                "",
                0,
                0,
                false
            );

            StoryNode node9 = new StoryNode(
                "",
                "Do you:",
                "",
                "",
                0,
                0,
                false
            );

            StoryNode node10 = new StoryNode(
                "",
                "Do you:",
                "",
                "",
                0,
                0,
                false
            );

            StoryNode node11 = new StoryNode(
                "",
                "Do you:",
                "",
                "",
                0,
                0,
                false
            );

            StoryNode node12 = new StoryNode(
                "",
                "Do you:",
                "",
                "",
                0,
                0,
                false
            );

            StoryNode node13 = new StoryNode(
                "",
                "Do you:",
                "",
                "",
                0,
                0,
                false
            );

            StoryNode node14 = new StoryNode(
                "",
                "Do you:",
                "",
                "",
                0,
                0,
                false
            );

            StoryNode node15 = new StoryNode(
                "",
                "Do you:",
                "",
                "",
                0,
                0,
                false
            );

            StoryNode node16 = new StoryNode(
                "",
                "Do you:",
                "",
                "",
                0,
                0,
                false
            );

            StoryNode node17 = new StoryNode(
                "",
                "Do you:",
                "",
                "",
                0,
                0,
                false
            );

            List<StoryNode> storyNodes = new List<StoryNode>();
            storyNodes.Add(node1);
            storyNodes.Add(node2);
            storyNodes.Add(node3);
            storyNodes.Add(node4);
            storyNodes.Add(node5);
            storyNodes.Add(node6);
            storyNodes.Add(node7);
            storyNodes.Add(node8);
            storyNodes.Add(node9);
            storyNodes.Add(node10);
            storyNodes.Add(node11);
            storyNodes.Add(node12);
            storyNodes.Add(node13);
            storyNodes.Add(node14);
            storyNodes.Add(node15);
            storyNodes.Add(node16);
            storyNodes.Add(node17);
            return storyNodes;
        }

        public void Start()
        {
            //Introduction. User presses any key to start
            Console.WriteLine("Welcome to The Mystery of the Missing Instructor. A choose-your-own adventure game.\n\nThroughout the game you will have 2 options: A or B\n\nSimply type the key of your choice and you will be taken to the next part of the story.\n\nType any key to start.");
            Console.ReadKey();
            Console.Clear();

            List<StoryNode> storyNodes = CreateStoryNodes();

            while (!gameOver)
            {
                int nextNode = storyNodes[currentNode - 1].Start();
                if (nextNode == 999)
                {
                    gameOver = true;
                }
                else
                {
                    currentNode = nextNode;
                }  
            }

            Console.WriteLine("\n\nWould you like to play again? Press 'y' or 'n'");
        }
    }
}
