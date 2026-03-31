namespace Task8
{
    partial class GameInfo
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelGame = new Label();
            labelResult = new Label();
            label2 = new Label();
            labelDiff = new Label();
            labelTimer = new Label();
            SuspendLayout();
            // 
            // labelGame
            // 
            labelGame.AutoSize = true;
            labelGame.Font = new Font("Roboto Condensed", 12F);
            labelGame.Location = new Point(3, 0);
            labelGame.Name = "labelGame";
            labelGame.Size = new Size(194, 24);
            labelGame.TabIndex = 0;
            labelGame.Text = "Игра 01.01.1970 00:00";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Roboto Condensed", 12F);
            labelResult.Location = new Point(3, 24);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(77, 24);
            labelResult.TabIndex = 1;
            labelResult.Text = "Победа:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 12F);
            label2.Location = new Point(220, 24);
            label2.Name = "label2";
            label2.Size = new Size(30, 24);
            label2.TabIndex = 2;
            label2.Text = "За";
            // 
            // labelDiff
            // 
            labelDiff.AutoSize = true;
            labelDiff.Font = new Font("Roboto Condensed", 12F);
            labelDiff.Location = new Point(256, 0);
            labelDiff.Name = "labelDiff";
            labelDiff.Size = new Size(58, 24);
            labelDiff.TabIndex = 3;
            labelDiff.Text = "Легко";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Roboto Condensed", 12F);
            labelTimer.Location = new Point(256, 24);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(55, 24);
            labelTimer.TabIndex = 4;
            labelTimer.Text = "00:00";
            // 
            // GameInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTimer);
            Controls.Add(labelDiff);
            Controls.Add(label2);
            Controls.Add(labelResult);
            Controls.Add(labelGame);
            Name = "GameInfo";
            Size = new Size(351, 57);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGame;
        private Label labelResult;
        private Label label2;
        private Label labelDiff;
        private Label labelTimer;
    }
}
