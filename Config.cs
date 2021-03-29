using Rocket.API;
using System.Collections.Generic;

namespace MinecraftMusic
{ 
    public class Config : IRocketPluginConfiguration
    {
        public ushort Song1;
        public ushort Song2;
        public ushort Song3;
        public ushort Song4;
        public ushort Song5;
        public ushort Song6;
        public ushort Song7;
        public ushort Song8;
        public ushort Song9;
        public ushort Song10;
        public ushort Song11;
        public ushort Song12;
        public ushort Song13;
        public ushort Song14;
        public ushort Song15;
        

        public float TimeToStart;
        public float TimeBetweenSongs;
        public float TimeToRestartPlaylist;
        public void LoadDefaults()
        {
            Song1 = 3812;
            Song2 = 3805;
            Song3 = 3806;
            Song4 = 3807;
            Song5 = 3809;
            Song6 = 3810;
            Song7 = 3811;
            Song8 = 3813;
            Song9 = 3814;
            Song10 = 3815;
            Song11 = 3816;
            Song12 = 3817;
            Song13 = 3818;
            Song14 = 3819;
            Song15 = 3820;

            TimeToStart = 200f;
            TimeBetweenSongs = 600f;
            TimeToRestartPlaylist = 2000f;
        }
    }
}
