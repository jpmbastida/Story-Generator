using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryGenerator
{
    class Sister : ICharacter
    {
        private string[] _article;
        private string[] _noun;
        private string[] _verb;
        private string[] _preposition;

        public string[] Article
        {
            get
            {
                return _article;
            }
        }

        public string[] Noun
        {
            get
            {
                return _noun;
            }
        }

        public string[] Verb
        {
            get
            {
                return _verb;
            }
        }

        public string[] Preposition
        {
            get
            {
                return _preposition;
            }
        }

        public Sister()
        {
            _article = new string[] { "her", "our", "their", "his", "my" };
            _noun = new string[] { "university", "school", "club", "forest", "mountain" };
            _verb = new string[] { "entered", "went", "was", "walked", "danced" };
            _preposition = new string[] { "on", "in", "at", "from", "to" };
        }
    }
}
