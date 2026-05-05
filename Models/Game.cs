namespace KPL_MOD10_SE_48_02_103022400016_ENH.Models
{
    public class Game
    {
        public string Nama { get; set; }
        public string Developer { get; set; }
        public int Tahun { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public List<string> Platform { get; set; }
        public List<string> Mode { get; set; }
        public bool IsOnline { get; set; }
        public int Harga { get; set; }

    }
}
