using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        HubConnection connection;
        public MainWindow()
        {
            InitializeComponent();
            //1==>declare hub
            connection = new HubConnectionBuilder().WithUrl("http://localhost:5297/ChatHub").Build();

			//4==>Recive
			connection.On<string, string>("NotifyNewMessage", (n, m) => {
				//display msg in listview
				msgList.Items.Add($"{n}:{m}");
			});

			//2==>start connection
			connection.StartAsync();
       
		}
        //3==>SEND

		private void Button_Click(object sender, RoutedEventArgs e)
		{
            connection.InvokeAsync("NewMessage", "WPF", msgText);
		}
	}
}
