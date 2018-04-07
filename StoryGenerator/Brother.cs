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

        public Brother()
        {
            _article = new string[] { "her", "our", "his", "my", "their" };
            _noun = new string[] { "girl", "dog", "woman", "car", "bar" };
            _verb = new string[] { "was", "walked", "went", "jumped", "talked" };
            _preposition = new string[] { "to", "from", "over", "under", "on" };
        }
    }
}
