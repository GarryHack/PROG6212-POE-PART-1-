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

namespace PROG6212_POE_PART_1_
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

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim submitted successfully! Status updated to Pending.");
            StatusTextBlock.Text = "Claim Status: Submitted - Awaiting Approval";
        }

        private void UploadDocumentButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Document uploaded. Attached to your claim.");
        }

        private void TrackStatusButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your claim is being tracked. Current status: Pending.");
        }

        private void ApproveClaimButton_Click(object sender, RoutedEventArgs e)
        {
             MessageBox.Show("Claim verified and approved!");
             AdminStatusTextBlock.Text = "All Claims: 4 Pending";
        }

        private void ViewClaimsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Showing list of pending claims. (Prototype - no real data)");
        }
    }
}
