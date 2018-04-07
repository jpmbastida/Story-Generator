using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryGenerator
{
    class Dad : ICharacter
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

        public Dad()
        {
            _article = new string[] { "my", "his", "her", "our", "their" };
            _noun = new string[] { "boy", "girl", "dog", "city", "car" };
            _verb = new string[] { "drove", "jumped", "ran", "walked", "skipped" };
            _preposition = new string[] { "to", "from", "over", "under", "on" };
        }
    }
}
