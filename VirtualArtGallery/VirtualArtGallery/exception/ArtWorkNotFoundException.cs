using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualArtGallery.Exceptions
{
    public class ArtWorkNotFoundException : Exception
    {
        //Parameterless constructpr
        public ArtWorkNotFoundException() : base("Artwork not found.")
        {
        }
        //Parameterized constructor
        public ArtWorkNotFoundException(string message) : base(message)
        {
        }
    }
}
