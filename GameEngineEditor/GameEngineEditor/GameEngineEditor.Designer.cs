namespace GameEngineEditor
{
    partial class GameEngineEditor
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
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.gameTitleTextBox = new System.Windows.Forms.TextBox();
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.gamePropTitle = new System.Windows.Forms.Label();
            this.scenePanel = new System.Windows.Forms.Panel();
            this.backgroundImgTextBox = new System.Windows.Forms.TextBox();
            this.backgroundImageLabel = new System.Windows.Forms.Label();
            this.sceneNameTextBox = new System.Windows.Forms.TextBox();
            this.sceneNameLabel = new System.Windows.Forms.Label();
            this.scenePanelTitle = new System.Windows.Forms.Label();
            this.sceneComboBox = new System.Windows.Forms.ComboBox();
            this.sceneRemoveBtn = new System.Windows.Forms.Button();
            this.sceneAddBtn = new System.Windows.Forms.Button();
            this.entityPanel = new System.Windows.Forms.Panel();
            this.entityNameTextBox = new System.Windows.Forms.TextBox();
            this.entityPanelLabel = new System.Windows.Forms.Label();
            this.entityNameLabel = new System.Windows.Forms.Label();
            this.entityComboBox = new System.Windows.Forms.ComboBox();
            this.entityRemoveBtn = new System.Windows.Forms.Button();
            this.entityAddBtn = new System.Windows.Forms.Button();
            this.componentPanel = new System.Windows.Forms.Panel();
            this.componentPanelTitle = new System.Windows.Forms.Label();
            this.componentComboBox = new System.Windows.Forms.ComboBox();
            this.renderCompPanel = new System.Windows.Forms.Panel();
            this.renderSizeYTextBox = new System.Windows.Forms.TextBox();
            this.renderSizeYLabel = new System.Windows.Forms.Label();
            this.renderSizeXTextBox = new System.Windows.Forms.TextBox();
            this.renderSizeXLabel = new System.Windows.Forms.Label();
            this.renderImageTextBox = new System.Windows.Forms.TextBox();
            this.renderEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.renderImageLabel = new System.Windows.Forms.Label();
            this.boxColliderCompPanel = new System.Windows.Forms.Panel();
            this.boxColliderSizeYTextBox = new System.Windows.Forms.TextBox();
            this.boxColliderSizeYLabel = new System.Windows.Forms.Label();
            this.boxColliderSizeXTextBox = new System.Windows.Forms.TextBox();
            this.boxColliderEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.boxColliderSizeXLabel = new System.Windows.Forms.Label();
            this.inputCompPanel = new System.Windows.Forms.Panel();
            this.inputTweakerTextBox = new System.Windows.Forms.TextBox();
            this.inputEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.inputTweakerLabel = new System.Windows.Forms.Label();
            this.velocityCompPanel = new System.Windows.Forms.Panel();
            this.velocityMaxTextBox = new System.Windows.Forms.TextBox();
            this.velocityEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.velocityMaxLabel = new System.Windows.Forms.Label();
            this.positionCompPanel = new System.Windows.Forms.Panel();
            this.positionAngularTextBox = new System.Windows.Forms.TextBox();
            this.positionAngularLabel = new System.Windows.Forms.Label();
            this.positionYTextBox = new System.Windows.Forms.TextBox();
            this.positionYLabel = new System.Windows.Forms.Label();
            this.positionXTextBox = new System.Windows.Forms.TextBox();
            this.positionEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.positionXLabel = new System.Windows.Forms.Label();
            this.physicsCompPanel = new System.Windows.Forms.Panel();
            this.physicsAirTweakerTextBox = new System.Windows.Forms.TextBox();
            this.physicsAirTweakerLabel = new System.Windows.Forms.Label();
            this.physicsAirFrictionCheckBox = new System.Windows.Forms.CheckBox();
            this.physicsGravityCheckBox = new System.Windows.Forms.CheckBox();
            this.physicsMasseTextBox = new System.Windows.Forms.TextBox();
            this.physicsMasseLabel = new System.Windows.Forms.Label();
            this.physicsEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.filePanel = new System.Windows.Forms.Panel();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.ExportFileDialogBox = new System.Windows.Forms.SaveFileDialog();
            this.ImportFileDialogBox = new System.Windows.Forms.OpenFileDialog();
            this.editorPanel.SuspendLayout();
            this.gamePropertiesPanel.SuspendLayout();
            this.scenePanel.SuspendLayout();
            this.entityPanel.SuspendLayout();
            this.componentPanel.SuspendLayout();
            this.renderCompPanel.SuspendLayout();
            this.boxColliderCompPanel.SuspendLayout();
            this.inputCompPanel.SuspendLayout();
            this.velocityCompPanel.SuspendLayout();
            this.positionCompPanel.SuspendLayout();
            this.physicsCompPanel.SuspendLayout();
            this.filePanel.SuspendLayout();
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
            this.gamePropertiesPanel.Controls.Add(this.heightTextBox);
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
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(209, 84);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(46, 22);
            this.heightTextBox.TabIndex = 6;
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
            // gameTitleTextBox
            // 
            this.gameTitleTextBox.Location = new System.Drawing.Point(155, 50);
            this.gameTitleTextBox.Name = "gameTitleTextBox";
            this.gameTitleTextBox.Size = new System.Drawing.Size(100, 22);
            this.gameTitleTextBox.TabIndex = 2;
            this.gameTitleTextBox.TextChanged += new System.EventHandler(this.gameTitleTextBox_TextChanged);
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
            // backgroundImgTextBox
            // 
            this.backgroundImgTextBox.Location = new System.Drawing.Point(154, 114);
            this.backgroundImgTextBox.Name = "backgroundImgTextBox";
            this.backgroundImgTextBox.Size = new System.Drawing.Size(100, 22);
            this.backgroundImgTextBox.TabIndex = 10;
            this.backgroundImgTextBox.TextChanged += new System.EventHandler(this.backgroundImgTextBox_TextChanged);
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
            // sceneNameTextBox
            // 
            this.sceneNameTextBox.Location = new System.Drawing.Point(154, 86);
            this.sceneNameTextBox.Name = "sceneNameTextBox";
            this.sceneNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.sceneNameTextBox.TabIndex = 8;
            this.sceneNameTextBox.TextChanged += new System.EventHandler(this.sceneNameTextBox_TextChanged);
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
            // sceneComboBox
            // 
            this.sceneComboBox.FormattingEnabled = true;
            this.sceneComboBox.Location = new System.Drawing.Point(3, 53);
            this.sceneComboBox.Name = "sceneComboBox";
            this.sceneComboBox.Size = new System.Drawing.Size(201, 24);
            this.sceneComboBox.TabIndex = 0;
            this.sceneComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            // entityNameTextBox
            // 
            this.entityNameTextBox.Location = new System.Drawing.Point(154, 86);
            this.entityNameTextBox.Name = "entityNameTextBox";
            this.entityNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.entityNameTextBox.TabIndex = 12;
            this.entityNameTextBox.TextChanged += new System.EventHandler(this.entityNameTextBox_TextChanged);
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
            // entityComboBox
            // 
            this.entityComboBox.FormattingEnabled = true;
            this.entityComboBox.Location = new System.Drawing.Point(3, 53);
            this.entityComboBox.Name = "entityComboBox";
            this.entityComboBox.Size = new System.Drawing.Size(201, 24);
            this.entityComboBox.TabIndex = 0;
            this.entityComboBox.SelectedIndexChanged += new System.EventHandler(this.entityComboBox_SelectedIndexChanged);
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
            this.componentPanel.Controls.Add(this.componentPanelTitle);
            this.componentPanel.Controls.Add(this.componentComboBox);
            this.componentPanel.Controls.Add(this.physicsCompPanel);
            this.componentPanel.Controls.Add(this.renderCompPanel);
            this.componentPanel.Controls.Add(this.boxColliderCompPanel);
            this.componentPanel.Controls.Add(this.inputCompPanel);
            this.componentPanel.Controls.Add(this.velocityCompPanel);
            this.componentPanel.Controls.Add(this.positionCompPanel);
            this.componentPanel.ForeColor = System.Drawing.Color.White;
            this.componentPanel.Location = new System.Drawing.Point(0, 410);
            this.componentPanel.Name = "componentPanel";
            this.componentPanel.Size = new System.Drawing.Size(285, 435);
            this.componentPanel.TabIndex = 6;
            // 
            // componentPanelTitle
            // 
            this.componentPanelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.componentPanelTitle.BackColor = System.Drawing.Color.DimGray;
            this.componentPanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.componentPanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.componentPanelTitle.Name = "componentPanelTitle";
            this.componentPanelTitle.Size = new System.Drawing.Size(285, 41);
            this.componentPanelTitle.TabIndex = 0;
            this.componentPanelTitle.Text = "COMPONENT";
            this.componentPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // componentComboBox
            // 
            this.componentComboBox.FormattingEnabled = true;
            this.componentComboBox.Items.AddRange(new object[] {
            "Input",
            "Physics",
            "BoxCollision",
            "Position",
            "Velocity",
            "Render"});
            this.componentComboBox.Location = new System.Drawing.Point(5, 53);
            this.componentComboBox.Name = "componentComboBox";
            this.componentComboBox.Size = new System.Drawing.Size(272, 24);
            this.componentComboBox.TabIndex = 0;
            this.componentComboBox.SelectedIndexChanged += new System.EventHandler(this.componentComboBox_SelectedIndexChanged);
            // 
            // renderCompPanel
            // 
            this.renderCompPanel.Controls.Add(this.renderSizeYTextBox);
            this.renderCompPanel.Controls.Add(this.renderSizeYLabel);
            this.renderCompPanel.Controls.Add(this.renderSizeXTextBox);
            this.renderCompPanel.Controls.Add(this.renderSizeXLabel);
            this.renderCompPanel.Controls.Add(this.renderImageTextBox);
            this.renderCompPanel.Controls.Add(this.renderEnableCheckBox);
            this.renderCompPanel.Controls.Add(this.renderImageLabel);
            this.renderCompPanel.Location = new System.Drawing.Point(0, 80);
            this.renderCompPanel.Name = "renderCompPanel";
            this.renderCompPanel.Size = new System.Drawing.Size(285, 352);
            this.renderCompPanel.TabIndex = 15;
            // 
            // renderSizeYTextBox
            // 
            this.renderSizeYTextBox.Location = new System.Drawing.Point(154, 107);
            this.renderSizeYTextBox.Name = "renderSizeYTextBox";
            this.renderSizeYTextBox.Size = new System.Drawing.Size(100, 22);
            this.renderSizeYTextBox.TabIndex = 18;
            // 
            // renderSizeYLabel
            // 
            this.renderSizeYLabel.AutoSize = true;
            this.renderSizeYLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renderSizeYLabel.ForeColor = System.Drawing.Color.Black;
            this.renderSizeYLabel.Location = new System.Drawing.Point(13, 109);
            this.renderSizeYLabel.Name = "renderSizeYLabel";
            this.renderSizeYLabel.Size = new System.Drawing.Size(43, 18);
            this.renderSizeYLabel.TabIndex = 17;
            this.renderSizeYLabel.Text = "Size Y";
            // 
            // renderSizeXTextBox
            // 
            this.renderSizeXTextBox.Location = new System.Drawing.Point(154, 77);
            this.renderSizeXTextBox.Name = "renderSizeXTextBox";
            this.renderSizeXTextBox.Size = new System.Drawing.Size(100, 22);
            this.renderSizeXTextBox.TabIndex = 16;
            // 
            // renderSizeXLabel
            // 
            this.renderSizeXLabel.AutoSize = true;
            this.renderSizeXLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renderSizeXLabel.ForeColor = System.Drawing.Color.Black;
            this.renderSizeXLabel.Location = new System.Drawing.Point(13, 79);
            this.renderSizeXLabel.Name = "renderSizeXLabel";
            this.renderSizeXLabel.Size = new System.Drawing.Size(44, 18);
            this.renderSizeXLabel.TabIndex = 15;
            this.renderSizeXLabel.Text = "Size X";
            // 
            // renderImageTextBox
            // 
            this.renderImageTextBox.Location = new System.Drawing.Point(154, 47);
            this.renderImageTextBox.Name = "renderImageTextBox";
            this.renderImageTextBox.Size = new System.Drawing.Size(100, 22);
            this.renderImageTextBox.TabIndex = 14;
            // 
            // renderEnableCheckBox
            // 
            this.renderEnableCheckBox.AutoSize = true;
            this.renderEnableCheckBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renderEnableCheckBox.ForeColor = System.Drawing.Color.Black;
            this.renderEnableCheckBox.Location = new System.Drawing.Point(16, 12);
            this.renderEnableCheckBox.Name = "renderEnableCheckBox";
            this.renderEnableCheckBox.Size = new System.Drawing.Size(172, 22);
            this.renderEnableCheckBox.TabIndex = 14;
            this.renderEnableCheckBox.Text = "Enable this component";
            this.renderEnableCheckBox.UseVisualStyleBackColor = true;
            this.renderEnableCheckBox.CheckedChanged += new System.EventHandler(this.renderEnableCheckBox_CheckedChanged);
            // 
            // renderImageLabel
            // 
            this.renderImageLabel.AutoSize = true;
            this.renderImageLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renderImageLabel.ForeColor = System.Drawing.Color.Black;
            this.renderImageLabel.Location = new System.Drawing.Point(13, 49);
            this.renderImageLabel.Name = "renderImageLabel";
            this.renderImageLabel.Size = new System.Drawing.Size(46, 18);
            this.renderImageLabel.TabIndex = 13;
            this.renderImageLabel.Text = "Image";
            // 
            // boxColliderCompPanel
            // 
            this.boxColliderCompPanel.Controls.Add(this.boxColliderSizeYTextBox);
            this.boxColliderCompPanel.Controls.Add(this.boxColliderSizeYLabel);
            this.boxColliderCompPanel.Controls.Add(this.boxColliderSizeXTextBox);
            this.boxColliderCompPanel.Controls.Add(this.boxColliderEnableCheckBox);
            this.boxColliderCompPanel.Controls.Add(this.boxColliderSizeXLabel);
            this.boxColliderCompPanel.Location = new System.Drawing.Point(0, 80);
            this.boxColliderCompPanel.Name = "boxColliderCompPanel";
            this.boxColliderCompPanel.Size = new System.Drawing.Size(285, 352);
            this.boxColliderCompPanel.TabIndex = 19;
            // 
            // boxColliderSizeYTextBox
            // 
            this.boxColliderSizeYTextBox.Location = new System.Drawing.Point(155, 75);
            this.boxColliderSizeYTextBox.Name = "boxColliderSizeYTextBox";
            this.boxColliderSizeYTextBox.Size = new System.Drawing.Size(100, 22);
            this.boxColliderSizeYTextBox.TabIndex = 16;
            // 
            // boxColliderSizeYLabel
            // 
            this.boxColliderSizeYLabel.AutoSize = true;
            this.boxColliderSizeYLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxColliderSizeYLabel.ForeColor = System.Drawing.Color.Black;
            this.boxColliderSizeYLabel.Location = new System.Drawing.Point(14, 77);
            this.boxColliderSizeYLabel.Name = "boxColliderSizeYLabel";
            this.boxColliderSizeYLabel.Size = new System.Drawing.Size(43, 18);
            this.boxColliderSizeYLabel.TabIndex = 15;
            this.boxColliderSizeYLabel.Text = "Size Y";
            // 
            // boxColliderSizeXTextBox
            // 
            this.boxColliderSizeXTextBox.Location = new System.Drawing.Point(154, 47);
            this.boxColliderSizeXTextBox.Name = "boxColliderSizeXTextBox";
            this.boxColliderSizeXTextBox.Size = new System.Drawing.Size(100, 22);
            this.boxColliderSizeXTextBox.TabIndex = 14;
            // 
            // boxColliderEnableCheckBox
            // 
            this.boxColliderEnableCheckBox.AutoSize = true;
            this.boxColliderEnableCheckBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxColliderEnableCheckBox.ForeColor = System.Drawing.Color.Black;
            this.boxColliderEnableCheckBox.Location = new System.Drawing.Point(16, 12);
            this.boxColliderEnableCheckBox.Name = "boxColliderEnableCheckBox";
            this.boxColliderEnableCheckBox.Size = new System.Drawing.Size(172, 22);
            this.boxColliderEnableCheckBox.TabIndex = 14;
            this.boxColliderEnableCheckBox.Text = "Enable this component";
            this.boxColliderEnableCheckBox.UseVisualStyleBackColor = true;
            this.boxColliderEnableCheckBox.CheckedChanged += new System.EventHandler(this.boxColliderEnableCheckBox_CheckedChanged);
            // 
            // boxColliderSizeXLabel
            // 
            this.boxColliderSizeXLabel.AutoSize = true;
            this.boxColliderSizeXLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxColliderSizeXLabel.ForeColor = System.Drawing.Color.Black;
            this.boxColliderSizeXLabel.Location = new System.Drawing.Point(13, 49);
            this.boxColliderSizeXLabel.Name = "boxColliderSizeXLabel";
            this.boxColliderSizeXLabel.Size = new System.Drawing.Size(44, 18);
            this.boxColliderSizeXLabel.TabIndex = 13;
            this.boxColliderSizeXLabel.Text = "Size X";
            // 
            // inputCompPanel
            // 
            this.inputCompPanel.Controls.Add(this.inputTweakerTextBox);
            this.inputCompPanel.Controls.Add(this.inputEnableCheckBox);
            this.inputCompPanel.Controls.Add(this.inputTweakerLabel);
            this.inputCompPanel.Location = new System.Drawing.Point(0, 80);
            this.inputCompPanel.Name = "inputCompPanel";
            this.inputCompPanel.Size = new System.Drawing.Size(285, 352);
            this.inputCompPanel.TabIndex = 18;
            this.inputCompPanel.Visible = false;
            // 
            // inputTweakerTextBox
            // 
            this.inputTweakerTextBox.Location = new System.Drawing.Point(154, 47);
            this.inputTweakerTextBox.Name = "inputTweakerTextBox";
            this.inputTweakerTextBox.Size = new System.Drawing.Size(100, 22);
            this.inputTweakerTextBox.TabIndex = 14;
            // 
            // inputEnableCheckBox
            // 
            this.inputEnableCheckBox.AutoSize = true;
            this.inputEnableCheckBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEnableCheckBox.ForeColor = System.Drawing.Color.Black;
            this.inputEnableCheckBox.Location = new System.Drawing.Point(16, 12);
            this.inputEnableCheckBox.Name = "inputEnableCheckBox";
            this.inputEnableCheckBox.Size = new System.Drawing.Size(172, 22);
            this.inputEnableCheckBox.TabIndex = 14;
            this.inputEnableCheckBox.Text = "Enable this component";
            this.inputEnableCheckBox.UseVisualStyleBackColor = true;
            this.inputEnableCheckBox.CheckedChanged += new System.EventHandler(this.inputEnableCheckBock_CheckedChanged);
            // 
            // inputTweakerLabel
            // 
            this.inputTweakerLabel.AutoSize = true;
            this.inputTweakerLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTweakerLabel.ForeColor = System.Drawing.Color.Black;
            this.inputTweakerLabel.Location = new System.Drawing.Point(13, 49);
            this.inputTweakerLabel.Name = "inputTweakerLabel";
            this.inputTweakerLabel.Size = new System.Drawing.Size(96, 18);
            this.inputTweakerLabel.TabIndex = 13;
            this.inputTweakerLabel.Text = "Input Tweaker";
            // 
            // velocityCompPanel
            // 
            this.velocityCompPanel.Controls.Add(this.velocityMaxTextBox);
            this.velocityCompPanel.Controls.Add(this.velocityEnableCheckBox);
            this.velocityCompPanel.Controls.Add(this.velocityMaxLabel);
            this.velocityCompPanel.Location = new System.Drawing.Point(0, 80);
            this.velocityCompPanel.Name = "velocityCompPanel";
            this.velocityCompPanel.Size = new System.Drawing.Size(285, 352);
            this.velocityCompPanel.TabIndex = 17;
            // 
            // velocityMaxTextBox
            // 
            this.velocityMaxTextBox.Location = new System.Drawing.Point(158, 49);
            this.velocityMaxTextBox.Name = "velocityMaxTextBox";
            this.velocityMaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.velocityMaxTextBox.TabIndex = 14;
            // 
            // velocityEnableCheckBox
            // 
            this.velocityEnableCheckBox.AutoSize = true;
            this.velocityEnableCheckBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocityEnableCheckBox.ForeColor = System.Drawing.Color.Black;
            this.velocityEnableCheckBox.Location = new System.Drawing.Point(16, 12);
            this.velocityEnableCheckBox.Name = "velocityEnableCheckBox";
            this.velocityEnableCheckBox.Size = new System.Drawing.Size(172, 22);
            this.velocityEnableCheckBox.TabIndex = 14;
            this.velocityEnableCheckBox.Text = "Enable this component";
            this.velocityEnableCheckBox.UseVisualStyleBackColor = true;
            this.velocityEnableCheckBox.CheckedChanged += new System.EventHandler(this.velocityEnableCheckBox_CheckedChanged);
            // 
            // velocityMaxLabel
            // 
            this.velocityMaxLabel.AutoSize = true;
            this.velocityMaxLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocityMaxLabel.ForeColor = System.Drawing.Color.Black;
            this.velocityMaxLabel.Location = new System.Drawing.Point(17, 51);
            this.velocityMaxLabel.Name = "velocityMaxLabel";
            this.velocityMaxLabel.Size = new System.Drawing.Size(86, 18);
            this.velocityMaxLabel.TabIndex = 13;
            this.velocityMaxLabel.Text = "Max velocity";
            // 
            // positionCompPanel
            // 
            this.positionCompPanel.Controls.Add(this.positionAngularTextBox);
            this.positionCompPanel.Controls.Add(this.positionAngularLabel);
            this.positionCompPanel.Controls.Add(this.positionYTextBox);
            this.positionCompPanel.Controls.Add(this.positionYLabel);
            this.positionCompPanel.Controls.Add(this.positionXTextBox);
            this.positionCompPanel.Controls.Add(this.positionEnableCheckBox);
            this.positionCompPanel.Controls.Add(this.positionXLabel);
            this.positionCompPanel.Location = new System.Drawing.Point(0, 80);
            this.positionCompPanel.Name = "positionCompPanel";
            this.positionCompPanel.Size = new System.Drawing.Size(285, 352);
            this.positionCompPanel.TabIndex = 16;
            // 
            // positionAngularTextBox
            // 
            this.positionAngularTextBox.Location = new System.Drawing.Point(154, 102);
            this.positionAngularTextBox.Name = "positionAngularTextBox";
            this.positionAngularTextBox.Size = new System.Drawing.Size(100, 22);
            this.positionAngularTextBox.TabIndex = 18;
            // 
            // positionAngularLabel
            // 
            this.positionAngularLabel.AutoSize = true;
            this.positionAngularLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionAngularLabel.ForeColor = System.Drawing.Color.Black;
            this.positionAngularLabel.Location = new System.Drawing.Point(13, 104);
            this.positionAngularLabel.Name = "positionAngularLabel";
            this.positionAngularLabel.Size = new System.Drawing.Size(109, 18);
            this.positionAngularLabel.TabIndex = 17;
            this.positionAngularLabel.Text = "Angular position";
            // 
            // positionYTextBox
            // 
            this.positionYTextBox.Location = new System.Drawing.Point(154, 75);
            this.positionYTextBox.Name = "positionYTextBox";
            this.positionYTextBox.Size = new System.Drawing.Size(100, 22);
            this.positionYTextBox.TabIndex = 16;
            // 
            // positionYLabel
            // 
            this.positionYLabel.AutoSize = true;
            this.positionYLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionYLabel.ForeColor = System.Drawing.Color.Black;
            this.positionYLabel.Location = new System.Drawing.Point(13, 77);
            this.positionYLabel.Name = "positionYLabel";
            this.positionYLabel.Size = new System.Drawing.Size(68, 18);
            this.positionYLabel.TabIndex = 15;
            this.positionYLabel.Text = "Position Y";
            // 
            // positionXTextBox
            // 
            this.positionXTextBox.Location = new System.Drawing.Point(154, 47);
            this.positionXTextBox.Name = "positionXTextBox";
            this.positionXTextBox.Size = new System.Drawing.Size(100, 22);
            this.positionXTextBox.TabIndex = 14;
            // 
            // positionEnableCheckBox
            // 
            this.positionEnableCheckBox.AutoSize = true;
            this.positionEnableCheckBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionEnableCheckBox.ForeColor = System.Drawing.Color.Black;
            this.positionEnableCheckBox.Location = new System.Drawing.Point(16, 12);
            this.positionEnableCheckBox.Name = "positionEnableCheckBox";
            this.positionEnableCheckBox.Size = new System.Drawing.Size(172, 22);
            this.positionEnableCheckBox.TabIndex = 14;
            this.positionEnableCheckBox.Text = "Enable this component";
            this.positionEnableCheckBox.UseVisualStyleBackColor = true;
            this.positionEnableCheckBox.CheckedChanged += new System.EventHandler(this.positionEnableCheckBox_CheckedChanged);
            // 
            // positionXLabel
            // 
            this.positionXLabel.AutoSize = true;
            this.positionXLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionXLabel.ForeColor = System.Drawing.Color.Black;
            this.positionXLabel.Location = new System.Drawing.Point(13, 49);
            this.positionXLabel.Name = "positionXLabel";
            this.positionXLabel.Size = new System.Drawing.Size(69, 18);
            this.positionXLabel.TabIndex = 13;
            this.positionXLabel.Text = "Position X";
            // 
            // physicsCompPanel
            // 
            this.physicsCompPanel.Controls.Add(this.physicsAirTweakerTextBox);
            this.physicsCompPanel.Controls.Add(this.physicsAirTweakerLabel);
            this.physicsCompPanel.Controls.Add(this.physicsAirFrictionCheckBox);
            this.physicsCompPanel.Controls.Add(this.physicsGravityCheckBox);
            this.physicsCompPanel.Controls.Add(this.physicsMasseTextBox);
            this.physicsCompPanel.Controls.Add(this.physicsMasseLabel);
            this.physicsCompPanel.Controls.Add(this.physicsEnableCheckBox);
            this.physicsCompPanel.Location = new System.Drawing.Point(0, 80);
            this.physicsCompPanel.Name = "physicsCompPanel";
            this.physicsCompPanel.Size = new System.Drawing.Size(285, 352);
            this.physicsCompPanel.TabIndex = 16;
            // 
            // physicsAirTweakerTextBox
            // 
            this.physicsAirTweakerTextBox.Location = new System.Drawing.Point(154, 133);
            this.physicsAirTweakerTextBox.Name = "physicsAirTweakerTextBox";
            this.physicsAirTweakerTextBox.Size = new System.Drawing.Size(100, 22);
            this.physicsAirTweakerTextBox.TabIndex = 22;
            // 
            // physicsAirTweakerLabel
            // 
            this.physicsAirTweakerLabel.AutoSize = true;
            this.physicsAirTweakerLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicsAirTweakerLabel.ForeColor = System.Drawing.Color.Black;
            this.physicsAirTweakerLabel.Location = new System.Drawing.Point(13, 135);
            this.physicsAirTweakerLabel.Name = "physicsAirTweakerLabel";
            this.physicsAirTweakerLabel.Size = new System.Drawing.Size(127, 18);
            this.physicsAirTweakerLabel.TabIndex = 21;
            this.physicsAirTweakerLabel.Text = "Air friction tweaker";
            // 
            // physicsAirFrictionCheckBox
            // 
            this.physicsAirFrictionCheckBox.AutoSize = true;
            this.physicsAirFrictionCheckBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicsAirFrictionCheckBox.ForeColor = System.Drawing.Color.Black;
            this.physicsAirFrictionCheckBox.Location = new System.Drawing.Point(16, 105);
            this.physicsAirFrictionCheckBox.Name = "physicsAirFrictionCheckBox";
            this.physicsAirFrictionCheckBox.Size = new System.Drawing.Size(119, 22);
            this.physicsAirFrictionCheckBox.TabIndex = 20;
            this.physicsAirFrictionCheckBox.Text = "Use air friction";
            this.physicsAirFrictionCheckBox.UseVisualStyleBackColor = true;
            // 
            // physicsGravityCheckBox
            // 
            this.physicsGravityCheckBox.AutoSize = true;
            this.physicsGravityCheckBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicsGravityCheckBox.ForeColor = System.Drawing.Color.Black;
            this.physicsGravityCheckBox.Location = new System.Drawing.Point(16, 77);
            this.physicsGravityCheckBox.Name = "physicsGravityCheckBox";
            this.physicsGravityCheckBox.Size = new System.Drawing.Size(98, 22);
            this.physicsGravityCheckBox.TabIndex = 19;
            this.physicsGravityCheckBox.Text = "Use gravity";
            this.physicsGravityCheckBox.UseVisualStyleBackColor = true;
            // 
            // physicsMasseTextBox
            // 
            this.physicsMasseTextBox.Location = new System.Drawing.Point(154, 45);
            this.physicsMasseTextBox.Name = "physicsMasseTextBox";
            this.physicsMasseTextBox.Size = new System.Drawing.Size(100, 22);
            this.physicsMasseTextBox.TabIndex = 18;
            this.physicsMasseTextBox.TextChanged += new System.EventHandler(this.physicsMasseTextBox_TextChanged);
            // 
            // physicsMasseLabel
            // 
            this.physicsMasseLabel.AutoSize = true;
            this.physicsMasseLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicsMasseLabel.ForeColor = System.Drawing.Color.Black;
            this.physicsMasseLabel.Location = new System.Drawing.Point(13, 47);
            this.physicsMasseLabel.Name = "physicsMasseLabel";
            this.physicsMasseLabel.Size = new System.Drawing.Size(47, 18);
            this.physicsMasseLabel.TabIndex = 17;
            this.physicsMasseLabel.Text = "Masse";
            // 
            // physicsEnableCheckBox
            // 
            this.physicsEnableCheckBox.AutoSize = true;
            this.physicsEnableCheckBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicsEnableCheckBox.ForeColor = System.Drawing.Color.Black;
            this.physicsEnableCheckBox.Location = new System.Drawing.Point(16, 12);
            this.physicsEnableCheckBox.Name = "physicsEnableCheckBox";
            this.physicsEnableCheckBox.Size = new System.Drawing.Size(172, 22);
            this.physicsEnableCheckBox.TabIndex = 14;
            this.physicsEnableCheckBox.Text = "Enable this component";
            this.physicsEnableCheckBox.UseVisualStyleBackColor = true;
            this.physicsEnableCheckBox.CheckedChanged += new System.EventHandler(this.physicsEnableCheckBox_CheckedChanged);
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
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
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
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // ExportFileDialogBox
            // 
            this.ExportFileDialogBox.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // ImportFileDialogBox
            // 
            this.ImportFileDialogBox.FileName = "openFileDialog1";
            this.ImportFileDialogBox.FileOk += new System.ComponentModel.CancelEventHandler(this.ImportFileDialogBox_FileOk);
            // 
            // GameEngineEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1582, 855);
            this.Controls.Add(this.filePanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.editorPanel);
            this.Name = "GameEngineEditor";
            this.Text = "Form1";
            this.editorPanel.ResumeLayout(false);
            this.gamePropertiesPanel.ResumeLayout(false);
            this.gamePropertiesPanel.PerformLayout();
            this.scenePanel.ResumeLayout(false);
            this.scenePanel.PerformLayout();
            this.entityPanel.ResumeLayout(false);
            this.entityPanel.PerformLayout();
            this.componentPanel.ResumeLayout(false);
            this.renderCompPanel.ResumeLayout(false);
            this.renderCompPanel.PerformLayout();
            this.boxColliderCompPanel.ResumeLayout(false);
            this.boxColliderCompPanel.PerformLayout();
            this.inputCompPanel.ResumeLayout(false);
            this.inputCompPanel.PerformLayout();
            this.velocityCompPanel.ResumeLayout(false);
            this.velocityCompPanel.PerformLayout();
            this.positionCompPanel.ResumeLayout(false);
            this.positionCompPanel.PerformLayout();
            this.physicsCompPanel.ResumeLayout(false);
            this.physicsCompPanel.PerformLayout();
            this.filePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel editorPanel;
        public System.Windows.Forms.Panel gamePanel;
        public System.Windows.Forms.Panel filePanel;
        public System.Windows.Forms.Button exportBtn;
        public System.Windows.Forms.Button importBtn;
        public System.Windows.Forms.SaveFileDialog ExportFileDialogBox;
        public System.Windows.Forms.Panel gamePropertiesPanel;
        public System.Windows.Forms.ComboBox sceneComboBox;
        public System.Windows.Forms.OpenFileDialog ImportFileDialogBox;
        public System.Windows.Forms.Button sceneRemoveBtn;
        public System.Windows.Forms.Button sceneAddBtn;
        public System.Windows.Forms.Label gamePropTitle;
        public System.Windows.Forms.Panel scenePanel;
        public System.Windows.Forms.Label scenePanelTitle;
        public System.Windows.Forms.Panel componentPanel;
        public System.Windows.Forms.Label componentPanelTitle;
        public System.Windows.Forms.ComboBox componentComboBox;
        public System.Windows.Forms.Panel entityPanel;
        public System.Windows.Forms.Label entityPanelLabel;
        public System.Windows.Forms.ComboBox entityComboBox;
        public System.Windows.Forms.Button entityRemoveBtn;
        public System.Windows.Forms.Button entityAddBtn;
        public System.Windows.Forms.TextBox heightTextBox;
        public System.Windows.Forms.Label heightLabel;
        public System.Windows.Forms.TextBox widthTextBox;
        public System.Windows.Forms.Label widthLabel;
        public System.Windows.Forms.TextBox gameTitleTextBox;
        public System.Windows.Forms.Label gameTitleLabel;
        public System.Windows.Forms.TextBox backgroundImgTextBox;
        public System.Windows.Forms.Label backgroundImageLabel;
        public System.Windows.Forms.TextBox sceneNameTextBox;
        public System.Windows.Forms.Label sceneNameLabel;
        public System.Windows.Forms.TextBox entityNameTextBox;
        public System.Windows.Forms.Label entityNameLabel;
        public System.Windows.Forms.CheckBox renderEnableCheckBox;
        public System.Windows.Forms.Panel positionCompPanel;
        public System.Windows.Forms.TextBox positionAngularTextBox;
        public System.Windows.Forms.Label positionAngularLabel;
        public System.Windows.Forms.TextBox positionYTextBox;
        public System.Windows.Forms.Label positionYLabel;
        public System.Windows.Forms.TextBox positionXTextBox;
        public System.Windows.Forms.CheckBox positionEnableCheckBox;
        public System.Windows.Forms.Label positionXLabel;
        public System.Windows.Forms.Panel physicsCompPanel;
        public System.Windows.Forms.CheckBox physicsEnableCheckBox;
        public System.Windows.Forms.Panel renderCompPanel;
        public System.Windows.Forms.Panel boxColliderCompPanel;
        public System.Windows.Forms.TextBox boxColliderSizeYTextBox;
        public System.Windows.Forms.Label boxColliderSizeYLabel;
        public System.Windows.Forms.TextBox boxColliderSizeXTextBox;
        public System.Windows.Forms.CheckBox boxColliderEnableCheckBox;
        public System.Windows.Forms.Label boxColliderSizeXLabel;
        public System.Windows.Forms.Panel inputCompPanel;
        public System.Windows.Forms.TextBox inputTweakerTextBox;
        public System.Windows.Forms.CheckBox inputEnableCheckBox;
        public System.Windows.Forms.Label inputTweakerLabel;
        public System.Windows.Forms.Panel velocityCompPanel;
        public System.Windows.Forms.TextBox velocityMaxTextBox;
        public System.Windows.Forms.CheckBox velocityEnableCheckBox;
        public System.Windows.Forms.Label velocityMaxLabel;
        public System.Windows.Forms.TextBox physicsAirTweakerTextBox;
        public System.Windows.Forms.Label physicsAirTweakerLabel;
        public System.Windows.Forms.CheckBox physicsAirFrictionCheckBox;
        public System.Windows.Forms.CheckBox physicsGravityCheckBox;
        public System.Windows.Forms.TextBox physicsMasseTextBox;
        public System.Windows.Forms.Label physicsMasseLabel;
        public System.Windows.Forms.TextBox renderSizeYTextBox;
        public System.Windows.Forms.Label renderSizeYLabel;
        public System.Windows.Forms.TextBox renderSizeXTextBox;
        public System.Windows.Forms.Label renderSizeXLabel;
        public System.Windows.Forms.TextBox renderImageTextBox;
        public System.Windows.Forms.Label renderImageLabel;
    }
}

