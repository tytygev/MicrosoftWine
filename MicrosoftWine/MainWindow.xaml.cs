using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace MicrosoftWine
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        

        private void AddProgressBarSegment(object sender, RoutedEventArgs e)
        {
            var segment = new Rectangle();
            WrapPanel wrapPan = (WrapPanel)this.FindName("ProgressBarWrapPan");
            wrapPan.Children.Add(segment);
        }
        private void TimerTick(object sender, EventArgs e)
        {
            var segment = new Rectangle();
            WrapPanel wrapPan = (WrapPanel)this.FindName("ProgressBarWrapPan");
            wrapPan.Children.Add(segment);
        }
    }
}
