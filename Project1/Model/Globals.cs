
namespace DisertationProject.Model
{
    /// <summary>
    /// Globals
    /// </summary>
    public static class Globals
    {
        //Strings
        public const string ConnectionString = "Server=tcp:ourserver.database.windows.net,1433;Data Source=ourserver.database.windows.net;Initial Catalog=ourdatabase;Persist Security Info=False;User ID=lanister;Password=tyrion0!;Pooling=False;MultipleActiveResultSets=False;Encrypt=FALSE;Connection Timeout=30;";

        //Ids
        public const int PlayButtonId = Resource.Id.playButton;
        public const int PauseButtonId = Resource.Id.pauseButton;
        public const int StopButtonId = Resource.Id.stopButton;
        public const int PreviousButtonId = Resource.Id.previousButton;
        public const int NextButtonId = Resource.Id.nextButton;
        public const int RepeatButtonId = Resource.Id.repeatButton;
        public const int MainLayoutId = Resource.Layout.Main;
        public const int ErrorTextBox = Resource.Id.textView1;
        public const int SongListView = Resource.Id.songListView;

        //Actions
        public const string ActionPlay = "com.xamarin.action.PLAY";
        public const string ActionPause = "com.xamarin.action.PAUSE";
        public const string ActionStop = "com.xamarin.action.STOP";
        public const string ActionPrevious = "com.xamarin.action.PREVIOUS";
        public const string ActionNext = "com.xamarin.action.NEXT";
        public const string ActionRepeatOn = "REPEAT_ON";
        public const string ActionRepeatOff = "REPEAT_OFF";

        //Errors
        public const string TestAction = "123434";
        public const string GeneralException = "GeneralException";
        public const string IllegalStateException = "IllegalStateException";
        public const string NetworkOffline = "NetworkOffline";
        public const string DatabaseError = "DatabaseError";

        //Labels
        public const string ProjectLabel = "DisertationProject";

        //Sample congs
        // do not use public const string SampleSong1 = @"http://www.montemagno.com/sample.mp3";
        public const string SampleSong2 = @"http://www.tonycuffe.com/mp3/tail%20toddle.mp3";
        public const string SampleSong3 = @"http://www.tonycuffe.com/mp3/saewill_lo.mp3";
        public const string SampleSong4 = @"http://www.stephaniequinn.com/Music/Commercial%20DEMO%20-%2012.mp3";
        public const string SampleSong5 = @"http://www.stephaniequinn.com/Music/Commercial%20DEMO%20-%2004.mp3";
        public const string SampleSong6 = @"http://www.stephaniequinn.com/Music/Commercial%20DEMO%20-%2001.mp3";
        public const string SampleSong7 = @"http://www.tonycuffe.com/mp3/girlwho.mp3";
        public const string SampleSong8 = @"http://www.tonycuffe.com/mp3/cairnomount.mp3";
        public const string SampleSong9 = @"http://www.tonycuffe.com/mp3/pipers%20hut.mp3";

        //Enumerations
        public enum Emotions { Sad, Happy, Neutral, Angry }
        public enum TextType { Info, Warning, Error }
        public enum PlayState { Playing, Stopped, Paused }
        public enum State { On, Off }
    }
}