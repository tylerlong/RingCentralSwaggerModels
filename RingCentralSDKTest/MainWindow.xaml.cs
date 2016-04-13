using System.Diagnostics;
using System.Windows;
using RingCentral.SDK;
using RingCentral.SDK.Http;
using IO.Swagger.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace RingCentralSDKTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Platform platform = null;
        private void Authenticate()
        {
            if (platform == null)
            {
                platform = new SDK(Config.Instance.AppKey, Config.Instance.AppSecret, Config.Instance.ServerUrl, "Test App", "1.0.0").GetPlatform();
            }
            if (!platform.IsAuthorized())
            {
                platform.Authorize(Config.Instance.Username, null, Config.Instance.Password, true);
            }
        }

        private void Send_a_SMS(object sender, RoutedEventArgs e)
        {
            Authenticate();
            var requestModel = new CreateSMSMessage {
                Text = "Hello World",
                From = new MessageStoreCallerInfoRequest { PhoneNumber = Config.Instance.Username },
                To = new List<MessageStoreCallerInfoRequest> {
                    new MessageStoreCallerInfoRequest { PhoneNumber = Config.Instance.Receiver }
                },
            };
            var request = new Request("/restapi/v1.0/account/~/extension/~/sms", JsonConvert.SerializeObject(requestModel));
            var response = platform.Post(request);
            var responseJson = response.GetBody();
            var responseModel = JsonConvert.DeserializeObject<GetMessageInfoResponse>(responseJson);
        }

        private void Query_Call_Log(object sender, RoutedEventArgs e)
        {
            Authenticate();
        }

        private void Query_Message_Store(object sender, RoutedEventArgs e)
        {
            Authenticate();
        }

        private void Update_Message_Read_Status(object sender, RoutedEventArgs e)
        {
            Authenticate();
        }
    }
}
