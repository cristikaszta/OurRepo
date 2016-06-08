using Emotion = DisertationProject.Model.Globals.Emotions;

namespace DisertationProject.Model
{
    /// <summary>
    /// Song class
    /// </summary>
    public class Song
    {
        //Why need this class person ?
        //public class Person
        //{
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string SongName { get; set; }

        public string ArtistName { get; set; }

        //public byte DataInformation { get; set; }

        public override string ToString()
        {
            return string.Format("{0} : {1}", ArtistName, SongName);
        }
        //}

        public string Source { get; set; }

        public Emotion Emotion { get; set; }

    }
}