using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryGenerator
{
    interface ICharacter
    {
        string[] Article { get; }
        string[] Noun { get; }
        string[] Verb { get; }
        string[] Preposition { get; }
    }
}
