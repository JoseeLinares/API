
namespace APIS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button buttonRandomDog;
        private Button buttonRandomCountry;
        private Button buttonClear;
        private Button buttonSave;
        private PictureBox pictureBoxDog;
        private Label labelCountry;

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
            this.buttonRandomDog = new Button();
            this.buttonRandomCountry = new Button();
            this.buttonClear = new Button();
            this.buttonSave = new Button();
            this.pictureBoxDog = new PictureBox();
            this.labelCountry = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRandomDog
            // 
            this.buttonRandomDog.Location = new System.Drawing.Point(20, 20);
            this.buttonRandomDog.Name = "buttonRandomDog";
            this.buttonRandomDog.Size = new System.Drawing.Size(180, 30);
            this.buttonRandomDog.Text = "Obtener perro aleatorio";
            this.buttonRandomDog.UseVisualStyleBackColor = true;
            this.buttonRandomDog.Click += new System.EventHandler(this.buttonRandomDog_Click);
            // 
            // buttonRandomCountry
            // 
            this.buttonRandomCountry.Location = new System.Drawing.Point(210, 20);
            this.buttonRandomCountry.Name = "buttonRandomCountry";
            this.buttonRandomCountry.Size = new System.Drawing.Size(180, 30);
            this.buttonRandomCountry.Text = "Elegir país para tu perro";
            this.buttonRandomCountry.UseVisualStyleBackColor = true;
            this.buttonRandomCountry.Click += new System.EventHandler(this.buttonRandomCountry_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(400, 20);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.Text = "Borrar";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(510, 20);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBoxDog
            // 
            this.pictureBoxDog.Location = new System.Drawing.Point(20, 70);
            this.pictureBoxDog.Name = "pictureBoxDog";
            this.pictureBoxDog.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxDog.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(340, 120);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(0, 20);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(640, 400);
            this.Controls.Add(this.buttonRandomDog);
            this.Controls.Add(this.buttonRandomCountry);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBoxDog);
            this.Controls.Add(this.labelCountry);
            this.Name = "Form1";
            this.Text = "Perro y País Aleatorio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion
    }
}
