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
//using Messeg.ViewModels;

namespace Messeg
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateNewChat_Click(object sender, RoutedEventArgs e)
        {
            startScreen.Visibility = Visibility.Collapsed;
            chatScreen.Visibility = Visibility.Visible;
        }

        private void ConnectToChat_Click(object sender, RoutedEventArgs e)
        {
            startScreen.Visibility = Visibility.Collapsed;
            chatScreen.Visibility = Visibility.Visible;
        }

        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            string message = messageTextBox.Text;
            messageTextBox.Text = "";
        }

        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            startScreen.Visibility = Visibility.Visible;
            chatScreen.Visibility = Visibility.Collapsed;
        }

        private void UpdateUsersList()
        {

            usersListBox.Items.Clear();
            //foreach (string user in usersList)
            {
                //usersListBox.Items.Add(user);
            }
        }

        private void AddUserToList(string username)
        {
            //usersList.Add(username);
            UpdateUsersList();
        }

        private void RemoveUserFromList(string username)
        {
            
            //usersList.Remove(username);
            UpdateUsersList();
        }

        private void ReceiveMessage(string message)
        {
            
        }
    }
}