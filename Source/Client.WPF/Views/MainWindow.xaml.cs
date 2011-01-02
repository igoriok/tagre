namespace Client.WPF.Views
{
    using System;
    using System.Windows;

    using Igoriok.Tagre.Client.WPF.ViewModels;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets view-model.
        /// </summary>
        public MainWindowViewModel ViewModel
        {
            get { return (MainWindowViewModel)DataContext; }
            set { DataContext = value; }
        }
    }
}
