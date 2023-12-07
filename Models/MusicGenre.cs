using System.Reflection.Metadata.Ecma335;

namespace CSCI213___Assignment_5.Models {
    public class MusicGenre {
        public MusicGenre(int id, string name) {
            GenreID = id;
            GenreName = name;
        }
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        /*public static List<MusicGenre> GetGenreList() { 
            //database retrieval i think
        }*/

        public override string ToString() => $"{GenreName} (ID: {GenreID})";
    }
}
