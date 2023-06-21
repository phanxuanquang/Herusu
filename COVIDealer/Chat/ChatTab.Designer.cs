﻿namespace COVIDealer
{
    partial class ChatTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChatArea = new System.Windows.Forms.RichTextBox();
            this.ChatGPTMode = new Guna.UI2.WinForms.Guna2Button();
            this.MainIcon = new System.Windows.Forms.PictureBox();
            this.InputBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SendButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ChatArea
            // 
            this.ChatArea.BackColor = System.Drawing.Color.White;
            this.ChatArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChatArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChatArea.Location = new System.Drawing.Point(0, 0);
            this.ChatArea.Margin = new System.Windows.Forms.Padding(2);
            this.ChatArea.Name = "ChatArea";
            this.ChatArea.ReadOnly = true;
            this.ChatArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatArea.Size = new System.Drawing.Size(1118, 688);
            this.ChatArea.TabIndex = 21;
            this.ChatArea.Text = "";
            // 
            // ChatGPTMode
            // 
            this.ChatGPTMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatGPTMode.Animated = true;
            this.ChatGPTMode.BorderRadius = 3;
            this.ChatGPTMode.CheckedState.FillColor = System.Drawing.Color.Green;
            this.ChatGPTMode.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ChatGPTMode.CheckedState.Parent = this.ChatGPTMode;
            this.ChatGPTMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChatGPTMode.CustomImages.Parent = this.ChatGPTMode;
            this.ChatGPTMode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(133)))), ((int)(((byte)(248)))));
            this.ChatGPTMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatGPTMode.ForeColor = System.Drawing.Color.White;
            this.ChatGPTMode.HoverState.Parent = this.ChatGPTMode;
            this.ChatGPTMode.Image = global::COVIDealer.Properties.Resources.ChatGPT;
            this.ChatGPTMode.Location = new System.Drawing.Point(1057, 696);
            this.ChatGPTMode.Name = "ChatGPTMode";
            this.ChatGPTMode.ShadowDecoration.Parent = this.ChatGPTMode;
            this.ChatGPTMode.Size = new System.Drawing.Size(58, 33);
            this.ChatGPTMode.TabIndex = 23;
            this.ChatGPTMode.Click += new System.EventHandler(this.ChatGPTMode_Click);
            // 
            // MainIcon
            // 
            this.MainIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainIcon.Image = global::COVIDealer.Properties.Resources.Main_Icon;
            this.MainIcon.Location = new System.Drawing.Point(257, 103);
            this.MainIcon.Name = "MainIcon";
            this.MainIcon.Size = new System.Drawing.Size(500, 500);
            this.MainIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainIcon.TabIndex = 22;
            this.MainIcon.TabStop = false;
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.Animated = true;
            this.InputBox.AutoScroll = true;
            this.InputBox.BackColor = System.Drawing.Color.Gainsboro;
            this.InputBox.BorderRadius = 5;
            this.InputBox.BorderThickness = 2;
            this.InputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputBox.DefaultText = "";
            this.InputBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputBox.DisabledState.Parent = this.InputBox;
            this.InputBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.InputBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputBox.FocusedState.Parent = this.InputBox;
            this.InputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.InputBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputBox.HoverState.Parent = this.InputBox;
            this.InputBox.IconLeft = global::COVIDealer.Properties.Resources.Text_Input;
            this.InputBox.Location = new System.Drawing.Point(6, 696);
            this.InputBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.InputBox.Name = "InputBox";
            this.InputBox.PasswordChar = '\0';
            this.InputBox.PlaceholderText = "Thắc mắc của bạn . . .";
            this.InputBox.SelectedText = "";
            this.InputBox.ShadowDecoration.Parent = this.InputBox;
            this.InputBox.Size = new System.Drawing.Size(975, 33);
            this.InputBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.InputBox.TabIndex = 20;
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Animated = true;
            this.SendButton.BorderRadius = 3;
            this.SendButton.CheckedState.FillColor = System.Drawing.Color.Green;
            this.SendButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.SendButton.CheckedState.Parent = this.SendButton;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.CustomImages.Parent = this.SendButton;
            this.SendButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(133)))), ((int)(((byte)(248)))));
            this.SendButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.HoverState.Parent = this.SendButton;
            this.SendButton.Image = global::COVIDealer.Properties.Resources.Send;
            this.SendButton.Location = new System.Drawing.Point(990, 696);
            this.SendButton.Name = "SendButton";
            this.SendButton.ShadowDecoration.Parent = this.SendButton;
            this.SendButton.Size = new System.Drawing.Size(58, 33);
            this.SendButton.TabIndex = 19;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ChatTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ChatGPTMode);
            this.Controls.Add(this.MainIcon);
            this.Controls.Add(this.ChatArea);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.SendButton);
            this.DoubleBuffered = true;
            this.Name = "ChatTab";
            this.Size = new System.Drawing.Size(1118, 739);
            ((System.ComponentModel.ISupportInitialize)(this.MainIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button SendButton;
        private Guna.UI2.WinForms.Guna2TextBox InputBox;
        private System.Windows.Forms.RichTextBox ChatArea;
        private System.Windows.Forms.PictureBox MainIcon;
        private Guna.UI2.WinForms.Guna2Button ChatGPTMode;
    }
}
