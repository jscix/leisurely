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

namespace leisurely
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Default UI Element Values
        /// </summary>
        private Brush DefaultBackground;
        private Brush DefaultForeGround;

        public MainWindow()
        {
            InitializeComponent();
            // replace these with static colors
            DefaultBackground =  minimize.Background;
            DefaultForeGround = minimize.Foreground;
        }

        /// <summary>
        /// Custom Windows dragbar code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        /// <summary>
        /// Changes Interface Label Elements colors on mouseover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_Hover(object sender, MouseEventArgs e)
        {
            
            Label sendingLabel = (Label)sender;

            sendingLabel.Background = Brushes.Red;
            sendingLabel.Foreground = Brushes.White;
        }

        /// <summary>
        /// Changes Interface Labels colors back to default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_RemoveHover(object sender, MouseEventArgs e)
        {
            Label sendingLabel = (Label)sender;
            sendingLabel.Background = DefaultBackground;
            sendingLabel.Foreground = DefaultForeGround;
        }

        private void CloseApplication(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
