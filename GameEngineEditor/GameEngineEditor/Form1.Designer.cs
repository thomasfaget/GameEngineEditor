namespace GameEngineEditor
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
            this.editorPanel = new System.Windows.Forms.Panel();
            this.gamePropertiesPanel = new System.Windows.Forms.Panel();
            this.sceneComboBox = new System.Windows.Forms.ComboBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.filePanel = new System.Windows.Forms.Panel();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.ExportFileDialogBox = new System.Windows.Forms.SaveFileDialog();
            this.ImportFileDialogBox = new System.Windows.Forms.OpenFileDialog();
            this.sceneRemoveBtn = new System.Windows.Forms.Button();
            this.sceneAddBtn = new System.Windows.Forms.Button();
            this.gamePropTitle = new System.Windows.Forms.Label();
            this.scenePanel = new System.Windows.Forms.Panel();
            this.scenePanelTitle = new System.Windows.Forms.Label();
            this.entityPanel = new System.Windows.Forms.Panel();
            this.entityPanelLabel = new System.Windows.Forms.Label();
            this.entityComboBox = new System.Windows.Forms.ComboBox();
            this.entityRemoveBtn = new System.Windows.Forms.Button();
            this.entityAddBtn = new System.Windows.Forms.Button();
            this.componentPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.gameTitleTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightTextBow = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.sceneNameTextBox = new System.Windows.Forms.TextBox();
            this.sceneNameLabel = new System.Windows.Forms.Label();
            this.backgroundImgTextBox = new System.Windows.Forms.TextBox();
            this.backgroundImageLabel = new System.Windows.Forms.Label();
            this.entityNameTextBox = new System.Windows.Forms.TextBox();
            this.entityNameLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.renderCompPanel = new System.Windows.Forms.Panel();
            this.physicsCompPanel = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.positionCompPanel = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.velocityCompPanel = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.inputCompPanel = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.boxColliderCompPanel = new System.Windows.Forms.Panel();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.editorPanel.SuspendLayout();
            this.gamePropertiesPanel.SuspendLayout();
            this.filePanel.SuspendLayout();
            this.scenePanel.SuspendLayout();
            this.entityPanel.SuspendLayout();
            this.componentPanel.SuspendLayout();
            this.renderCompPanel.SuspendLayout();
            this.physicsCompPanel.SuspendLayout();
            this.positionCompPanel.SuspendLayout();
            this.velocityCompPanel.SuspendLayout();
            this.inputCompPanel.SuspendLayout();
            this.boxColliderCompPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editorPanel
            // 
            this.editorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editorPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.editorPanel.Controls.Add(this.gamePropertiesPanel);
            this.editorPanel.Controls.Add(this.scenePanel);
            this.editorPanel.Controls.Add(this.entityPanel);
            this.editorPanel.Controls.Add(this.componentPanel);
            this.editorPanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.editorPanel.Location = new System.Drawing.Point(1290, 5);
            this.editorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(285, 845);
            this.editorPanel.TabIndex = 1;
            // 
            // gamePropertiesPanel
            // 
            this.gamePropertiesPanel.BackColor = System.Drawing.Color.Transparent;
            this.gamePropertiesPanel.Controls.Add(this.heightTextBow);
            this.gamePropertiesPanel.Controls.Add(this.heightLabel);
            this.gamePropertiesPanel.Controls.Add(this.widthTextBox);
            this.gamePropertiesPanel.Controls.Add(this.widthLabel);
            this.gamePropertiesPanel.Controls.Add(this.gameTitleTextBox);
            this.gamePropertiesPanel.Controls.Add(this.gameTitleLabel);
            this.gamePropertiesPanel.Controls.Add(this.gamePropTitle);
            this.gamePropertiesPanel.ForeColor = System.Drawing.Color.White;
            this.gamePropertiesPanel.Location = new System.Drawing.Point(0, 0);
            this.gamePropertiesPanel.Name = "gamePropertiesPanel";
            this.gamePropertiesPanel.Size = new System.Drawing.Size(285, 119);
            this.gamePropertiesPanel.TabIndex = 0;
            // 
            // sceneComboBox
            // 
            this.sceneComboBox.FormattingEnabled = true;
            this.sceneComboBox.Location = new System.Drawing.Point(3, 53);
            this.sceneComboBox.Name = "sceneComboBox";
            this.sceneComboBox.Size = new System.Drawing.Size(201, 24);
            this.sceneComboBox.TabIndex = 0;
            this.sceneComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gamePanel.Location = new System.Drawing.Point(5, 130);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1280, 720);
            this.gamePanel.TabIndex = 2;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // filePanel
            // 
            this.filePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.filePanel.Controls.Add(this.exportBtn);
            this.filePanel.Controls.Add(this.importBtn);
            this.filePanel.Location = new System.Drawing.Point(5, 5);
            this.filePanel.Name = "filePanel";
            this.filePanel.Size = new System.Drawing.Size(1280, 119);
            this.filePanel.TabIndex = 3;
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.exportBtn.Location = new System.Drawing.Point(117, 10);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(101, 100);
            this.exportBtn.TabIndex = 1;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = false;
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.importBtn.Location = new System.Drawing.Point(10, 10);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(101, 100);
            this.importBtn.TabIndex = 0;
            this.importBtn.Text = "Import";
            this.importBtn.UseVisualStyleBackColor = false;
            // 
            // ExportFileDialogBox
            // 
            this.ExportFileDialogBox.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // ImportFileDialogBox
            // 
            this.ImportFileDialogBox.FileName = "openFileDialog1";
            // 
            // sceneRemoveBtn
            // 
            this.sceneRemoveBtn.ForeColor = System.Drawing.Color.Black;
            this.sceneRemoveBtn.Location = new System.Drawing.Point(245, 50);
            this.sceneRemoveBtn.Name = "sceneRemoveBtn";
            this.sceneRemoveBtn.Size = new System.Drawing.Size(30, 30);
            this.sceneRemoveBtn.TabIndex = 4;
            this.sceneRemoveBtn.Text = "-";
            this.sceneRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // sceneAddBtn
            // 
            this.sceneAddBtn.ForeColor = System.Drawing.Color.Black;
            this.sceneAddBtn.Location = new System.Drawing.Point(209, 50);
            this.sceneAddBtn.Name = "sceneAddBtn";
            this.sceneAddBtn.Size = new System.Drawing.Size(30, 30);
            this.sceneAddBtn.TabIndex = 3;
            this.sceneAddBtn.Text = "+";
            this.sceneAddBtn.UseVisualStyleBackColor = true;
            this.sceneAddBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // gamePropTitle
            // 
            this.gamePropTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gamePropTitle.BackColor = System.Drawing.Color.DimGray;
            this.gamePropTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePropTitle.Location = new System.Drawing.Point(1, 0);
            this.gamePropTitle.Margin = new System.Windows.Forms.Padding(0);
            this.gamePropTitle.Name = "gamePropTitle";
            this.gamePropTitle.Size = new System.Drawing.Size(285, 41);
            this.gamePropTitle.TabIndex = 0;
            this.gamePropTitle.Text = "GAME PROPERTIES";
            this.gamePropTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scenePanel
            // 
            this.scenePanel.BackColor = System.Drawing.Color.Transparent;
            this.scenePanel.Controls.Add(this.backgroundImgTextBox);
            this.scenePanel.Controls.Add(this.backgroundImageLabel);
            this.scenePanel.Controls.Add(this.sceneNameTextBox);
            this.scenePanel.Controls.Add(this.sceneNameLabel);
            this.scenePanel.Controls.Add(this.scenePanelTitle);
            this.scenePanel.Controls.Add(this.sceneComboBox);
            this.scenePanel.Controls.Add(this.sceneRemoveBtn);
            this.scenePanel.Controls.Add(this.sceneAddBtn);
            this.scenePanel.ForeColor = System.Drawing.Color.White;
            this.scenePanel.Location = new System.Drawing.Point(0, 125);
            this.scenePanel.Name = "scenePanel";
            this.scenePanel.Size = new System.Drawing.Size(285, 151);
            this.scenePanel.TabIndex = 1;
            // 
            // scenePanelTitle
            // 
            this.scenePanelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scenePanelTitle.BackColor = System.Drawing.Color.DimGray;
            this.scenePanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scenePanelTitle.Location = new System.Drawing.Point(0, 0);
            this.scenePanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.scenePanelTitle.Name = "scenePanelTitle";
            this.scenePanelTitle.Size = new System.Drawing.Size(285, 41);
            this.scenePanelTitle.TabIndex = 0;
            this.scenePanelTitle.Text = "SCENE";
            this.scenePanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scenePanelTitle.Click += new System.EventHandler(this.scenePanelTitle_Click);
            // 
            // entityPanel
            // 
            this.entityPanel.BackColor = System.Drawing.Color.Transparent;
            this.entityPanel.Controls.Add(this.entityNameTextBox);
            this.entityPanel.Controls.Add(this.entityPanelLabel);
            this.entityPanel.Controls.Add(this.entityNameLabel);
            this.entityPanel.Controls.Add(this.entityComboBox);
            this.entityPanel.Controls.Add(this.entityRemoveBtn);
            this.entityPanel.Controls.Add(this.entityAddBtn);
            this.entityPanel.ForeColor = System.Drawing.Color.White;
            this.entityPanel.Location = new System.Drawing.Point(0, 282);
            this.entityPanel.Name = "entityPanel";
            this.entityPanel.Size = new System.Drawing.Size(285, 122);
            this.entityPanel.TabIndex = 5;
            // 
            // entityPanelLabel
            // 
            this.entityPanelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entityPanelLabel.BackColor = System.Drawing.Color.DimGray;
            this.entityPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityPanelLabel.Location = new System.Drawing.Point(0, -3);
            this.entityPanelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.entityPanelLabel.Name = "entityPanelLabel";
            this.entityPanelLabel.Size = new System.Drawing.Size(285, 41);
            this.entityPanelLabel.TabIndex = 0;
            this.entityPanelLabel.Text = "ENTITY";
            this.entityPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entityComboBox
            // 
            this.entityComboBox.FormattingEnabled = true;
            this.entityComboBox.Location = new System.Drawing.Point(3, 53);
            this.entityComboBox.Name = "entityComboBox";
            this.entityComboBox.Size = new System.Drawing.Size(201, 24);
            this.entityComboBox.TabIndex = 0;
            // 
            // entityRemoveBtn
            // 
            this.entityRemoveBtn.ForeColor = System.Drawing.Color.Black;
            this.entityRemoveBtn.Location = new System.Drawing.Point(245, 50);
            this.entityRemoveBtn.Name = "entityRemoveBtn";
            this.entityRemoveBtn.Size = new System.Drawing.Size(30, 30);
            this.entityRemoveBtn.TabIndex = 4;
            this.entityRemoveBtn.Text = "-";
            this.entityRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // entityAddBtn
            // 
            this.entityAddBtn.ForeColor = System.Drawing.Color.Black;
            this.entityAddBtn.Location = new System.Drawing.Point(209, 50);
            this.entityAddBtn.Name = "entityAddBtn";
            this.entityAddBtn.Size = new System.Drawing.Size(30, 30);
            this.entityAddBtn.TabIndex = 3;
            this.entityAddBtn.Text = "+";
            this.entityAddBtn.UseVisualStyleBackColor = true;
            // 
            // componentPanel
            // 
            this.componentPanel.BackColor = System.Drawing.Color.Transparent;
            this.componentPanel.Controls.Add(this.label2);
            this.componentPanel.Controls.Add(this.comboBox3);
            this.componentPanel.Controls.Add(this.renderCompPanel);
            this.componentPanel.Controls.Add(this.boxColliderCompPanel);
            this.componentPanel.Controls.Add(this.inputCompPanel);
            this.componentPanel.Controls.Add(this.velocityCompPanel);
            this.componentPanel.Controls.Add(this.positionCompPanel);
            this.componentPanel.Controls.Add(this.physicsCompPanel);
            this.componentPanel.ForeColor = System.Drawing.Color.White;
            this.componentPanel.Location = new System.Drawing.Point(0, 410);
            this.componentPanel.Name = "componentPanel";
            this.componentPanel.Size = new System.Drawing.Size(285, 435);
            this.componentPanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "COMPONENT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(5, 53);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(272, 24);
            this.comboBox3.TabIndex = 0;
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.AutoSize = true;
            this.gameTitleLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.gameTitleLabel.Location = new System.Drawing.Point(14, 52);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(72, 18);
            this.gameTitleLabel.TabIndex = 1;
            this.gameTitleLabel.Text = "Game title";
            // 
            // gameTitleTextBox
            // 
            this.gameTitleTextBox.Location = new System.Drawing.Point(155, 50);
            this.gameTitleTextBox.Name = "gameTitleTextBox";
            this.gameTitleTextBox.Size = new System.Drawing.Size(100, 22);
            this.gameTitleTextBox.TabIndex = 2;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(69, 84);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(46, 22);
            this.widthTextBox.TabIndex = 4;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.ForeColor = System.Drawing.Color.Black;
            this.widthLabel.Location = new System.Drawing.Point(17, 86);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(46, 18);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width";
            // 
            // heightTextBow
            // 
            this.heightTextBow.Location = new System.Drawing.Point(209, 84);
            this.heightTextBow.Name = "heightTextBow";
            this.heightTextBow.Size = new System.Drawing.Size(46, 22);
            this.heightTextBow.TabIndex = 6;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.ForeColor = System.Drawing.Color.Black;
            this.heightLabel.Location = new System.Drawing.Point(154, 86);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(49, 18);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Height";
            // 
            // sceneNameTextBox
            // 
            this.sceneNameTextBox.Location = new System.Drawing.Point(154, 86);
            this.sceneNameTextBox.Name = "sceneNameTextBox";
            this.sceneNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.sceneNameTextBox.TabIndex = 8;
            // 
            // sceneNameLabel
            // 
            this.sceneNameLabel.AutoSize = true;
            this.sceneNameLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sceneNameLabel.ForeColor = System.Drawing.Color.Black;
            this.sceneNameLabel.Location = new System.Drawing.Point(13, 88);
            this.sceneNameLabel.Name = "sceneNameLabel";
            this.sceneNameLabel.Size = new System.Drawing.Size(83, 18);
            this.sceneNameLabel.TabIndex = 7;
            this.sceneNameLabel.Text = "Scene name";
            // 
            // backgroundImgTextBox
            // 
            this.backgroundImgTextBox.Location = new System.Drawing.Point(154, 114);
            this.backgroundImgTextBox.Name = "backgroundImgTextBox";
            this.backgroundImgTextBox.Size = new System.Drawing.Size(100, 22);
            this.backgroundImgTextBox.TabIndex = 10;
            // 
            // backgroundImageLabel
            // 
            this.backgroundImageLabel.AutoSize = true;
            this.backgroundImageLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundImageLabel.ForeColor = System.Drawing.Color.Black;
            this.backgroundImageLabel.Location = new System.Drawing.Point(13, 116);
            this.backgroundImageLabel.Name = "backgroundImageLabel";
            this.backgroundImageLabel.Size = new System.Drawing.Size(121, 18);
            this.backgroundImageLabel.TabIndex = 9;
            this.backgroundImageLabel.Text = "Background Image";
            // 
            // entityNameTextBox
            // 
            this.entityNameTextBox.Location = new System.Drawing.Point(154, 86);
            this.entityNameTextBox.Name = "entityNameTextBox";
            this.entityNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.entityNameTextBox.TabIndex = 12;
            // 
            // entityNameLabel
            // 
            this.entityNameLabel.AutoSize = true;
            this.entityNameLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityNameLabel.ForeColor = System.Drawing.Color.Black;
            this.entityNameLabel.Location = new System.Drawing.Point(13, 88);
            this.entityNameLabel.Name = "entityNameLabel";
            this.entityNameLabel.Size = new System.Drawing.Size(81, 18);
            this.entityNameLabel.TabIndex = 11;
            this.entityNameLabel.Text = "Entity name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(16, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(172, 22);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Enable this component";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // renderCompPanel
            // 
            this.renderCompPanel.Controls.Add(this.textBox15);
            this.renderCompPanel.Controls.Add(this.label17);
            this.renderCompPanel.Controls.Add(this.textBox14);
            this.renderCompPanel.Controls.Add(this.label16);
            this.renderCompPanel.Controls.Add(this.textBox13);
            this.renderCompPanel.Controls.Add(this.checkBox1);
            this.renderCompPanel.Controls.Add(this.label15);
            this.renderCompPanel.Location = new System.Drawing.Point(0, 80);
            this.renderCompPanel.Name = "renderCompPanel";
            this.renderCompPanel.Size = new System.Drawing.Size(285, 352);
            this.renderCompPanel.TabIndex = 15;
            // 
            // physicsCompPanel
            // 
            this.physicsCompPanel.Controls.Add(this.textBox12);
            this.physicsCompPanel.Controls.Add(this.label14);
            this.physicsCompPanel.Controls.Add(this.checkBox8);
            this.physicsCompPanel.Controls.Add(this.checkBox7);
            this.physicsCompPanel.Controls.Add(this.textBox11);
            this.physicsCompPanel.Controls.Add(this.label13);
            this.physicsCompPanel.Controls.Add(this.checkBox2);
            this.physicsCompPanel.Location = new System.Drawing.Point(0, 80);
            this.physicsCompPanel.Name = "physicsCompPanel";
            this.physicsCompPanel.Size = new System.Drawing.Size(285, 352);
            this.physicsCompPanel.TabIndex = 16;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(16, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(172, 22);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Enable this component";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // positionCompPanel
            // 
            this.positionCompPanel.Controls.Add(this.textBox10);
            this.positionCompPanel.Controls.Add(this.label12);
            this.positionCompPanel.Controls.Add(this.textBox9);
            this.positionCompPanel.Controls.Add(this.label11);
            this.positionCompPanel.Controls.Add(this.textBox8);
            this.positionCompPanel.Controls.Add(this.checkBox3);
            this.positionCompPanel.Controls.Add(this.label10);
            this.positionCompPanel.Location = new System.Drawing.Point(0, 80);
            this.positionCompPanel.Name = "positionCompPanel";
            this.positionCompPanel.Size = new System.Drawing.Size(285, 352);
            this.positionCompPanel.TabIndex = 16;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.Black;
            this.checkBox3.Location = new System.Drawing.Point(16, 12);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(172, 22);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Enable this component";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // velocityCompPanel
            // 
            this.velocityCompPanel.Controls.Add(this.textBox7);
            this.velocityCompPanel.Controls.Add(this.checkBox4);
            this.velocityCompPanel.Controls.Add(this.label9);
            this.velocityCompPanel.Location = new System.Drawing.Point(0, 80);
            this.velocityCompPanel.Name = "velocityCompPanel";
            this.velocityCompPanel.Size = new System.Drawing.Size(285, 352);
            this.velocityCompPanel.TabIndex = 17;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.Black;
            this.checkBox4.Location = new System.Drawing.Point(16, 12);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(172, 22);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Text = "Enable this component";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // inputCompPanel
            // 
            this.inputCompPanel.Controls.Add(this.textBox6);
            this.inputCompPanel.Controls.Add(this.checkBox5);
            this.inputCompPanel.Controls.Add(this.label8);
            this.inputCompPanel.Location = new System.Drawing.Point(0, 80);
            this.inputCompPanel.Name = "inputCompPanel";
            this.inputCompPanel.Size = new System.Drawing.Size(285, 352);
            this.inputCompPanel.TabIndex = 18;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.Black;
            this.checkBox5.Location = new System.Drawing.Point(16, 12);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(172, 22);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "Enable this component";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // boxColliderCompPanel
            // 
            this.boxColliderCompPanel.Controls.Add(this.textBox5);
            this.boxColliderCompPanel.Controls.Add(this.label7);
            this.boxColliderCompPanel.Controls.Add(this.textBox4);
            this.boxColliderCompPanel.Controls.Add(this.checkBox6);
            this.boxColliderCompPanel.Controls.Add(this.label6);
            this.boxColliderCompPanel.Location = new System.Drawing.Point(0, 80);
            this.boxColliderCompPanel.Name = "boxColliderCompPanel";
            this.boxColliderCompPanel.Size = new System.Drawing.Size(285, 352);
            this.boxColliderCompPanel.TabIndex = 19;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.Black;
            this.checkBox6.Location = new System.Drawing.Point(16, 12);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(172, 22);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "Enable this component";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(154, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Size X";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(155, 75);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Size Y";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(154, 47);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Input Tweaker";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(158, 49);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Max velocity";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(154, 47);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Position X";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(154, 75);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Position Y";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(154, 102);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(13, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Angular position";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(154, 45);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(13, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 18);
            this.label13.TabIndex = 17;
            this.label13.Text = "Masse";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.Black;
            this.checkBox7.Location = new System.Drawing.Point(16, 77);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(98, 22);
            this.checkBox7.TabIndex = 19;
            this.checkBox7.Text = "Use gravity";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ForeColor = System.Drawing.Color.Black;
            this.checkBox8.Location = new System.Drawing.Point(16, 105);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(119, 22);
            this.checkBox8.TabIndex = 20;
            this.checkBox8.Text = "Use air friction";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(154, 133);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(13, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 18);
            this.label14.TabIndex = 21;
            this.label14.Text = "Air friction tweaker";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(154, 47);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(13, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 18);
            this.label15.TabIndex = 13;
            this.label15.Text = "Image";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(154, 77);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(13, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 18);
            this.label16.TabIndex = 15;
            this.label16.Text = "Size X";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(154, 107);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 22);
            this.textBox15.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(13, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 18);
            this.label17.TabIndex = 17;
            this.label17.Text = "Size Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1582, 855);
            this.Controls.Add(this.filePanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.editorPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.editorPanel.ResumeLayout(false);
            this.gamePropertiesPanel.ResumeLayout(false);
            this.gamePropertiesPanel.PerformLayout();
            this.filePanel.ResumeLayout(false);
            this.scenePanel.ResumeLayout(false);
            this.scenePanel.PerformLayout();
            this.entityPanel.ResumeLayout(false);
            this.entityPanel.PerformLayout();
            this.componentPanel.ResumeLayout(false);
            this.renderCompPanel.ResumeLayout(false);
            this.renderCompPanel.PerformLayout();
            this.physicsCompPanel.ResumeLayout(false);
            this.physicsCompPanel.PerformLayout();
            this.positionCompPanel.ResumeLayout(false);
            this.positionCompPanel.PerformLayout();
            this.velocityCompPanel.ResumeLayout(false);
            this.velocityCompPanel.PerformLayout();
            this.inputCompPanel.ResumeLayout(false);
            this.inputCompPanel.PerformLayout();
            this.boxColliderCompPanel.ResumeLayout(false);
            this.boxColliderCompPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel editorPanel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel filePanel;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.SaveFileDialog ExportFileDialogBox;
        private System.Windows.Forms.Panel gamePropertiesPanel;
        private System.Windows.Forms.ComboBox sceneComboBox;
        private System.Windows.Forms.OpenFileDialog ImportFileDialogBox;
        private System.Windows.Forms.Button sceneRemoveBtn;
        private System.Windows.Forms.Button sceneAddBtn;
        private System.Windows.Forms.Label gamePropTitle;
        private System.Windows.Forms.Panel scenePanel;
        private System.Windows.Forms.Label scenePanelTitle;
        private System.Windows.Forms.Panel componentPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel entityPanel;
        private System.Windows.Forms.Label entityPanelLabel;
        private System.Windows.Forms.ComboBox entityComboBox;
        private System.Windows.Forms.Button entityRemoveBtn;
        private System.Windows.Forms.Button entityAddBtn;
        private System.Windows.Forms.TextBox heightTextBow;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox gameTitleTextBox;
        private System.Windows.Forms.Label gameTitleLabel;
        private System.Windows.Forms.TextBox backgroundImgTextBox;
        private System.Windows.Forms.Label backgroundImageLabel;
        private System.Windows.Forms.TextBox sceneNameTextBox;
        private System.Windows.Forms.Label sceneNameLabel;
        private System.Windows.Forms.TextBox entityNameTextBox;
        private System.Windows.Forms.Label entityNameLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel positionCompPanel;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel physicsCompPanel;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel renderCompPanel;
        private System.Windows.Forms.Panel boxColliderCompPanel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel inputCompPanel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel velocityCompPanel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label15;
    }
}

