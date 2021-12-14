
using PongServer.Util;

namespace PongServer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpServeurOperations = new System.Windows.Forms.GroupBox();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.grpServeurStatusLog = new System.Windows.Forms.GroupBox();
            this.dgvServeurStatusLog = new System.Windows.Forms.DataGridView();
            this.grpServerControl = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clmLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpServeurOperations.SuspendLayout();
            this.grpServeurStatusLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServeurStatusLog)).BeginInit();
            this.grpServerControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpServeurOperations
            // 
            this.grpServeurOperations.Controls.Add(this.btnStopServer);
            this.grpServeurOperations.Controls.Add(this.btnStartServer);
            this.grpServeurOperations.Location = new System.Drawing.Point(16, 15);
            this.grpServeurOperations.Margin = new System.Windows.Forms.Padding(4);
            this.grpServeurOperations.Name = "grpServeurOperations";
            this.grpServeurOperations.Padding = new System.Windows.Forms.Padding(4);
            this.grpServeurOperations.Size = new System.Drawing.Size(250, 151);
            this.grpServeurOperations.TabIndex = 0;
            this.grpServeurOperations.TabStop = false;
            this.grpServeurOperations.Text = "Server Operations";
            // 
            // btnStopServer
            // 
            this.btnStopServer.Enabled = false;
            this.btnStopServer.Location = new System.Drawing.Point(8, 100);
            this.btnStopServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(229, 44);
            this.btnStopServer.TabIndex = 2;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(8, 38);
            this.btnStartServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(229, 44);
            this.btnStartServer.TabIndex = 1;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // grpServeurStatusLog
            // 
            this.grpServeurStatusLog.Controls.Add(this.dgvServeurStatusLog);
            this.grpServeurStatusLog.Location = new System.Drawing.Point(286, 15);
            this.grpServeurStatusLog.Margin = new System.Windows.Forms.Padding(4);
            this.grpServeurStatusLog.Name = "grpServeurStatusLog";
            this.grpServeurStatusLog.Padding = new System.Windows.Forms.Padding(4);
            this.grpServeurStatusLog.Size = new System.Drawing.Size(1595, 981);
            this.grpServeurStatusLog.TabIndex = 1;
            this.grpServeurStatusLog.TabStop = false;
            this.grpServeurStatusLog.Text = "Serveur status log";
            // 
            // dgvServeurStatusLog
            // 
            this.dgvServeurStatusLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServeurStatusLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLevel,
            this.clmId,
            this.clmMessage});
            this.dgvServeurStatusLog.Location = new System.Drawing.Point(8, 38);
            this.dgvServeurStatusLog.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServeurStatusLog.Name = "dgvServeurStatusLog";
            this.dgvServeurStatusLog.RowHeadersWidth = 62;
            this.dgvServeurStatusLog.RowTemplate.Height = 33;
            this.dgvServeurStatusLog.Size = new System.Drawing.Size(1579, 935);
            this.dgvServeurStatusLog.TabIndex = 2;
            // 
            // grpServerControl
            // 
            this.grpServerControl.Controls.Add(this.comboBox1);
            this.grpServerControl.Location = new System.Drawing.Point(16, 174);
            this.grpServerControl.Margin = new System.Windows.Forms.Padding(4);
            this.grpServerControl.Name = "grpServerControl";
            this.grpServerControl.Padding = new System.Windows.Forms.Padding(4);
            this.grpServerControl.Size = new System.Drawing.Size(250, 198);
            this.grpServerControl.TabIndex = 2;
            this.grpServerControl.TabStop = false;
            this.grpServerControl.Text = "Server Control";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 40);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Items.Add(LogCategory.Debug.Value);
            // 
            // clmLevel
            // 
            this.clmLevel.HeaderText = "Level";
            this.clmLevel.MinimumWidth = 8;
            this.clmLevel.Name = "clmLevel";
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.MinimumWidth = 8;
            this.clmId.Name = "clmId";
            // 
            // clmMessage
            // 
            this.clmMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMessage.HeaderText = "Message";
            this.clmMessage.MinimumWidth = 8;
            this.clmMessage.Name = "clmMessage";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.grpServerControl);
            this.Controls.Add(this.grpServeurStatusLog);
            this.Controls.Add(this.grpServeurOperations);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.grpServeurOperations.ResumeLayout(false);
            this.grpServeurStatusLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServeurStatusLog)).EndInit();
            this.grpServerControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpServeurOperations;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.GroupBox grpServeurStatusLog;
        private System.Windows.Forms.DataGridView dgvServeurStatusLog;
        private System.Windows.Forms.GroupBox grpServerControl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMessage;
    }
}