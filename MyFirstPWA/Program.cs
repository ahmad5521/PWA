using Ooui;
using System;
using Xamarin.Forms;

namespace MyFirstPWA
{
    class Program
    {
        static void Main(string[] args)
        {
            Forms.Init();

            var mainPage = new MainPage();
            UI.Publish("/", mainPage.GetOouiElement());
        }
    }
}
