using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_P4MiniTool
{
	public partial class FormConnect : Form
	{
		public FormConnect(string sv, string us, string pw, string ws, bool acon, bool achk)
		{
			InitializeComponent();

			this.tbServer.Text = sv;
			this.tbUser.Text = us;
			this.tbPassword.Text = pw;
			this.tbWorkspace.Text = ws;
			this.cbAutoConnect.Checked = acon;
			this.cbAutoCheckout.Checked = achk;
		}
	}
}
