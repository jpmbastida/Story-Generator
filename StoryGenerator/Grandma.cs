using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryGenerator
{
    class Grandma : ICharacter
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

        public Grandma()
        {
            _article = new string[] { "our", "my", "his", "their", "her" };
            _noun = new string[] { "guy", "airplain", "woman", "bed", "helicopter" };
            _verb = new string[] { "flew", "came", "went", "talked", "spoke" };
            _preposition = new string[] { "over", "under", "from", "on", "to" };
        }
    }
}
