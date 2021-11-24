
namespace projetBloc4Individuel.InterfaceGraphique.InterfaceSites
{
    partial class FormManageSites
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
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_creation_date = new System.Windows.Forms.Label();
            this.lbl_update_date = new System.Windows.Forms.Label();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.bt_addNew = new System.Windows.Forms.Button();
            this.bt_previous = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_finish = new System.Windows.Forms.Button();
            this.lbl_dateCreation = new System.Windows.Forms.Label();
            this.lbl_dateUpdate = new System.Windows.Forms.Label();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.grpBox_SiteManage = new System.Windows.Forms.GroupBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.grpBox_SiteManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(17, 67);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(34, 17);
            this.lbl_city.TabIndex = 0;
            this.lbl_city.Text = "Ville";
            this.lbl_city.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_creation_date
            // 
            this.lbl_creation_date.AutoSize = true;
            this.lbl_creation_date.Location = new System.Drawing.Point(17, 108);
            this.lbl_creation_date.Name = "lbl_creation_date";
            this.lbl_creation_date.Size = new System.Drawing.Size(113, 17);
            this.lbl_creation_date.TabIndex = 1;
            this.lbl_creation_date.Text = "Date de création";
            this.lbl_creation_date.Click += new System.EventHandler(this.lbl_creation_date_Click);
            // 
            // lbl_update_date
            // 
            this.lbl_update_date.AutoSize = true;
            this.lbl_update_date.Location = new System.Drawing.Point(17, 149);
            this.lbl_update_date.Name = "lbl_update_date";
            this.lbl_update_date.Size = new System.Drawing.Size(137, 17);
            this.lbl_update_date.TabIndex = 2;
            this.lbl_update_date.Text = "Date de modification";
            this.lbl_update_date.Click += new System.EventHandler(this.lbl_update_date_Click);
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(80, 64);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(353, 22);
            this.txt_ville.TabIndex = 3;
            // 
            // bt_addNew
            // 
            this.bt_addNew.Location = new System.Drawing.Point(504, 17);
            this.bt_addNew.Name = "bt_addNew";
            this.bt_addNew.Size = new System.Drawing.Size(124, 28);
            this.bt_addNew.TabIndex = 4;
            this.bt_addNew.Text = "Ajouter";
            this.bt_addNew.UseVisualStyleBackColor = true;
            this.bt_addNew.Click += new System.EventHandler(this.bt_addNew_Click);
            // 
            // bt_previous
            // 
            this.bt_previous.Location = new System.Drawing.Point(231, 267);
            this.bt_previous.Name = "bt_previous";
            this.bt_previous.Size = new System.Drawing.Size(124, 28);
            this.bt_previous.TabIndex = 5;
            this.bt_previous.Text = "Précédent";
            this.bt_previous.UseVisualStyleBackColor = true;
            this.bt_previous.Click += new System.EventHandler(this.bt_previous_Click);
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(361, 267);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(124, 28);
            this.bt_next.TabIndex = 6;
            this.bt_next.Text = "Suivant";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_finish
            // 
            this.bt_finish.Location = new System.Drawing.Point(542, 267);
            this.bt_finish.Name = "bt_finish";
            this.bt_finish.Size = new System.Drawing.Size(124, 28);
            this.bt_finish.TabIndex = 7;
            this.bt_finish.Text = "Fin";
            this.bt_finish.UseVisualStyleBackColor = true;
            this.bt_finish.Click += new System.EventHandler(this.bt_finish_Click);
            // 
            // lbl_dateCreation
            // 
            this.lbl_dateCreation.AutoSize = true;
            this.lbl_dateCreation.Location = new System.Drawing.Point(172, 108);
            this.lbl_dateCreation.Name = "lbl_dateCreation";
            this.lbl_dateCreation.Size = new System.Drawing.Size(0, 17);
            this.lbl_dateCreation.TabIndex = 8;
            // 
            // lbl_dateUpdate
            // 
            this.lbl_dateUpdate.AutoSize = true;
            this.lbl_dateUpdate.Location = new System.Drawing.Point(172, 149);
            this.lbl_dateUpdate.Name = "lbl_dateUpdate";
            this.lbl_dateUpdate.Size = new System.Drawing.Size(0, 17);
            this.lbl_dateUpdate.TabIndex = 9;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(504, 56);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(124, 28);
            this.bt_update.TabIndex = 10;
            this.bt_update.Text = "Modifier";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(504, 97);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(124, 28);
            this.bt_delete.TabIndex = 11;
            this.bt_delete.Text = "Supprimer";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(504, 138);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(124, 28);
            this.bt_save.TabIndex = 12;
            this.bt_save.Text = "Enregister";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // grpBox_SiteManage
            // 
            this.grpBox_SiteManage.Controls.Add(this.label2);
            this.grpBox_SiteManage.Controls.Add(this.label1);
            this.grpBox_SiteManage.Controls.Add(this.bt_save);
            this.grpBox_SiteManage.Controls.Add(this.bt_delete);
            this.grpBox_SiteManage.Controls.Add(this.lbl_dateUpdate);
            this.grpBox_SiteManage.Controls.Add(this.bt_update);
            this.grpBox_SiteManage.Controls.Add(this.lbl_dateCreation);
            this.grpBox_SiteManage.Controls.Add(this.bt_addNew);
            this.grpBox_SiteManage.Controls.Add(this.txt_ville);
            this.grpBox_SiteManage.Controls.Add(this.lbl_update_date);
            this.grpBox_SiteManage.Controls.Add(this.lbl_city);
            this.grpBox_SiteManage.Controls.Add(this.lbl_creation_date);
            this.grpBox_SiteManage.Location = new System.Drawing.Point(38, 34);
            this.grpBox_SiteManage.Name = "grpBox_SiteManage";
            this.grpBox_SiteManage.Size = new System.Drawing.Size(649, 190);
            this.grpBox_SiteManage.TabIndex = 14;
            this.grpBox_SiteManage.TabStop = false;
            this.grpBox_SiteManage.Text = "Gestion des sites";
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(58, 267);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(124, 28);
            this.bt_start.TabIndex = 15;
            this.bt_start.Text = "Début";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = ": ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = ": ";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(707, 310);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(13, 17);
            this.lbl_id.TabIndex = 16;
            this.lbl_id.Text = "-";
            // 
            // FormManageSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 336);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.grpBox_SiteManage);
            this.Controls.Add(this.bt_finish);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_previous);
            this.Name = "FormManageSites";
            this.Text = "Sites";
            this.Load += new System.EventHandler(this.FormManageSites_Load);
            this.grpBox_SiteManage.ResumeLayout(false);
            this.grpBox_SiteManage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_creation_date;
        private System.Windows.Forms.Label lbl_update_date;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.Button bt_addNew;
        private System.Windows.Forms.Button bt_previous;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_finish;
        private System.Windows.Forms.Label lbl_dateCreation;
        private System.Windows.Forms.Label lbl_dateUpdate;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.GroupBox grpBox_SiteManage;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_id;
    }
}