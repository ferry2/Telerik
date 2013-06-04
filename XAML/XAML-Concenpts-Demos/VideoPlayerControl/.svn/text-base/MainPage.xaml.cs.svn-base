using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.IO;
using System.Text;

namespace VideoPlayer
{
    public partial class MainPage : UserControl
    {
        private List<Uri> videoUris;

        public MainPage()
        {
            InitializeComponent();
            InitializeVideoUris();
        }

        private void InitializeVideoUris()
        {
            string folderPath = @"C:\Telerik Academy\Telerik Academy Videos\.Net Essentials\Rendered";
            //var folder = new DirectoryInfo(folderPath);
            //this.videoUris = folder.EnumerateFiles().Select(file => new Uri(file.FullName)).ToList();
            var uris = Directory.EnumerateFiles(folderPath);
            StringBuilder builder = new StringBuilder();
            foreach (var uri in videoUris)
            {
                builder.Append(uri);
            }
            this.TextBlockInfo.Text = builder.ToString();
        }
    }
}