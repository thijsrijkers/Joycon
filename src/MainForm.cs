using Joycon4CS;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace JoyConForm
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			drawOrigin = new Point(picture1.Width / 2, picture1.Height / 2);
			joycon = new Math3D.Math3D.Cube(200, 100, 20);

		}

		JoyconManager manager = new JoyconManager();

		Point drawOrigin;
		Math3D.Math3D.Cube joycon;

		private bool scanned = false;
		private bool trackMouse = false;

		private void buttonScan_Click(object sender, EventArgs e)
		{
			if(!scanned)
            {
				manager.Scan();
				UpdateDebug();
				InfoRefresh();
				manager.Start();

				timerUpdate.Enabled = true;
				scanned = true;
			}
		}

		private void UpdateDebug()
		{
			foreach (var con in manager.j)
			{
				con.debug_type = Joycon.DebugType.NONE;
			}
		}

		private void timerUpdate_Tick(object sender, EventArgs e)
		{
			manager.Update();
			InfoRefresh();
		}

		private void InfoRefresh()
		{
			if (manager.j.Count != 0)
			{
				var j = manager.j[0];

				joycon.InitializeCube();
				joycon.RotateX = (float)(j.GetVector().eulerAngles.Y * 180.0f / Math.PI);
				joycon.RotateY = (float)(j.GetVector().eulerAngles.Z * 180.0f / Math.PI);
				joycon.RotateZ = (float)(j.GetVector().eulerAngles.X * 180.0f / Math.PI);

				if(trackMouse)
                {
					MoveCursor((int)(j.GetVector().eulerAngles.Y * 180.0f / Math.PI) / 10, (int)(j.GetVector().eulerAngles.X * 180.0f / Math.PI) / 10);
                }
				
				picture1.Image = joycon.DrawCube(drawOrigin);
			}
		}

		private void MoveCursor(int x, int y)
        {
			this.Cursor = new Cursor(Cursor.Current.Handle);
			Cursor.Position = new Point(Cursor.Position.X - x, Cursor.Position.Y - y);
			Cursor.Clip = new Rectangle(this.Location, this.Size);
		}

        private void buttonMouseTrack_Click_1(object sender, EventArgs e)
        {
			if (!trackMouse)
			{
				trackMouse = true;
				return;
			}

			trackMouse = false;
		}
	}
}
