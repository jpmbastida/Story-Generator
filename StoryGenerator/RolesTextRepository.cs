using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryGenerator
{
    class RolesTextRepository
    {
        public List<string> getRoleText(ICharacter role)
        {
            switch (role.GetType().Name)
            {
                case "Dad": return dadTemplates;
                case "Mom": return momTemplates;
                case "Grandma": return grandmaTemplates;
                case "Sister": return sisterTemplates;
                case "Brother": return brotherTemplates;
                default: throw new Exception();
            }
        }

        public void eraseUsedLines(ICharacter role, int index)
        {
            switch (role.GetType().Name)
            {
                case "Dad":
                    dadTemplates.RemoveAt(index);
                    break;
                case "Mom":
                    momTemplates.RemoveAt(index);
                    break;
                case "Grandma":
                    grandmaTemplates.RemoveAt(index);
                    break;
                case "Sister":
                    sisterTemplates.RemoveAt(index);
                    break;
                case "Brother":
                    brotherTemplates.RemoveAt(index);
                    break;
                default: throw new Exception();
            }
        }

        private List<string> dadTemplates = new List<string>() {
                "worked at home one day",
                "turned the mixer off",
                "locked the door",
                "went to cinema with mom",
                "was sick", "thought us how to play baseball"
            };

        private List<string> momTemplates = new List<string>() {
                "cooked Borsh",
                "bought us a music player",
                "always help us with homework",
                "tought us to be good people",
                "was always worry for us"
            };

        private List<string> grandmaTemplates = new List<string>() {
                "is a wonderful person",
                "always is playing with us",
                "cares about us su much",
                "wants us to be happy",
                "is a so lovely woman"
            };

        private List<string> sisterTemplates = new List<string>() {
                "studies at XAI",
                "loves playing the guitar",
                "is very smart",
                "enjoys so much to spend time with family",
                "likes to make us happy"
            };

        private List<string> brotherTemplates = new List<string>() {
                "always cares about all of us",
                "is working for an international company",
                "is very kind with everyone",
                "loves us su much",
                "has three kids, my cousins"
            };
    }
}
