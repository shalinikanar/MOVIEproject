using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIEproject
{
   public class Movie
    {
        private string Name;
        private string mainActor;
        private string Genre;
        private string Director;

        public Movie(string Name, string mainActor, string Genre, string Director)

        {
            this.Name = Name;
            this.mainActor = mainActor;
            this.Genre = Genre;
            this.Director = Director;
        }
    }
}
