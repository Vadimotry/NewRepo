namespace CalendarApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateLabel = new System.Windows.Forms.Label();
            this.eventTextBox = new System.Windows.Forms.TextBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.clearDateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            

            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            

            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(18, 190);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(52, 17);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Дата:";
            

            this.eventTextBox.Location = new System.Drawing.Point(250, 40);
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.Size = new System.Drawing.Size(200, 20);
            this.eventTextBox.TabIndex = 2;
            

            this.addEventButton.Location = new System.Drawing.Point(456, 38);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(100, 23);
            this.addEventButton.TabIndex = 3;
            this.addEventButton.Text = "Добавить дело";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            

            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(250, 80);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(306, 160);
            this.eventsListBox.TabIndex = 4;
            

            this.deleteEventButton.Location = new System.Drawing.Point(456, 246);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(100, 23);
            this.deleteEventButton.TabIndex = 5;
            this.deleteEventButton.Text = "Удалить дело";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            

            this.clearDateButton.Location = new System.Drawing.Point(250, 246);
            this.clearDateButton.Name = "clearDateButton";
            this.clearDateButton.Size = new System.Drawing.Size(200, 23);
            this.clearDateButton.TabIndex = 6;
            this.clearDateButton.Text = "Очистить все дела на выбранную дату";
            this.clearDateButton.UseVisualStyleBackColor = true;
            this.clearDateButton.Click += new System.EventHandler(this.clearDateButton_Click);
            

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Новое дело:";
            

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Список дел:";
            

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearDateButton);
            this.Controls.Add(this.deleteEventButton);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.eventTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "MainForm";
            this.Text = "Календарь дел";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.Button deleteEventButton;
        private System.Windows.Forms.Button clearDateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}