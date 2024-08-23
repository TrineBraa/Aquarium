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
        
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public Fish(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Fish()
        {
            
        }
    }
}
