using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryGenerator
{
    class Brother : ICharacter
    {
        private string[] _article;
        public string[] Article
        {
            get
            {
                return _article;
            }
        }

        private string[] _noun;
        public string[] Noun
        {
            get
            {
                return _noun;
            }
        }
        private string[] _verb;
        public string[] Verb
        {
            get
            {
                return _verb;
            }
        }

        private string[] _preposition;
        public string[] Preposition
        {
            get
            {
                return _preposition;
            }
        }

        public Brother()
        {
            _article = new string[] { "her", "our", "his", "my", "their" };
            _noun = new string[] { "a girl", "a dog", "a woman", "a car", "a bar" };
            _verb = new string[] { "was", "walked", "went", "jumped", "talked" };
            _preposition = new string[] { "to", "from", "over", "under", "on" };
        }
    }
}
