namespace JsonData {
    public class Artist {
        public string ArtistName;
        public string RealName;
        public int Age;
        public string Hometown;
        public int GroupId;
        public Group Group;

        public Artist(string artistName, string realName, int age, string hometown, int groupId)
        {
            ArtistName = artistName;
            RealName = realName;
            Age = age;
            Hometown = hometown;
            GroupId = groupId;
        }

        public override string ToString()
        {
            return $@"
            ArtistName: {ArtistName}
            RealName: {RealName}
            Age: {Age}
            Hometown: {Hometown}
            GroupId: {GroupId}";
        }
    }
    

}