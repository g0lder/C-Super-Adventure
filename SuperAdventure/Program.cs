namespace Super_Adventure;

partial class SuperAdventure
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        lblHealth = new System.Windows.Forms.Label();
        lblGold = new System.Windows.Forms.Label();
        lblXP = new System.Windows.Forms.Label();
        lblLevel = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        cboWeapons = new System.Windows.Forms.ComboBox();
        cboPotions = new System.Windows.Forms.ComboBox();
        btnNorth = new System.Windows.Forms.Button();
        btnEast = new System.Windows.Forms.Button();
        btnUseWeapon = new System.Windows.Forms.Button();
        btnWest = new System.Windows.Forms.Button();
        btnSouth = new System.Windows.Forms.Button();
        btnUsePotion = new System.Windows.Forms.Button();
        rtbLocation = new System.Windows.Forms.RichTextBox();
        rtbMessages = new System.Windows.Forms.RichTextBox();
        dgvInventory = new System.Windows.Forms.DataGridView();
        dgvQuests = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvQuests).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(18, 20);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(92, 26);
        label1.TabIndex = 0;
        label1.Text = "Health: ";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(18, 46);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(92, 28);
        label2.TabIndex = 1;
        label2.Text = "Gold: ";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(18, 74);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(92, 26);
        label3.TabIndex = 2;
        label3.Text = "XP:";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(18, 100);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(92, 28);
        label4.TabIndex = 3;
        label4.Text = "Level: ";
        // 
        // lblHealth
        // 
        lblHealth.Location = new System.Drawing.Point(110, 19);
        lblHealth.Name = "lblHealth";
        lblHealth.Size = new System.Drawing.Size(92, 26);
        lblHealth.TabIndex = 4;
        // 
        // lblGold
        // 
        lblGold.Location = new System.Drawing.Point(110, 45);
        lblGold.Name = "lblGold";
        lblGold.Size = new System.Drawing.Size(92, 28);
        lblGold.TabIndex = 5;
        // 
        // lblXP
        // 
        lblXP.Location = new System.Drawing.Point(110, 73);
        lblXP.Name = "lblXP";
        lblXP.Size = new System.Drawing.Size(92, 26);
        lblXP.TabIndex = 6;
        // 
        // lblLevel
        // 
        lblLevel.Location = new System.Drawing.Point(110, 99);
        lblLevel.Name = "lblLevel";
        lblLevel.Size = new System.Drawing.Size(92, 28);
        lblLevel.TabIndex = 7;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(617, 531);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(92, 26);
        label5.TabIndex = 8;
        label5.Text = "Select Action";
        // 
        // cboWeapons
        // 
        cboWeapons.FormattingEnabled = true;
        cboWeapons.Location = new System.Drawing.Point(369, 559);
        cboWeapons.Name = "cboWeapons";
        cboWeapons.Size = new System.Drawing.Size(245, 23);
        cboWeapons.TabIndex = 9;
        // 
        // cboPotions
        // 
        cboPotions.FormattingEnabled = true;
        cboPotions.Location = new System.Drawing.Point(369, 593);
        cboPotions.Name = "cboPotions";
        cboPotions.Size = new System.Drawing.Size(245, 23);
        cboPotions.TabIndex = 10;
        // 
        // btnNorth
        // 
        btnNorth.Location = new System.Drawing.Point(493, 433);
        btnNorth.Name = "btnNorth";
        btnNorth.Size = new System.Drawing.Size(60, 26);
        btnNorth.TabIndex = 11;
        btnNorth.Text = "North";
        btnNorth.UseVisualStyleBackColor = true;
        btnNorth.Click += btnNorth_Click;
        // 
        // btnEast
        // 
        btnEast.Location = new System.Drawing.Point(573, 457);
        btnEast.Name = "btnEast";
        btnEast.Size = new System.Drawing.Size(60, 26);
        btnEast.TabIndex = 12;
        btnEast.Text = "East";
        btnEast.UseVisualStyleBackColor = true;
        // 
        // btnUseWeapon
        // 
        btnUseWeapon.Location = new System.Drawing.Point(620, 559);
        btnUseWeapon.Name = "btnUseWeapon";
        btnUseWeapon.Size = new System.Drawing.Size(92, 26);
        btnUseWeapon.TabIndex = 13;
        btnUseWeapon.Text = "Use";
        btnUseWeapon.UseVisualStyleBackColor = true;
        btnUseWeapon.Click += btnUseWeapon_Click;
        // 
        // btnWest
        // 
        btnWest.Location = new System.Drawing.Point(412, 457);
        btnWest.Name = "btnWest";
        btnWest.Size = new System.Drawing.Size(60, 26);
        btnWest.TabIndex = 14;
        btnWest.Text = "West";
        btnWest.UseVisualStyleBackColor = true;
        // 
        // btnSouth
        // 
        btnSouth.Location = new System.Drawing.Point(493, 487);
        btnSouth.Name = "btnSouth";
        btnSouth.Size = new System.Drawing.Size(61, 26);
        btnSouth.TabIndex = 15;
        btnSouth.Text = "South";
        btnSouth.UseVisualStyleBackColor = true;
        // 
        // btnUsePotion
        // 
        btnUsePotion.Location = new System.Drawing.Point(620, 593);
        btnUsePotion.Name = "btnUsePotion";
        btnUsePotion.Size = new System.Drawing.Size(92, 26);
        btnUsePotion.TabIndex = 16;
        btnUsePotion.Text = "Use";
        btnUsePotion.UseVisualStyleBackColor = true;
        btnUsePotion.Click += btnUsePotion_Click;
        // 
        // rtbLocation
        // 
        rtbLocation.Location = new System.Drawing.Point(347, 19);
        rtbLocation.Name = "rtbLocation";
        rtbLocation.ReadOnly = true;
        rtbLocation.Size = new System.Drawing.Size(360, 105);
        rtbLocation.TabIndex = 17;
        rtbLocation.Text = "";
        // 
        // rtbMessages
        // 
        rtbMessages.Location = new System.Drawing.Point(347, 130);
        rtbMessages.Name = "rtbMessages";
        rtbMessages.ReadOnly = true;
        rtbMessages.Size = new System.Drawing.Size(360, 286);
        rtbMessages.TabIndex = 18;
        rtbMessages.Text = "";
        // 
        // dgvInventory
        // 
        dgvInventory.AllowUserToAddRows = false;
        dgvInventory.AllowUserToDeleteRows = false;
        dgvInventory.AllowUserToResizeColumns = false;
        dgvInventory.AllowUserToResizeRows = false;
        dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
        dgvInventory.Enabled = false;
        dgvInventory.Location = new System.Drawing.Point(16, 130);
        dgvInventory.MultiSelect = false;
        dgvInventory.Name = "dgvInventory";
        dgvInventory.ReadOnly = true;
        dgvInventory.RowHeadersVisible = false;
        dgvInventory.Size = new System.Drawing.Size(312, 309);
        dgvInventory.TabIndex = 19;
        dgvInventory.Text = "dataGridView1";
        // 
        // dgvQuests
        // 
        dgvQuests.AllowUserToAddRows = false;
        dgvQuests.AllowUserToDeleteRows = false;
        dgvQuests.AllowUserToResizeColumns = false;
        dgvQuests.AllowUserToResizeRows = false;
        dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
        dgvQuests.Enabled = false;
        dgvQuests.Location = new System.Drawing.Point(16, 446);
        dgvQuests.MultiSelect = false;
        dgvQuests.Name = "dgvQuests";
        dgvQuests.ReadOnly = true;
        dgvQuests.RowHeadersVisible = false;
        dgvQuests.Size = new System.Drawing.Size(312, 189);
        dgvQuests.TabIndex = 20;
        dgvQuests.Text = "dataGridView2";
        // 
        // SuperAdventure
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(719, 651);
        Controls.Add(dgvQuests);
        Controls.Add(dgvInventory);
        Controls.Add(rtbMessages);
        Controls.Add(rtbLocation);
        Controls.Add(btnUsePotion);
        Controls.Add(btnSouth);
        Controls.Add(btnWest);
        Controls.Add(btnUseWeapon);
        Controls.Add(btnEast);
        Controls.Add(btnNorth);
        Controls.Add(cboPotions);
        Controls.Add(cboWeapons);
        Controls.Add(label5);
        Controls.Add(lblLevel);
        Controls.Add(lblXP);
        Controls.Add(lblGold);
        Controls.Add(lblHealth);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "RPG Adventure";
        ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvQuests).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dgvInventory;
    private System.Windows.Forms.DataGridView dgvQuests;

    private System.Windows.Forms.RichTextBox rtbLocation;
    private System.Windows.Forms.RichTextBox rtbMessages;

    private System.Windows.Forms.Button btnNorth;
    private System.Windows.Forms.Button btnEast;
    private System.Windows.Forms.Button btnUseWeapon;
    private System.Windows.Forms.Button btnWest;
    private System.Windows.Forms.Button btnSouth;
    private System.Windows.Forms.Button btnUsePotion;

    private System.Windows.Forms.ComboBox cboWeapons;
    private System.Windows.Forms.ComboBox cboPotions;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblHealth;
    private System.Windows.Forms.Label lblGold;
    private System.Windows.Forms.Label lblXP;
    private System.Windows.Forms.Label lblLevel;

    #endregion
}
