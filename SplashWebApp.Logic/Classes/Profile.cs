namespace SplashWebApp.Logic
{
    public class Profile
    {
        public int ProfileID { get; set; }
        public string ProfileName { get; set; }
        public string ProfileDesc { get; set; }
        public DateOnly Created { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public string Discord { get; set; }
        public string Youtube { get; set; }

        public Profile(int _profileID, string _profileName, string _profileDesc, string _discord, string _youtube)
        {   
            ProfileID = _profileID;
            ProfileName = _profileName;
            ProfileDesc = _profileDesc;
            Discord = _discord;
            Youtube = _youtube;
        }

    }
}