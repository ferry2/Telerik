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

namespace VideoPlayer.Controls
{
    public partial class VideoPlayer : UserControl
    {
        public VideoPlayer()
        {
            InitializeComponent();
        }

        public Uri VideoSource
        {
            get
            {
                return (Uri)GetValue(VideoSourceProperty);
            }
            set
            {
                SetValue(VideoSourceProperty, value);
            }
        }

        public void Play()
        {
            this.VideoElement.Play();
        }
        public void Stop()
        {
            this.VideoElement.Stop();
        }
        public void Pause()
        {
            this.VideoElement.Pause();
        }

        public static readonly DependencyProperty VideoSourceProperty =
        DependencyProperty.Register("VideoSource", typeof(Uri), typeof(UserControl), new PropertyMetadata(
            (DependencyObject obj, DependencyPropertyChangedEventArgs args) =>
            {
                var videoPlayer = obj as MediaElement;
                bool wasPlaying = false;
                if (videoPlayer.CurrentState == MediaElementState.Playing)
                {
                    videoPlayer.Stop();
                    wasPlaying = true;
                }
                videoPlayer.Source = args.NewValue as Uri;
                if (wasPlaying)
                {
                    videoPlayer.Play();
                }
            }));
    }
}