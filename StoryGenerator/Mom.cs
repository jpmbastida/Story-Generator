using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryGenerator
{
    class Mom : ICharacter
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

        public Mom()
        {
            _article = new string[] { "her", "their", "his", "my", "our" };
            _noun = new string[] { "cat", "house", "bicycle", "roof", "bed" };
            _verb = new string[] { "went", "cooked", "walked", "jumped", "spoke" };
            _preposition = new string[] { "from", "up", "to", "on", "under" };
        }
    }
}
