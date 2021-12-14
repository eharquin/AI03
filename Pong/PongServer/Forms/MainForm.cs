using PongServer.Manager;
using PongServer.MyEventArgs;
using PongServer.Util;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongServer
{
    public partial class MainForm : Form
    {
        private Task _task;
        private CancellationTokenSource _cancellationTokenSource;

        private Server _server;
        private ManagerLogger _managerLogger;

        public LogCategory LogMode = LogCategory.Info;

        public MainForm()
        {
            _managerLogger = new ManagerLogger(LogMode);
            _managerLogger.NewLogMessageEvent += NewLogMessageEvent;
            InitializeComponent();
            _server = new Server(_managerLogger);
        }

        private void NewLogMessageEvent(object sender, LogMessageEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<LogMessageEventArgs>(NewLogMessageEvent), sender, e);
            }
            else
            {
                dgvServeurStatusLog.Rows.Add(new [] { e.LogMessage.LogCategory.Value, e.LogMessage.Id, e.LogMessage.Message });
            }
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;

            _cancellationTokenSource = new CancellationTokenSource();
            _task = new Task(_server.Run, _cancellationTokenSource.Token);
            _task.Start();
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            if (_task != null && _cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
                btnStartServer.Enabled = true;
                btnStopServer.Enabled = false;
            }
        }
    }
}
