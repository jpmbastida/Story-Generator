using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryGenerator
{
    class StoryGenerator
    {
        private ICharacter _characterInStory;

        public StoryGenerator(ICharacter characterInStory)
        {
            _characterInStory = characterInStory;
        }

        public string MakeParagraph()
        {
            Random random = new Random();

            string sentence = _characterInStory.Article[random.Next(0, 5)] + " " + 
                _characterInStory.GetType().Name + " " +
                _characterInStory.Verb[random.Next(0, 5)] + " " +
                _characterInStory.Preposition[random.Next(0, 5)] + " " +
                _characterInStory.Article[random.Next(0, 5)] + " " +
                _characterInStory.Noun[random.Next(0, 5)] + ". ";

            sentence = sentence[0].ToString().ToUpper() + sentence.Substring(1);
            return sentence;
        }
    }
}
