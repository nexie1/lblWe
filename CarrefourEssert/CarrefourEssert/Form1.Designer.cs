﻿namespace CarrefourEssert
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
            this.bntCreateScene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntCreateScene
            // 
            this.bntCreateScene.Location = new System.Drawing.Point(119, 288);
            this.bntCreateScene.Name = "bntCreateScene";
            this.bntCreateScene.Size = new System.Drawing.Size(494, 114);
            this.bntCreateScene.TabIndex = 0;
            this.bntCreateScene.Text = "Create Scene";
            this.bntCreateScene.UseVisualStyleBackColor = true;
            this.bntCreateScene.Click += new System.EventHandler(this.bntCreateScene_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntCreateScene);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntCreateScene;
    }
}

