namespace DotNet2019Challenge.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new DotNet2019Challenge.App());
        }
    }
}
