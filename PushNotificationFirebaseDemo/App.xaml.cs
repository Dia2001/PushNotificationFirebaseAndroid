using Plugin.FirebasePushNotification;

namespace PushNotificationFirebaseDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //App chạy lần đầu tiên sau khi cài. IOS khong chay duoc tren may ao. Chi chay duoc tren may that
            CrossFirebasePushNotification.Current.OnTokenRefresh += (s, p) =>
            {
                String a = p.Token;
                System.Diagnostics.Debug.WriteLine($"TOKEN : {p.Token}");

            };
            // Push message received event
            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {
                //System.Diagnostics.Debug.WriteLine("Received");
                //Plugin.Badge.CrossBadge.Current.SetBadge(1); //Nhieu thiet bi android ko hien thi duoc
            };
            //Push message received event
            CrossFirebasePushNotification.Current.OnNotificationOpened += (s, p) =>
            {
                //Plugin.Badge.CrossBadge.Current.ClearBadge();
                //System.Diagnostics.Debug.WriteLine("Opened");
                //foreach (var data in p.Data)
                //{
                //    System.Diagnostics.Debug.WriteLine($"{data.Key} : {data.Value}");
                //}
            };
        }
    }
}
