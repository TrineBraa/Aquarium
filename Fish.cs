﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Fisk er malen til fiskene, må lage egne raser av fiskene vi trenger fiske artene skal arve fra klassen fisk*/
namespace Aquarium
{
    internal class Fish
    {
        
        public string Name { get; private set; }
        public string Description { get; private set; }

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
