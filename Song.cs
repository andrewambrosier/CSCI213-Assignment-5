namespace CSCI213___Assignment_5 {
    public class Song {
        public Song(int id, string name, int performerID, decimal price) {
            SongID = id;
            SongName = name;
            PerformerID = performerID;
            SongPrice = price;
        }

        private int SongID { get; set; }
        private string SongName { get; set;
        private int PerformerID { get; set;}
        private decimal SongPrice { get; set;}

        /*public static List<Song> GetSongsByPerformer(int performerID) {
            //database
        }*/

        public override string ToString() => $"{SongName} (ID: {SongID}, Performer ID: {PerformerID}, Price: {SongPrice:C})";
    }
}
