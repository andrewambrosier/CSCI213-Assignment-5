namespace CSCI213___Assignment_5 {
    public class Performer {

        public Performer(int id, string name, int genreID) {
            PerformerID = id;
            PerformerName = name;
            GenreID = genreID;
        }

        public int PerformerID {  get;  set; }
        public string PerformerName { get;  set; }
        public int GenreID { get; set;}//Link to MusicGenre

        /*public static List<Performer> GetPerformersByGenre(int genreID) { 
            //database retrieval
        }*/

        public override string ToString() => $"{PerformerName} (ID: {PerformerID}, Genre ID: {GenreID})";
    }
}
