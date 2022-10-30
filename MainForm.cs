namespace LowLevelClientPacket
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Program.ClientApplication.messageHandler += Notify;
        }

        private void settingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void sendPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacketSend form = new PacketSend();
            form.handler += Notify;
            form.Show();
        }

        void Notify(string Message)
        {
            Log.Items.Add($"[{DateTime.Now.ToString()}] {Message}");
        }

    }
}