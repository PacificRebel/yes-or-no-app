using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Yes_or_no_app.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}