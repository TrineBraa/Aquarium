using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Fisk er malen til fiskene, må lage egne raser av fiskene vi trenger fiske artene skal arve fra klassen fisk*/
namespace Aquarium
{
    abstract class Fish
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Fish(string aName, string aDescription)
        {
            _name = aName;
            _description = aDescription;
        }

        public Fish()
        {

        }
        
    }
}
