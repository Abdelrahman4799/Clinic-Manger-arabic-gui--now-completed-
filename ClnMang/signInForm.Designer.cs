namespace ClnMang
{
    partial class signInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signInForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.signInGroup = new System.Windows.Forms.GroupBox();
            this.signInGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // userTxt
            // 
            resources.ApplyResources(this.userTxt, "userTxt");
            this.userTxt.Name = "userTxt";
            // 
            // passTxt
            // 
            resources.ApplyResources(this.passTxt, "passTxt");
            this.passTxt.Name = "passTxt";
            // 
            // logInBtn
            // 
            resources.ApplyResources(this.logInBtn, "logInBtn");
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // signInGroup
            // 
            this.signInGroup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.signInGroup.Controls.Add(this.logInBtn);
            this.signInGroup.Controls.Add(this.label1);
            this.signInGroup.Controls.Add(this.passTxt);
            this.signInGroup.Controls.Add(this.label2);
            this.signInGroup.Controls.Add(this.userTxt);
            resources.ApplyResources(this.signInGroup, "signInGroup");
            this.signInGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signInGroup.Name = "signInGroup";
            this.signInGroup.TabStop = false;
            // 
            // signInForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.signInGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "signInForm";
            this.signInGroup.ResumeLayout(false);
            this.signInGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.GroupBox signInGroup;
    }
}

