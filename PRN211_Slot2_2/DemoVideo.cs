using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Slot2_2
{
    public partial class DemoVideo : Form
    {
        private VideoView videoView;
        private LibVLC libVLC;
        private MediaPlayer mediaPlayer;
        public DemoVideo()
        {
            InitializeComponent();
        }

        private void DemoVideo_Load(object sender, EventArgs e)
        {
            Core.Initialize();

            // Tạo và cấu hình LibVLC
            libVLC = new LibVLC();
            mediaPlayer = new MediaPlayer(libVLC);

            // Tạo VideoView và thêm nó vào Panel
            videoView = new VideoView();
            videoView.Dock = DockStyle.Fill;
            panel1.Controls.Add(videoView);

            // Gắn MediaPlayer với VideoView
            videoView.MediaPlayer = mediaPlayer;

            // Set đường dẫn hoặc URL của video
            mediaPlayer.Play(new Media(libVLC, "D:\\[4K] Mahiru Shiina Christmas Animation.mp4"));
        }
    }
}
