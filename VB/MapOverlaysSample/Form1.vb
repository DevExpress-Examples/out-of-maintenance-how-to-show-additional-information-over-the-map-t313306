Imports DevExpress.XtraMap
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace MapOverlaysSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#Overlays"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim overlayWithText As MapOverlay = New MapOverlay With {.Alignment = ContentAlignment.BottomRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 4, 8, 8), .Padding = New Padding(7)}
            overlayWithText.Items.Add(New MapOverlayTextItem With {.Text = "Copyright © 2015. Microsoft and its suppliers. All rights reserved."})
            map.Overlays.Add(overlayWithText)

            Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
            Dim overlayWithImage As MapOverlay = New MapOverlay With {.Alignment = ContentAlignment.BottomRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 0, 8, 4), .Padding = New Padding(0)}
            overlayWithImage.Items.Add(New MapOverlayImageItem With {.ImageUri = New Uri(baseUri, "..\..\Images\BingLogo.png")})
            map.Overlays.Add(overlayWithImage)
        End Sub
        #End Region ' #Overlays
    End Class
End Namespace
