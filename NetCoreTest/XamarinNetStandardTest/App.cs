using MyNetStandardLibrary;
using Xamarin.Forms;

namespace XamarinNetStandardTest
{
    public class App : Application
    {
        public App()
        {
            var test = new MyNetStandardClass();
            var myAmazingString = test.MyAmazingFunction();

            this.MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = myAmazingString
                        }
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
