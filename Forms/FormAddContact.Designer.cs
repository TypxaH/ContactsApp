
namespace ContactsApp
{
    partial class FormAddContact
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
            labelName = new Label();
            labelPhone = new Label();
            textBoxName = new TextBox();
            textBoxPhone = new TextBox();
            buttonAddContact = new Button();
            buttonCancelAddContact = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(25, 32);
            labelName.Margin = new Padding(5, 0, 5, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(70, 35);
            labelName.TabIndex = 0;
            labelName.Text = "Име:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(25, 77);
            labelPhone.Margin = new Padding(5, 0, 5, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(118, 35);
            labelPhone.TabIndex = 1;
            labelPhone.Text = "Телефон:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(153, 26);
            textBoxName.Margin = new Padding(5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(382, 41);
            textBoxName.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(153, 77);
            textBoxPhone.Margin = new Padding(5);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(382, 41);
            textBoxPhone.TabIndex = 3;
            // 
            // buttonAddContact
            // 
            buttonAddContact.Location = new Point(25, 142);
            buttonAddContact.Margin = new Padding(5);
            buttonAddContact.Name = "buttonAddContact";
            buttonAddContact.Size = new Size(244, 51);
            buttonAddContact.TabIndex = 4;
            buttonAddContact.Text = "Добави";
            buttonAddContact.UseVisualStyleBackColor = true;
            buttonAddContact.Click += buttonAddContact_Click;
            // 
            // buttonCancelAddContact
            // 
            buttonCancelAddContact.Location = new Point(291, 142);
            buttonCancelAddContact.Margin = new Padding(5);
            buttonCancelAddContact.Name = "buttonCancelAddContact";
            buttonCancelAddContact.Size = new Size(244, 51);
            buttonCancelAddContact.TabIndex = 5;
            buttonCancelAddContact.Text = "Отказ";
            buttonCancelAddContact.UseVisualStyleBackColor = true;
            buttonCancelAddContact.Click += buttonCancelAddContact_Click;
            // 
            // FormAddContact
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(556, 218);
            Controls.Add(buttonCancelAddContact);
            Controls.Add(buttonAddContact);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxName);
            Controls.Add(labelPhone);
            Controls.Add(labelName);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddContact";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавяне на контакт";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label labelName;
        private Label labelPhone;
        private TextBox textBoxName;
        private TextBox textBoxPhone;
        private Button buttonAddContact;
        private Button buttonCancelAddContact;
    }
}