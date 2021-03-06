﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StoryGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder storyBuilder = new StringBuilder();
            Random random = new Random();
            int numberOfParagraphs = random.Next(1, 7);

            for (int i = 0; i < numberOfParagraphs; i++)
            {
                int numberOfSentences = random.Next(4, 15);

                for (int j = 0; j < numberOfSentences; j++)
                {
                    StoryGenerator characterGenerator = new StoryGenerator(selectCharacterRole(random.Next(1, 6)));
                    storyBuilder.Append(characterGenerator.MakeParagraph());
                }
                storyBuilder.Append("\n\n");
            }
            Console.WriteLine("Once upon a time in Mexico...\n\n" + storyBuilder);
        }

        private static ICharacter selectCharacterRole(int character)
        {
            switch (character)
            {
                case 1: return new Dad();
                case 2: return new Mom();
                case 3: return new Grandma();
                case 4: return new Sister();
                case 5: return new Brother();
                default: return new Grandma();
            }
        }
    }
}
