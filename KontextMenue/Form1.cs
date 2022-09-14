namespace KontextMenue
{
    public partial class Form1 : Form
    {
        private double endeZeit;
        public Form1()
        {
            InitializeComponent();
            StsLblDisplay.Text = DateTime.Today.ToShortDateString();
        }

        private void ContextMenuItem_Click(object sender, EventArgs e)
        {
            var itemName = (sender as ToolStripMenuItem).Name;

            switch (itemName)
            {
                case "readOnlyToolStripMenuItem":
                    TxtInput.ReadOnly = !TxtInput.ReadOnly;
                    readOnlyToolStripMenuItem.Checked = !readOnlyToolStripMenuItem.Checked;

                    MessageBox.Show(itemName);
                    break;

                case "multilineToolStripMenuItem":
                    TxtInput.Multiline = !TxtInput.Multiline;
                    if (TxtInput.Multiline)
                        TxtInput.ScrollBars = ScrollBars.Vertical;
                    else
                        TxtInput.ScrollBars = ScrollBars.None;
                    multilineToolStripMenuItem.Checked = !multilineToolStripMenuItem.Checked;

                    MessageBox.Show(itemName);
                    break;
            }
        }

        private void MnuFett_Click(object sender, EventArgs e)
        {
            MnuFett.Checked = !MnuFett.Checked;
            LblDisplay.Font = new Font(
                LblDisplay.Font.FontFamily, LblDisplay.Font.Size,
                LblDisplay.Font.Style ^ FontStyle.Bold);
        }

        private void MnuKursiv_Click(object sender, EventArgs e)
        {
            MnuKursiv.Checked = !MnuKursiv.Checked;
            LblDisplay.Font = new Font(
                LblDisplay.Font.FontFamily, LblDisplay.Font.Size,
                LblDisplay.Font.Style ^ FontStyle.Italic);
        }

        private void CboxTextSize_TextChanged(object sender, EventArgs e)
        {
            double schriftgroesse;
            ToolStripComboBox cb = sender as ToolStripComboBox;
            try
            {
                schriftgroesse = Convert.ToDouble(cb.Text);
            }
            catch
            {
                schriftgroesse = 8.25;
            }
            CboxTextSize.Text = "" + schriftgroesse;
            LblDisplay.Font = new Font(LblDisplay.Font.FontFamily,
            (float)schriftgroesse, LblDisplay.Font.Style);
        }

        private void TimerEnde_Tick(object sender, EventArgs e)
        {
            endeZeit += 1;
            if (endeZeit >= 100)
                Close();
            else
                StsPrgBar.Value = (int)endeZeit;
        }

        private void MnuBeenden_Click(object sender, EventArgs e)
        {
            endeZeit = 0;
            TimerEnde.Enabled = true;
        }
    }
}