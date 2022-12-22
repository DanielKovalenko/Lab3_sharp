
namespace Lab3_sharp.View
{
    partial class WorkerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWorkName = new System.Windows.Forms.TextBox();
            this.tbWorkSur = new System.Windows.Forms.TextBox();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.tbWorkSalary = new System.Windows.Forms.TextBox();
            this.btAddWorker = new System.Windows.Forms.Button();
            this.lbxWorkers = new System.Windows.Forms.ListBox();
            this.btRemoveWorker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(551, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(551, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(551, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(551, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID";
            // 
            // tbWorkName
            // 
            this.tbWorkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWorkName.Location = new System.Drawing.Point(657, 133);
            this.tbWorkName.Name = "tbWorkName";
            this.tbWorkName.Size = new System.Drawing.Size(193, 23);
            this.tbWorkName.TabIndex = 6;
            // 
            // tbWorkSur
            // 
            this.tbWorkSur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWorkSur.Location = new System.Drawing.Point(657, 193);
            this.tbWorkSur.Name = "tbWorkSur";
            this.tbWorkSur.Size = new System.Drawing.Size(193, 23);
            this.tbWorkSur.TabIndex = 7;
            // 
            // numId
            // 
            this.numId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numId.Location = new System.Drawing.Point(657, 86);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(120, 23);
            this.numId.TabIndex = 10;
            // 
            // tbWorkSalary
            // 
            this.tbWorkSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWorkSalary.Location = new System.Drawing.Point(657, 252);
            this.tbWorkSalary.Name = "tbWorkSalary";
            this.tbWorkSalary.Size = new System.Drawing.Size(193, 23);
            this.tbWorkSalary.TabIndex = 11;
            // 
            // btAddWorker
            // 
            this.btAddWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddWorker.Location = new System.Drawing.Point(556, 393);
            this.btAddWorker.Name = "btAddWorker";
            this.btAddWorker.Size = new System.Drawing.Size(144, 80);
            this.btAddWorker.TabIndex = 12;
            this.btAddWorker.Text = "Додати працівника";
            this.btAddWorker.UseVisualStyleBackColor = true;
            // 
            // lbxWorkers
            // 
            this.lbxWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxWorkers.FormattingEnabled = true;
            this.lbxWorkers.ItemHeight = 20;
            this.lbxWorkers.Location = new System.Drawing.Point(12, 68);
            this.lbxWorkers.Name = "lbxWorkers";
            this.lbxWorkers.Size = new System.Drawing.Size(514, 404);
            this.lbxWorkers.TabIndex = 13;
            // 
            // btRemoveWorker
            // 
            this.btRemoveWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRemoveWorker.Location = new System.Drawing.Point(748, 393);
            this.btRemoveWorker.Name = "btRemoveWorker";
            this.btRemoveWorker.Size = new System.Drawing.Size(144, 80);
            this.btRemoveWorker.TabIndex = 14;
            this.btRemoveWorker.Text = "Видалити працівника";
            this.btRemoveWorker.UseVisualStyleBackColor = true;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 553);
            this.Controls.Add(this.btRemoveWorker);
            this.Controls.Add(this.lbxWorkers);
            this.Controls.Add(this.btAddWorker);
            this.Controls.Add(this.tbWorkSalary);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.tbWorkSur);
            this.Controls.Add(this.tbWorkName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWorkName;
        private System.Windows.Forms.TextBox tbWorkSur;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.TextBox tbWorkSalary;
        private System.Windows.Forms.Button btAddWorker;
        private System.Windows.Forms.ListBox lbxWorkers;
        private System.Windows.Forms.Button btRemoveWorker;
    }
}