namespace SDChat
{
    partial class Form1
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
            this.textChat = new System.Windows.Forms.TextBox();
            this.textInput = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRooms = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonNick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textChat
            // 
            this.textChat.Location = new System.Drawing.Point(18, 13);
            this.textChat.Multiline = true;
            this.textChat.Name = "textChat";
            this.textChat.Size = new System.Drawing.Size(498, 335);
            this.textChat.TabIndex = 0;
            this.textChat.TextChanged += new System.EventHandler(this.textChat_TextChanged);
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(18, 356);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(417, 20);
            this.textInput.TabIndex = 1;
            this.textInput.TextChanged += new System.EventHandler(this.textInput_TextChanged);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(441, 354);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Enviar";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(537, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 278);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonRooms
            // 
            this.buttonRooms.Location = new System.Drawing.Point(537, 40);
            this.buttonRooms.Name = "buttonRooms";
            this.buttonRooms.Size = new System.Drawing.Size(83, 23);
            this.buttonRooms.TabIndex = 4;
            this.buttonRooms.Text = "Salas";
            this.buttonRooms.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(626, 40);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(81, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonNick
            // 
            this.buttonNick.Location = new System.Drawing.Point(652, 11);
            this.buttonNick.Name = "buttonNick";
            this.buttonNick.Size = new System.Drawing.Size(55, 23);
            this.buttonNick.TabIndex = 6;
            this.buttonNick.Text = "Cambiar";
            this.buttonNick.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nick:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNick);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRooms);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.textChat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textChat;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRooms;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonNick;
        private System.Windows.Forms.Label label1;
    }
}

