
namespace MorseCodeConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.copyInput = new System.Windows.Forms.Button();
            this.copyOutput = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.changeMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(12, 49);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Input.Size = new System.Drawing.Size(776, 119);
            this.Input.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(12, 284);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(776, 119);
            this.Output.TabIndex = 1;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(352, 207);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(97, 37);
            this.convert.TabIndex = 2;
            this.convert.Text = "KODIRAJ";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(632, 174);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "Izbriši";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // copyInput
            // 
            this.copyInput.Location = new System.Drawing.Point(713, 174);
            this.copyInput.Name = "copyInput";
            this.copyInput.Size = new System.Drawing.Size(75, 23);
            this.copyInput.TabIndex = 4;
            this.copyInput.Text = "Kopiraj";
            this.copyInput.UseVisualStyleBackColor = true;
            this.copyInput.Click += new System.EventHandler(this.copyInput_Click);
            // 
            // copyOutput
            // 
            this.copyOutput.Location = new System.Drawing.Point(713, 409);
            this.copyOutput.Name = "copyOutput";
            this.copyOutput.Size = new System.Drawing.Size(75, 23);
            this.copyOutput.TabIndex = 5;
            this.copyOutput.Text = "Kopiraj";
            this.copyOutput.UseVisualStyleBackColor = true;
            this.copyOutput.Click += new System.EventHandler(this.copyOutput_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(13, 30);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(119, 13);
            this.inputLabel.TabIndex = 6;
            this.inputLabel.Text = "Upiši tekst za kodiranje:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(13, 268);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(74, 13);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.Text = "Kodirani tekst:";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(589, 30);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(82, 13);
            this.modeLabel.TabIndex = 8;
            this.modeLabel.Text = "Vrsta pretvorbe:";
            // 
            // changeMode
            // 
            this.changeMode.Location = new System.Drawing.Point(677, 25);
            this.changeMode.Name = "changeMode";
            this.changeMode.Size = new System.Drawing.Size(111, 23);
            this.changeMode.TabIndex = 9;
            this.changeMode.Text = "KODIRANJE";
            this.changeMode.UseVisualStyleBackColor = true;
            this.changeMode.Click += new System.EventHandler(this.changeMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.changeMode);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.copyOutput);
            this.Controls.Add(this.copyInput);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kodiranje i dekodiranje morseovog koda | Leon Kušić";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button copyInput;
        private System.Windows.Forms.Button copyOutput;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Button changeMode;
    }
}

