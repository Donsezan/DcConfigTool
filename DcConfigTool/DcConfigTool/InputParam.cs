namespace DcConfigTool
{
    public class InputParam
    {
        public enum GameType { Solitaire, Mahjong }

        public static string FilePath { get; set; }
        public static int MonthSet { get; set; }
        public static int YaerSet { get; set; }
        public static string OutputPath { get; set; }
        public static GameType GameTypeSet { get; set; }
        public static bool Yeargenerator { get; set; }
    }
}
