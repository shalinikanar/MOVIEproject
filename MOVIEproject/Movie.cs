using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIEproject
{
   public class Movie
    {
        private string name;
        private string mainActor;
        private string genre;
        private string director;

        public Movie(string name, string mainActor, string genre, string director)

        {
            this.name = name;
            this.mainActor = mainActor;
            this.genre = genre;
            this.director = director;
        }
    }
}
