using DevExpress.XtraMap;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MapOverlaysSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region #Overlays
        private void Form1_Load(object sender, EventArgs e) {
            MapOverlay overlayWithText = new MapOverlay {
                Alignment = ContentAlignment.BottomRight,
                JoiningOrientation = Orientation.Vertical,
                Margin = new Padding(0, 4, 8, 8),
                Padding = new Padding(7)
            };
            overlayWithText.Items.Add(new MapOverlayTextItem {
                Text = "Copyright © 2015. Microsoft and its suppliers. All rights reserved."
            });
            map.Overlays.Add(overlayWithText);

            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            MapOverlay overlayWithImage = new MapOverlay {
                Alignment = ContentAlignment.BottomRight,
                JoiningOrientation = Orientation.Vertical,
                Margin = new Padding(0, 0, 8, 4),
                Padding = new Padding(0),
            };
            overlayWithImage.Items.Add(new MapOverlayImageItem { ImageUri = new Uri(baseUri, "..\\..\\Images\\BingLogo.png") });
            map.Overlays.Add(overlayWithImage);
        }
        #endregion #Overlays
    }
}
