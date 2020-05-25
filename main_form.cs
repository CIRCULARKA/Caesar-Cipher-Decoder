using System.Windows.Forms;
using System.Drawing;

// Class that represents main window of the program
class MainForm : Form
{
	public MainForm()
	{
		//
		// Window size
		//
		FormBorderStyle = FormBorderStyle.Fixed3D;
		Size = new Size(300, 300);

		//
		// Header of the program
		//
		Icon = new Icon("resources\\main_icon.ico");
		Text = "Caesar's decryptor";

		//
		// Objects to input
		//
		// Invitation label

		const int VER_DIST = 20;

		Label input_label = new Label();
		input_label.Text = "Input string to encrypt/decrypt it:";
		input_label.Location = new Point(10, 10);
		input_label.Size = new Size(250, 13);

		Controls.Add(input_label);

		// Box for inputting string
		TextBox usr_input = new TextBox();
		usr_input.Top = input_label.Top + VER_DIST;
		usr_input.Left = input_label.Left;
		usr_input.Size = new Size(this.Width - (input_label.Left * 3), VER_DIST);

		Controls.Add(usr_input);
	}
}
