namespace CarrefourEssert
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bntCreateScene = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.voiture1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.feuRouge = new System.Windows.Forms.PictureBox();
            this.feuVert = new System.Windows.Forms.PictureBox();
            this.pietons = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feuRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feuVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pietons)).BeginInit();
            this.SuspendLayout();
            // 
            // bntCreateScene
            // 
            this.bntCreateScene.Location = new System.Drawing.Point(12, 80);
            this.bntCreateScene.Name = "bntCreateScene";
            this.bntCreateScene.Size = new System.Drawing.Size(213, 114);
            this.bntCreateScene.TabIndex = 0;
            this.bntCreateScene.Text = "Create Scene";
            this.bntCreateScene.UseVisualStyleBackColor = true;
            this.bntCreateScene.Click += new System.EventHandler(this.bntCreateScene_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarrefourEssert.Properties.Resources.Road;
            this.pictureBox1.Location = new System.Drawing.Point(443, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 227);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarrefourEssert.Properties.Resources.Road;
            this.pictureBox2.Location = new System.Drawing.Point(443, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 227);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // voiture1
            // 
            this.voiture1.Image = ((System.Drawing.Image)(resources.GetObject("voiture1.Image")));
            this.voiture1.Location = new System.Drawing.Point(500, 351);
            this.voiture1.Name = "voiture1";
            this.voiture1.Size = new System.Drawing.Size(49, 95);
            this.voiture1.TabIndex = 3;
            this.voiture1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // feuRouge
            // 
            this.feuRouge.Image = ((System.Drawing.Image)(resources.GetObject("feuRouge.Image")));
            this.feuRouge.Location = new System.Drawing.Point(551, 125);
            this.feuRouge.Name = "feuRouge";
            this.feuRouge.Size = new System.Drawing.Size(46, 69);
            this.feuRouge.TabIndex = 4;
            this.feuRouge.TabStop = false;
            // 
            // feuVert
            // 
            this.feuVert.Image = ((System.Drawing.Image)(resources.GetObject("feuVert.Image")));
            this.feuVert.Location = new System.Drawing.Point(551, 125);
            this.feuVert.Name = "feuVert";
            this.feuVert.Size = new System.Drawing.Size(46, 69);
            this.feuVert.TabIndex = 5;
            this.feuVert.TabStop = false;
            // 
            // pietons
            // 
            this.pietons.Image = ((System.Drawing.Image)(resources.GetObject("pietons.Image")));
            this.pietons.Location = new System.Drawing.Point(558, 85);
            this.pietons.Name = "pietons";
            this.pietons.Size = new System.Drawing.Size(39, 34);
            this.pietons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pietons.TabIndex = 6;
            this.pietons.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pietons);
            this.Controls.Add(this.feuVert);
            this.Controls.Add(this.feuRouge);
            this.Controls.Add(this.voiture1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bntCreateScene);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feuRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feuVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pietons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntCreateScene;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox voiture1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox feuRouge;
        private System.Windows.Forms.PictureBox feuVert;
        private System.Windows.Forms.PictureBox pietons;
    }
}

