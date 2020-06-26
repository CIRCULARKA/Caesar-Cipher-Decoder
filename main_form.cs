using System.Windows.Forms;
using System.Drawing;

// Class that represents main window of the program
class MainForm : Form
{
	Point margin;

	Label input_label;
	Label key_input_text;
	Label key_presence_label;
	Label action_text;
	Label result_text;

	Button next_key;
	Button prev_key;

	TextBox usr_input;
	TextBox result;

	ComboBox actions;

	CheckBox key_check;

	NumericUpDown key_input;


	public MainForm()
	{
		//
		// Window size and style
		//
		margin = new Point(10, 10);
		FormBorderStyle = FormBorderStyle.FixedSingle;

		//
		// Header of the program
		//
		Icon = new Icon("resources\\main_icon.ico");
		Text = "Caesar's decryptor";

		//
		// Objects to input
		//

		const int VER_DIST = 3;
		const int SYMB_HEIGHT = 13;

		// Invitation label
		input_label = new Label();

		input_label.Location = margin;

		input_label.Size = new Size(this.Width - (margin.X * 3), SYMB_HEIGHT);

		input_label.Text = "Input string to encrypt/decrypt it:";

		Controls.Add(input_label);

		// Box for inputting string
		usr_input = new TextBox();

		usr_input.Top = input_label.Bottom + VER_DIST;
		usr_input.Left = margin.X;

		usr_input.Size = new Size(this.Width - (input_label.Left * 3), SYMB_HEIGHT);
		usr_input.BorderStyle = BorderStyle.FixedSingle;

		Controls.Add(usr_input);

		//
		// Key presence check
		//

		const int HOR_DIST = 2;

		// Checkbox for it
		key_check = new CheckBox();

		key_check.Top = usr_input.Bottom + VER_DIST;
		key_check.Left = margin.X;

		key_check.Size = new Size(SYMB_HEIGHT, SYMB_HEIGHT);
		key_check.FlatStyle = FlatStyle.Flat;

		Controls.Add(key_check);

		// Text for key presence check
		key_presence_label = new Label();

		key_presence_label.Top = key_check.Top;
		key_presence_label.Left = key_check.Right + HOR_DIST;

		int control_width = this.Width - ((key_check.Left * 2) + key_check.Width + HOR_DIST);
		key_presence_label.Size = new Size(control_width, SYMB_HEIGHT);

		key_presence_label.Text = "Do you have a key to decrypt with?";

		Controls.Add(key_presence_label);

		// Text for key input
		key_input_text = new Label();

		key_input_text.Top = key_check.Bottom + VER_DIST;
		key_input_text.Left = margin.X;

		key_input_text.Size = new Size(53, SYMB_HEIGHT);

		key_input_text.Text = "Input key:";

		Controls.Add(key_input_text);

		// Input box for key
		key_input = new NumericUpDown();

		key_input.Top = key_check.Bottom + VER_DIST;
		key_input.Left = key_input_text.Right + HOR_DIST;

		key_input.Width = this.Width - ((margin.X * 3) + key_input_text.Width + HOR_DIST);
		key_input.BorderStyle = BorderStyle.FixedSingle;

		key_input.Maximum = 127m;
		key_input.Enabled = false;

		Controls.Add(key_input);

		// Invitation to choice
		action_text = new Label();

		action_text.Top = key_input.Bottom + VER_DIST;
		action_text.Left = margin.X;

		action_text.Size = new Size(120, SYMB_HEIGHT);

		action_text.Text = "What you want to do?:";

		Controls.Add(action_text);

		// Action choice
		actions = new ComboBox();

		actions.Top = action_text.Top;
		actions.Left = action_text.Right + HOR_DIST;

		control_width = this.Width - ((margin.X * 3) + action_text.Width + HOR_DIST);
		actions.Size = new Size(control_width, SYMB_HEIGHT);
		actions.DropDownStyle = ComboBoxStyle.DropDownList;

		actions.Items.Add("Encrypt");
		actions.Items.Add("Decrypt");
		actions.SelectedIndex = 0;

		Controls.Add(actions);

		//
		// Output field
		//

		// Result label
		result_text = new Label();

		result_text.Top = action_text.Bottom + VER_DIST;
		result_text.Left = margin.X;

		control_width = this.Width - (margin.X * 3);
		result_text.Size = new Size(control_width, SYMB_HEIGHT);

		result_text.Text = "Result:";

		Controls.Add(result_text);

		// Disabled text box with output
		result = new TextBox();

		result.Top = result_text.Bottom + VER_DIST;
		result.Left = margin.X;

		result.Width = this.Width - (margin.X * 3);
		result.ReadOnly = true;
		result.BorderStyle = BorderStyle.FixedSingle;

		Controls.Add(result);

		//
		// Buttons
		//

		// Next key button
		next_key = new Button();

		next_key.Top = result.Bottom + VER_DIST;
		next_key.Left = margin.X;

		next_key.Width = this.Width - (margin.X * 3);

		next_key.Text = "Try next key >>";
		next_key.Enabled = false;

		Controls.Add(next_key);

		// Previous key button
		prev_key = new Button();

		prev_key.Top = next_key.Bottom + VER_DIST;
		prev_key.Left = margin.X;

		prev_key.Width = this.Width - (margin.X * 3);

		prev_key.Text = "<< Previous key";
		prev_key.Enabled = false;

		Controls.Add(prev_key);

		this.Size = new Size(input_label.Right + (margin.X * 2), prev_key.Bottom + (margin.Y * 2) + prev_key.Height);

		//
		// Triggers
		//

		// Input key field must be disabled when checkbox above it is unchecked
		// The same is for buttons for key guessing
		key_check.CheckedChanged += KeyPresenceChanged;

		// Displaying result of encrypting/dectypting when user enters text in usr_input
		// usr_input.TextChanged += UserInputChanged;
	}

	void KeyPresenceChanged(object s, System.EventArgs e)
	{
		key_input.Enabled = !key_input.Enabled;

		next_key.Enabled = !next_key.Enabled;
		prev_key.Enabled = !prev_key.Enabled;
	}
}
