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

		const int VER_DIST = 25;
		const int SYMB_HEIGHT = 13;

		// Invitation label
		Label input_label = new Label();
		input_label.Text = "Input string to encrypt/decrypt it:";
		input_label.Location = new Point(10, 10);
		input_label.Size = new Size(this.Width - (input_label.Left * 3), SYMB_HEIGHT);

		Controls.Add(input_label);

		// Box for inputting string
		TextBox usr_input = new TextBox();
		usr_input.Top = input_label.Top + VER_DIST;
		usr_input.Left = input_label.Left;
		usr_input.Size = new Size(this.Width - (input_label.Left * 3), SYMB_HEIGHT);

		Controls.Add(usr_input);

		//
		// Key presence check
		//

		const int HOR_DIST = 20;

		// Checkbox for it
		CheckBox key_check = new CheckBox();
		key_check.Size = new Size(15, 15);
		key_check.Left = usr_input.Left;
		key_check.Top = usr_input.Top + VER_DIST;
		key_check.AutoCheck = true;

		Controls.Add(key_check);

		// Text for key presence check
		Label key_presence_label = new Label();
		int control_width = this.Width - ((key_check.Left * 2) + key_check.Width + HOR_DIST);
		key_presence_label.Size = new Size(control_width, SYMB_HEIGHT);
		key_presence_label.Top = key_check.Top;
		key_presence_label.Left = key_check.Left + HOR_DIST;
		key_presence_label.Text = "Do you have a key to decrypt with?";

		Controls.Add(key_presence_label);
	}
}
