namespace ConnorMcIntireA6
{
    partial class ExportForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chooseBtn = new Button();
            csvButton = new Button();
            jsonBtn = new Button();
            fileLbl = new Label();
            csvLbl = new Label();
            jsonLbl = new Label();
            totalLbl = new Label();
            updateBtn = new Button();
            SuspendLayout();
            // 
            // chooseBtn
            // 
            chooseBtn.Location = new Point(77, 349);
            chooseBtn.Name = "chooseBtn";
            chooseBtn.Size = new Size(92, 23);
            chooseBtn.TabIndex = 0;
            chooseBtn.Text = "Choose File";
            chooseBtn.UseVisualStyleBackColor = true;
            chooseBtn.Click += chooseBtn_Click;
            // 
            // csvButton
            // 
            csvButton.Location = new Point(257, 349);
            csvButton.Name = "csvButton";
            csvButton.Size = new Size(127, 23);
            csvButton.TabIndex = 1;
            csvButton.Text = "Export Data as CSV";
            csvButton.UseVisualStyleBackColor = true;
            csvButton.Visible = false;
            csvButton.Click += csvButton_Click;
            // 
            // jsonBtn
            // 
            jsonBtn.Location = new Point(472, 352);
            jsonBtn.Name = "jsonBtn";
            jsonBtn.Size = new Size(124, 23);
            jsonBtn.TabIndex = 2;
            jsonBtn.Text = "Export Data as JSON";
            jsonBtn.UseVisualStyleBackColor = true;
            jsonBtn.Visible = false;
            jsonBtn.Click += jsonBtn_Click;
            // 
            // fileLbl
            // 
            fileLbl.AutoSize = true;
            fileLbl.Location = new Point(102, 375);
            fileLbl.Name = "fileLbl";
            fileLbl.Size = new Size(38, 15);
            fileLbl.TabIndex = 3;
            fileLbl.Text = "label1";
            fileLbl.Visible = false;
            // 
            // csvLbl
            // 
            csvLbl.AutoSize = true;
            csvLbl.Location = new Point(299, 375);
            csvLbl.Name = "csvLbl";
            csvLbl.Size = new Size(38, 15);
            csvLbl.TabIndex = 4;
            csvLbl.Text = "label2";
            csvLbl.Visible = false;
            // 
            // jsonLbl
            // 
            jsonLbl.AutoSize = true;
            jsonLbl.Location = new Point(514, 378);
            jsonLbl.Name = "jsonLbl";
            jsonLbl.Size = new Size(38, 15);
            jsonLbl.TabIndex = 5;
            jsonLbl.Text = "label2";
            jsonLbl.Visible = false;
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Location = new Point(186, 43);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(128, 15);
            totalLbl.TabIndex = 6;
            totalLbl.Text = "Total Mapped Objects: ";
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(231, 67);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 7;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateBtn);
            Controls.Add(totalLbl);
            Controls.Add(jsonLbl);
            Controls.Add(csvLbl);
            Controls.Add(fileLbl);
            Controls.Add(jsonBtn);
            Controls.Add(csvButton);
            Controls.Add(chooseBtn);
            Name = "Form1";
            Text = "Connor McIntire Assignment 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseBtn;
        private Button csvButton;
        private Button jsonBtn;
        private Label fileLbl;
        private Label csvLbl;
        private Label jsonLbl;
        private Label totalLbl;
        private Button updateBtn;
    }
}