using System;
using System.Collections.Generic;


var responses = new Dictionary<string, List<string>>()
{
    {"Canada", new List<string>(){"Really? It seems very unlikely.", "I  K N E W  I T !!!"}},
    {"enthusiastic", new List<string>(){"Yay!", "You should try it!"}},
    {"cSharp", new List<string>(){"Good job sucking up to your instructor!", "You will...oh, yes, you will..." }},
    {"secret", new List<string>(){"ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!"}}
};

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    question("Is Canada real?", "Canada");
    question("Are you enthusiastic?", "enthusiastic");
    question("Do you love C# yet?", "cSharp");
    question("Do you want to know a secret?", "secret");
}



void question(string question, string topic)
{
    if (MooseAsks(question))
    {
        MooseSays(responses[topic][0]);
    }
    else
    {
        MooseSays(responses[topic][1]);
    }
}


void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}