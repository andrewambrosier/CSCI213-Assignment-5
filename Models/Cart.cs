namespace CSCI213___Assignment_5.Models {

    public class Cart {
        public Cart(int id, int userID) {
            CartID = id;
            UserID = userID;
            Songs = new List<Song>();
        }

        public int CartID { get; set; }
        public int UserID { get; set; }
        public List<Song> Songs { get; private set; }

        public void AddSong(Song song) {
            bool exists = false;

            foreach (var existingSong in Songs) { 
                if(existingSong.SongID == song.SongID) {
                    exists = true; break;//break after added song
                }
            }

            if(!exists) {
                Songs.Add(song);
            }
        }

        public void RemoveSong(Song song) {
            for( int i = 0; i < Songs.Count; i++) {
                if (Songs[i].SongID==song.SongID) {
                    Songs.RemoveAt(i);
                    break; //break after removing song
                }
            }
        }

        public decimal GetTotal() {
            decimal total = 0;
            foreach (var song in Songs){
                total += song.SongPrice;
            }

            return total;
        }

        public override string ToString() => 
            $"Shopping Cart (ID: {CartID}, User ID: {UserID}) - Total Price: {GetTotal():C}";

    }
}
