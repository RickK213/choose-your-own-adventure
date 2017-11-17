using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYOAdventure
{
    class StoryGenerator
    {

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
                "\"That's cray, but I'm here to learn. I'll do my own Capstone.\"",
                6,
                7,
                false
            );

            StoryNode node4 = new StoryNode(
                "\"How was your weekend, Alicia?\" you ask. \"I told you to make it quick. I don't have time for chit-chat. Let's just say the Milwaukee River gets real cold in the wee hours of the morning.\" Alicia responds.\n\n\"Look, Mike just got here...why don't you ask him your question.\"",
                "Do you:",
                "Ask Mike about Andrew's disappearance?",
                "Get some coffee and ponder Alicia's response?",
                8,
                9,
                false
            );

            StoryNode node5 = new StoryNode(
                "\"I noticed Andrew isn't here, what's up with that?\" you ask. \"It's not my job to babysit Andrew.\" Alicia replies in a nervous tone. \"That guy takes a lot of risks...maybe the Monster Energy Drinks finally caught up with him.\"",
                "Do you say:",
                "\"That's a reach, Alicia. Is there something you're not telling me?\"",
                "\"I'm sure you're right. Have you seen Britt this morning? I've got some questions about her Capstone.\"",
                10,
                11,
                false
            );

            StoryNode node6 = new StoryNode(
                "\"No problemo, homie!\" Alex says as he opens up his admittedly mediocre Windows PC and pulls up GitHub. \"The URL is 'github.com/RickK213/sweet-sweet-treasure' -- just be sure not to share it with EVERYONE!\"\n\nWhat a morning! You walked into devCodeCamp thinking you would have to bust your butt for 12 weeks and now you've got the ultimate treasure in your Chrome bookmarks.\n\nYou may not have solved the mystery, but YOU WIN THE GAME!",
                "",
                "",
                "",
                0,
                0,
                true
            );

            StoryNode node7 = new StoryNode(
                "\"Suit yourself, but I'm going to use it. Writing Capstone Projects is for suckers.\" Alex says. \"If you tell anyone about it though, you're dead.\"",
                "Do you:",
                "Scurry over to Alicia to narc on Alex?",
                "Put your head down and continue working on your dice game?",
                12,
                13,
                false
            );

            StoryNode node8 = new StoryNode(
                "\"Hey Mike...Alicia sent me to you. What's up with Andrew not being here today?\" you ask. Mike's eyes dart over to Alicia's workstation as he says \"Come over to Ward 4 with me and I'll tell you. It's a sensitive subject.\"\n\nMike has never steered you wrong before so you follow him down the hallway toward the co-working space. Suddenly, Mike wheels around and you catch a glimpse of something small and thin in his hand as he spins violently.\n\nBefore you can react you notice a large red pool forming on your shirt. \"I'm sorry. I'm sorry.\" Mike blurts out. \"Alicia made me do this to you.\" As the world gets cold and dark you finally realize that Mike has just killed you by slitting your throat with a Pokémon card.\n\nYOU LOSE THE GAME.",
                "",
                "",
                "",
                0,
                0,
                true
            );

            StoryNode node9 = new StoryNode(
                "As you stroll over to the coffee pot for some of the sweet black nectar that Zach brewed up, Britt walks in the door looking white as a ghost.\n\n\"Is Alicia here?\" she asks. \"Yeah, she's right over there. She's not in a great mood though.\" you reply.\n\nWith an air of mystery she asks \"Are you feeling brave today?\"",
                "Do you say:",
                "\"I guess I'm feeling brave...what's up?\"",
                "\"Not really. People be acting crazy up in this piece today.\"",
                14,
                15,
                false
            );

            StoryNode node10 = new StoryNode(
                "Alicia's eyes well up with tears as her body nearly goes limp. \"I killed Andrew this weekend.\" she confesses. \"I had to do it. He WOULD NOT stop harping on the fact that I'm a Mac user. He pushed me to the edge.\"\n\nWhat a morning! You woke up thinking you'd be writing some Javascript code using best practices and you ended up solving The Mystery of The Missing Instructor.\n\nYOU WIN THE GAME!",
                "",
                "",
                "",
                0,
                0,
                true
            );

            StoryNode node11 = new StoryNode(
                "\"She's where she always is,\" Alicia says, \"winning money in Foosball across the hall.\"\n\nYou traverse the hallway into the lecture room where you find Britt. She's not playing Foos, though. She's in the middle of a group of people who make a path for you to talk to her.\n\n\"There you are,\" she says, \"are you feeling brave today?\"",
                "Do you say:",
                "\"I guess I'm feeling brave...what's up?\"",
                "\"Uh, not really. To be honest everyone is acting weird today.\"",
                14,
                15,
                false
            );

            StoryNode node12 = new StoryNode(
                "You thought you were doing the right thing as you pushed back your chair, stood up and walked over to Alicia defiantly.\n\nBefore you take two steps something hard hits you in the back of the head and you fall to the floor. As you roll over you see Alex standing above you holding his gigantic Windows laptop.\n\nYou misjudged Alex. You misjudged him badly. That is your last thought as he brings down the bulky, poorly designed laptop for the fatal blow.\n\nYOU HAVE LOST THE GAME.",
                "",
                "",
                "",
                0,
                0,
                true
            );

            StoryNode node13 = new StoryNode(
                "You feel pretty good about yourself as you continue busting out the Javascript code at record pace.\n\nA few minutes later, Britt walks over with a distressed look on her face and says \"I have information you will not believe. Are you feeling brave today?\"",
                "Do you say:",
                "\"Sure I'm feeling brave, you weirdo...what's up?\"",
                "\"People are being too weird today. I just want to write code.\"",
                14,
                15,
                false
            );

            StoryNode node14 = new StoryNode(
                "\"Alicia killed Andrew.\" Britt says bluntly. \"It had something to do her Mac. We need you to talk to her.\"\n\nMind blown, you think about your options.",
                "Do you:",
                "Confront Alicia about Andrew's death",
                "Call the police",
                16,
                17,
                false
            );

            StoryNode node15 = new StoryNode(
                "\"That's too bad,\" Britt says, \"we reward bravery here at devCodeCamp.\"\n\nBritt walks over to Mike's workstation and whispers something in his ear. Mike looks in your direction with disgust in his eyes.\n\n\"I heard you don't have the guts to help out your fellow student. I'm sorry to tell you, but that is not acceptable at dCC. You are no longer a student here. Pack up your crappy Mac and hit the bricks.\"\n\nWhat a morning! You thought you could spend the morning writing some code and fly under the radar. Because of your cowardice, you have been expelled from devCodeCamp.\n\nYOU HAVE LOST THE GAME.",
                "",
                "",
                "",
                0,
                0,
                true
            );

            StoryNode node16 = new StoryNode(
                "You walk over to Alicia's workstation and look her dead in the eye. \"What's up with the crazy stuff I'm hearing about you and Andrew?\" you ask.\n\nAlicia's eyes well up with tears as her body nearly goes limp. \"I killed Andrew this weekend.\" she confesses. \"I had to do it. He WOULD NOT stop harping on the fact that I'm a Mac user. He pushed me to the edge.\"\n\nWhat a morning! You woke up thinking you'd be writing some Javascript code using best practices and you ended up solving The Mystery of The Missing Instructor.\n\nYOU WIN THE GAME!",
                "",
                "",
                "",
                0,
                0,
                true
            );

            StoryNode node17 = new StoryNode(
                "Calling the police seemed like such a reasonable thing to do.\n\nYou pull your super sweet iPhone out of your pocket and dial \"9-1-\"\n\nBefore you can hit the last \"1,\" you hear \"Do it now, Mike.\"\n\nYou turn around and see Alicia with a wild look in her eye as she puts something small and thin in Mike's hand.\n\nMike turns toward you with a pained look in his eye and the small, thin thing flashes below your chin.\n\nAs the pool of blood grows around you, you realize that Mike has been Alicia's minion all along and, at her direction, he has just sliced your throat with a Pokémon card.\n\n\"Charizard was my demise,\" you think, as the world gets cold and dark. You are dead.\n\nYOU HAVE LOST THE GAME.",
                "",
                "",
                "",
                0,
                0,
                true
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

    }
}
