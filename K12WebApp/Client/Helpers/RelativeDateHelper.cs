namespace K12WebApp.Client.Helpers
{
    /*
     * Code fetched from: 
     * https://stackoverflow.com/a/1141237
     * 
     */
    public static class RelativeDateHelper
    {
        private static Dictionary<double, Func<double, string>> sm_Dict = null;

        private static Dictionary<double, Func<double, string>> DictionarySetup()
        {
            var dict = new Dictionary<double, Func<double, string>>();
            dict.Add(0.75, (mins) => "mindre end et minut siden");
            dict.Add(1.5, (mins) => "ca. et minut");
            dict.Add(45, (mins) => string.Format("{0} minutter", Math.Round(mins)));
            dict.Add(90, (mins) => "ca. en time");
            dict.Add(1440, (mins) => string.Format("ca. {0} timer", Math.Round(Math.Abs(mins / 60)))); // 60 * 24
            dict.Add(2880, (mins) => "en dag"); // 60 * 48
            dict.Add(43200, (mins) => string.Format("{0} dage", Math.Floor(Math.Abs(mins / 1440)))); // 60 * 24 * 30
            dict.Add(86400, (mins) => "ca. en måned"); // 60 * 24 * 60
            dict.Add(525600, (mins) => string.Format("{0} months", Math.Floor(Math.Abs(mins / 43200)))); // 60 * 24 * 365 
            dict.Add(1051200, (mins) => "ca. et år"); // 60 * 24 * 365 * 2
            dict.Add(double.MaxValue, (mins) => string.Format("{0} år", Math.Floor(Math.Abs(mins / 525600))));

            return dict;
        }

        public static string ToRelativeDate(this DateTime input)
        {
            TimeSpan oSpan = DateTime.Now.Subtract(input);
            double TotalMinutes = oSpan.TotalMinutes;
            string Suffix = " siden";

            if (TotalMinutes < 0.0)
            {
                TotalMinutes = Math.Abs(TotalMinutes);
                Suffix = " fra nu";
            }

            if (null == sm_Dict)
                sm_Dict = DictionarySetup();

            return sm_Dict.First(n => TotalMinutes < n.Key).Value.Invoke(TotalMinutes) + Suffix;
        }
    }
}

