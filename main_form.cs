using System.Windows.Forms;
using System.Drawing;

// Class that represents main window of the program
class MainForm : Form
{
	public MainForm()
	{
		// Fixed 300x300 pixels window
		FormBorderStyle = FormBorderStyle.Fixed3D;
		Size = new Size(300, 300);

		// Icon for the program
		Icon = new Icon("resources\\main_icon.ico");
		Text = "Caesar's decryptor";
	}
}
