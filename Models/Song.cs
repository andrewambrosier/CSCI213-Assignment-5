using System.ComponentModel.DataAnnotations;
    
namespace CSCI213___Assignment_5.Models {
    public class Song {
         public Song(int id, string name, int performerID, decimal price) {
             SongID = id;
             SongName = name;
             PerformerID = performerID;
             SongPrice = price;
         }

        public int SongID { get; set; }
        public string SongName { get; set; }
        public int PerformerID { get; set;}
        public decimal SongPrice { get; set;}

        /*public static List<Song> GetSongsByPerformer(int performerID) {
            //database
        }*/

       // public override string ToString() => $"{SongName} (ID: {SongID}, Performer ID: {PerformerID}, Price: {SongPrice:C})";

    }
}
