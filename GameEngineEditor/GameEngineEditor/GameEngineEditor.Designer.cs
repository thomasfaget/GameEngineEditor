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
            this.filePanel = new System.Windows.Forms.Panel();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.ExportFileDialogBox = new System.Windows.Forms.SaveFileDialog();
            this.ImportFileDialogBox = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.editorBackground = new System.Windows.Forms.Panel();
            this.editorTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.componentPanel = new System.Windows.Forms.Panel();
            this.componentPanelTitle = new System.Windows.Forms.Label();
            this.componentComboBox = new System.Windows.Forms.ComboBox();
            this.boxColliderCompPanel = new System.Windows.Forms.Panel();
            this.isTriggerCheckBox = new System.Windows.Forms.CheckBox();
            this.boxColliderSizeYTextBox = new System.Windows.Forms.TextBox();
            this.boxColliderSizeYLabel = new System.Windows.Forms.Label();
            this.boxColliderSizeXTextBox = new System.Windows.Forms.TextBox();
            this.boxColliderEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.boxColliderSizeXLabel = new System.Windows.Forms.Label();
            this.scriptCompPanel = new System.Windows.Forms.Panel();
            this.scriptNameTextBox = new System.Windows.Forms.TextBox();
            this.scriptEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.scriptLabel = new System.Windows.Forms.Label();
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
            this.renderCompPanel = new System.Windows.Forms.Panel();
            this.renderSizeYTextBox = new System.Windows.Forms.TextBox();
            this.renderSizeYLabel = new System.Windows.Forms.Label();
            this.renderSizeXTextBox = new System.Windows.Forms.TextBox();
            this.renderSizeXLabel = new System.Windows.Forms.Label();
            this.renderImageTextBox = new System.Windows.Forms.TextBox();
            this.renderEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.renderImageLabel = new System.Windows.Forms.Label();
            this.velocityCompPanel = new System.Windows.Forms.Panel();
            this.velocityMaxTextBox = new System.Windows.Forms.TextBox();
            this.velocityEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.velocityMaxLabel = new System.Windows.Forms.Label();
            this.entityPanel = new System.Windows.Forms.Panel();
            this.entityNameTextBox = new System.Windows.Forms.TextBox();
            this.entityPanelLabel = new System.Windows.Forms.Label();
            this.entityNameLabel = new System.Windows.Forms.Label();
            this.entityComboBox = new System.Windows.Forms.ComboBox();
            this.entityRemoveBtn = new System.Windows.Forms.Button();
            this.entityAddBtn = new System.Windows.Forms.Button();
            this.scenePanel = new System.Windows.Forms.Panel();
            this.backgroundSoundTextBox = new System.Windows.Forms.TextBox();
            this.backgroundSoundLabel = new System.Windows.Forms.Label();
            this.backgroundImgTextBox = new System.Windows.Forms.TextBox();
            this.backgroundImageLabel = new System.Windows.Forms.Label();
            this.sceneNameTextBox = new System.Windows.Forms.TextBox();
            this.sceneNameLabel = new System.Windows.Forms.Label();
            this.scenePanelTitle = new System.Windows.Forms.Label();
            this.sceneComboBox = new System.Windows.Forms.ComboBox();
            this.sceneRemoveBtn = new System.Windows.Forms.Button();
            this.sceneAddBtn = new System.Windows.Forms.Button();
            this.gamePropertiesPanel = new System.Windows.Forms.Panel();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.gameTitleTextBox = new System.Windows.Forms.TextBox();
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.gamePropTitle = new System.Windows.Forms.Label();
            this.viewportPanel = new System.Windows.Forms.Panel();
            this.filePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.editorBackground.SuspendLayout();
            this.editorTablePanel.SuspendLayout();
            this.componentPanel.SuspendLayout();
            this.boxColliderCompPanel.SuspendLayout();
            this.scriptCompPanel.SuspendLayout();
            this.positionCompPanel.SuspendLayout();
            this.physicsCompPanel.SuspendLayout();
            this.renderCompPanel.SuspendLayout();
            this.velocityCompPanel.SuspendLayout();
            this.entityPanel.SuspendLayout();
            this.scenePanel.SuspendLayout();
            this.gamePropertiesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePanel
            // 
            this.filePanel.AutoSize = true;
            this.filePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.filePanel.Controls.Add(this.exportBtn);
            this.filePanel.Controls.Add(this.importBtn);
            this.filePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePanel.Location = new System.Drawing.Point(8, 8);
            this.filePanel.Name = "filePanel";
            this.filePanel.Padding = new System.Windows.Forms.Padding(20);
            this.filePanel.Size = new System.Drawing.Size(1251, 120);
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
            // ImportFileDialogBox
            // 
            this.ImportFileDialogBox.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.editorBackground, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.filePanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewportPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1582, 855);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // editorBackground
            // 
            this.editorBackground.BackColor = System.Drawing.SystemColors.HighlightText;
            this.editorBackground.Controls.Add(this.editorTablePanel);
            this.editorBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorBackground.Location = new System.Drawing.Point(1265, 8);
            this.editorBackground.Name = "editorBackground";
            this.tableLayoutPanel1.SetRowSpan(this.editorBackground, 2);
            this.editorBackground.Size = new System.Drawing.Size(309, 839);
            this.editorBackground.TabIndex = 7;
            // 
            // editorTablePanel
            // 
            this.editorTablePanel.ColumnCount = 1;
            this.editorTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editorTablePanel.Controls.Add(this.componentPanel, 0, 3);
            this.editorTablePanel.Controls.Add(this.entityPanel, 0, 2);
            this.editorTablePanel.Controls.Add(this.scenePanel, 0, 1);
            this.editorTablePanel.Controls.Add(this.gamePropertiesPanel, 0, 0);
            this.editorTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorTablePanel.Location = new System.Drawing.Point(0, 0);
            this.editorTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.editorTablePanel.Name = "editorTablePanel";
            this.editorTablePanel.RowCount = 4;
            this.editorTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.editorTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.editorTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.editorTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.editorTablePanel.Size = new System.Drawing.Size(309, 839);
            this.editorTablePanel.TabIndex = 7;
            // 
            // componentPanel
            // 
            this.componentPanel.BackColor = System.Drawing.Color.Transparent;
            this.componentPanel.Controls.Add(this.componentPanelTitle);
            this.componentPanel.Controls.Add(this.componentComboBox);
            this.componentPanel.Controls.Add(this.boxColliderCompPanel);
            this.componentPanel.Controls.Add(this.scriptCompPanel);
            this.componentPanel.Controls.Add(this.positionCompPanel);
            this.componentPanel.Controls.Add(this.physicsCompPanel);
            this.componentPanel.Controls.Add(this.renderCompPanel);
            this.componentPanel.Controls.Add(this.velocityCompPanel);
            this.componentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentPanel.ForeColor = System.Drawing.Color.White;
            this.componentPanel.Location = new System.Drawing.Point(0, 501);
            this.componentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.componentPanel.Name = "componentPanel";
            this.componentPanel.Size = new System.Drawing.Size(309, 338);
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
            this.componentPanelTitle.Size = new System.Drawing.Size(309, 41);
            this.componentPanelTitle.TabIndex = 0;
            this.componentPanelTitle.Text = "COMPONENT";
            this.componentPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // componentComboBox
            // 
            this.componentComboBox.FormattingEnabled = true;
            this.componentComboBox.Items.AddRange(new object[] {
            "Physics",
            "BoxCollision",
            "Position",
            "Velocity",
            "Render",
            "Script"});
            this.componentComboBox.Location = new System.Drawing.Point(10, 50);
            this.componentComboBox.Name = "componentComboBox";
            this.componentComboBox.Size = new System.Drawing.Size(272, 24);
            this.componentComboBox.TabIndex = 0;
            this.componentComboBox.SelectedIndexChanged += new System.EventHandler(this.componentComboBox_SelectedIndexChanged);
            // 
            // boxColliderCompPanel
            // 
            this.boxColliderCompPanel.Controls.Add(this.isTriggerCheckBox);
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
            // isTriggerCheckBox
            // 
            this.isTriggerCheckBox.AutoSize = true;
            this.isTriggerCheckBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isTriggerCheckBox.ForeColor = System.Drawing.Color.Black;
            this.isTriggerCheckBox.Location = new System.Drawing.Point(17, 105);
            this.isTriggerCheckBox.Name = "isTriggerCheckBox";
            this.isTriggerCheckBox.Size = new System.Drawing.Size(82, 22);
            this.isTriggerCheckBox.TabIndex = 17;
            this.isTriggerCheckBox.Text = "IsTrigger";
            this.isTriggerCheckBox.UseVisualStyleBackColor = true;
            this.isTriggerCheckBox.CheckedChanged += new System.EventHandler(this.isTriggerCheckBox_CheckedChanged);
            // 
            // boxColliderSizeYTextBox
            // 
            this.boxColliderSizeYTextBox.Location = new System.Drawing.Point(155, 75);
            this.boxColliderSizeYTextBox.Name = "boxColliderSizeYTextBox";
            this.boxColliderSizeYTextBox.Size = new System.Drawing.Size(100, 22);
            this.boxColliderSizeYTextBox.TabIndex = 16;
            this.boxColliderSizeYTextBox.TextChanged += new System.EventHandler(this.boxColliderSizeYTextBox_TextChanged);
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
            this.boxColliderSizeXTextBox.TextChanged += new System.EventHandler(this.boxColliderSizeXTextBox_TextChanged);
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
            // scriptCompPanel
            // 
            this.scriptCompPanel.Controls.Add(this.scriptNameTextBox);
            this.scriptCompPanel.Controls.Add(this.scriptEnableCheckBox);
            this.scriptCompPanel.Controls.Add(this.scriptLabel);
            this.scriptCompPanel.Location = new System.Drawing.Point(0, 80);
            this.scriptCompPanel.Name = "scriptCompPanel";
            this.scriptCompPanel.Size = new System.Drawing.Size(285, 352);
            this.scriptCompPanel.TabIndex = 18;
            this.scriptCompPanel.Visible = false;
            // 
            // scriptNameTextBox
            // 
            this.scriptNameTextBox.Location = new System.Drawing.Point(158, 49);
            this.scriptNameTextBox.Name = "scriptNameTextBox";
            this.scriptNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.scriptNameTextBox.TabIndex = 14;
            this.scriptNameTextBox.TextChanged += new System.EventHandler(this.scriptNameTextBox_TextChanged);
            // 
            // scriptEnableCheckBox
            // 
            this.scriptEnableCheckBox.AutoSize = true;
            this.scriptEnableCheckBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptEnableCheckBox.ForeColor = System.Drawing.Color.Black;
            this.scriptEnableCheckBox.Location = new System.Drawing.Point(16, 12);
            this.scriptEnableCheckBox.Name = "scriptEnableCheckBox";
            this.scriptEnableCheckBox.Size = new System.Drawing.Size(172, 22);
            this.scriptEnableCheckBox.TabIndex = 14;
            this.scriptEnableCheckBox.Text = "Enable this component";
            this.scriptEnableCheckBox.UseVisualStyleBackColor = true;
            this.scriptEnableCheckBox.CheckedChanged += new System.EventHandler(this.scriptEnableCheckBox_CheckedChanged);
            // 
            // scriptLabel
            // 
            this.scriptLabel.AutoSize = true;
            this.scriptLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptLabel.ForeColor = System.Drawing.Color.Black;
            this.scriptLabel.Location = new System.Drawing.Point(17, 51);
            this.scriptLabel.Name = "scriptLabel";
            this.scriptLabel.Size = new System.Drawing.Size(81, 18);
            this.scriptLabel.TabIndex = 13;
            this.scriptLabel.Text = "Script name";
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
            this.positionAngularTextBox.TextChanged += new System.EventHandler(this.positionAngularTextBox_TextChanged);
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
            this.positionYTextBox.TextChanged += new System.EventHandler(this.positionYTextBox_TextChanged);
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
            this.positionXTextBox.TextChanged += new System.EventHandler(this.positionXTextBox_TextChanged);
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
            this.physicsAirTweakerTextBox.TextChanged += new System.EventHandler(this.physicsAirTweakerTextBox_TextChanged);
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
            this.physicsAirFrictionCheckBox.CheckedChanged += new System.EventHandler(this.physicsAirFrictionCheckBox_CheckedChanged);
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
            this.physicsGravityCheckBox.CheckedChanged += new System.EventHandler(this.physicsGravityCheckBox_CheckedChanged);
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
            this.renderSizeYTextBox.TextChanged += new System.EventHandler(this.renderSizeYTextBox_TextChanged);
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
            this.renderSizeXTextBox.TextChanged += new System.EventHandler(this.renderSizeXTextBox_TextChanged);
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
            this.renderImageTextBox.TextChanged += new System.EventHandler(this.renderImageTextBox_TextChanged);
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
            this.velocityMaxTextBox.TextChanged += new System.EventHandler(this.velocityMaxTextBox_TextChanged);
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
            // entityPanel
            // 
            this.entityPanel.BackColor = System.Drawing.Color.Transparent;
            this.entityPanel.Controls.Add(this.entityNameTextBox);
            this.entityPanel.Controls.Add(this.entityPanelLabel);
            this.entityPanel.Controls.Add(this.entityNameLabel);
            this.entityPanel.Controls.Add(this.entityComboBox);
            this.entityPanel.Controls.Add(this.entityRemoveBtn);
            this.entityPanel.Controls.Add(this.entityAddBtn);
            this.entityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityPanel.ForeColor = System.Drawing.Color.White;
            this.entityPanel.Location = new System.Drawing.Point(0, 334);
            this.entityPanel.Margin = new System.Windows.Forms.Padding(0);
            this.entityPanel.Name = "entityPanel";
            this.entityPanel.Size = new System.Drawing.Size(309, 167);
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
            this.entityPanelLabel.Location = new System.Drawing.Point(0, 0);
            this.entityPanelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.entityPanelLabel.Name = "entityPanelLabel";
            this.entityPanelLabel.Size = new System.Drawing.Size(309, 41);
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
            this.entityRemoveBtn.Click += new System.EventHandler(this.entityRemoveBtn_Click);
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
            this.entityAddBtn.Click += new System.EventHandler(this.entityAddBtn_Click);
            // 
            // scenePanel
            // 
            this.scenePanel.BackColor = System.Drawing.Color.Transparent;
            this.scenePanel.Controls.Add(this.backgroundSoundTextBox);
            this.scenePanel.Controls.Add(this.backgroundSoundLabel);
            this.scenePanel.Controls.Add(this.backgroundImgTextBox);
            this.scenePanel.Controls.Add(this.backgroundImageLabel);
            this.scenePanel.Controls.Add(this.sceneNameTextBox);
            this.scenePanel.Controls.Add(this.sceneNameLabel);
            this.scenePanel.Controls.Add(this.scenePanelTitle);
            this.scenePanel.Controls.Add(this.sceneComboBox);
            this.scenePanel.Controls.Add(this.sceneRemoveBtn);
            this.scenePanel.Controls.Add(this.sceneAddBtn);
            this.scenePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenePanel.ForeColor = System.Drawing.Color.White;
            this.scenePanel.Location = new System.Drawing.Point(0, 125);
            this.scenePanel.Margin = new System.Windows.Forms.Padding(0);
            this.scenePanel.Name = "scenePanel";
            this.scenePanel.Size = new System.Drawing.Size(309, 209);
            this.scenePanel.TabIndex = 1;
            // 
            // backgroundSoundTextBox
            // 
            this.backgroundSoundTextBox.Location = new System.Drawing.Point(154, 143);
            this.backgroundSoundTextBox.Name = "backgroundSoundTextBox";
            this.backgroundSoundTextBox.Size = new System.Drawing.Size(100, 22);
            this.backgroundSoundTextBox.TabIndex = 12;
            this.backgroundSoundTextBox.TextChanged += new System.EventHandler(this.backgroundSoundTextBox_TextChanged);
            // 
            // backgroundSoundLabel
            // 
            this.backgroundSoundLabel.AutoSize = true;
            this.backgroundSoundLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundSoundLabel.ForeColor = System.Drawing.Color.Black;
            this.backgroundSoundLabel.Location = new System.Drawing.Point(13, 145);
            this.backgroundSoundLabel.Name = "backgroundSoundLabel";
            this.backgroundSoundLabel.Size = new System.Drawing.Size(122, 18);
            this.backgroundSoundLabel.TabIndex = 11;
            this.backgroundSoundLabel.Text = "Background Sound";
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
            this.scenePanelTitle.Size = new System.Drawing.Size(309, 41);
            this.scenePanelTitle.TabIndex = 0;
            this.scenePanelTitle.Text = "SCENE";
            this.scenePanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sceneComboBox
            // 
            this.sceneComboBox.FormattingEnabled = true;
            this.sceneComboBox.Location = new System.Drawing.Point(3, 53);
            this.sceneComboBox.Name = "sceneComboBox";
            this.sceneComboBox.Size = new System.Drawing.Size(201, 24);
            this.sceneComboBox.TabIndex = 0;
            this.sceneComboBox.SelectedIndexChanged += new System.EventHandler(this.sceneComboBox_SelectedIndexChanged);
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
            this.sceneRemoveBtn.Click += new System.EventHandler(this.sceneRemoveBtn_Click);
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
            this.sceneAddBtn.Click += new System.EventHandler(this.sceneAddBtn_Click);
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
            this.gamePropertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePropertiesPanel.ForeColor = System.Drawing.Color.White;
            this.gamePropertiesPanel.Location = new System.Drawing.Point(0, 0);
            this.gamePropertiesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.gamePropertiesPanel.Name = "gamePropertiesPanel";
            this.gamePropertiesPanel.Size = new System.Drawing.Size(309, 125);
            this.gamePropertiesPanel.TabIndex = 0;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(209, 84);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(46, 22);
            this.heightTextBox.TabIndex = 6;
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
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
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
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
            this.gamePropTitle.Location = new System.Drawing.Point(0, 0);
            this.gamePropTitle.Margin = new System.Windows.Forms.Padding(0);
            this.gamePropTitle.Name = "gamePropTitle";
            this.gamePropTitle.Size = new System.Drawing.Size(309, 41);
            this.gamePropTitle.TabIndex = 0;
            this.gamePropTitle.Text = "GAME PROPERTIES";
            this.gamePropTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewportPanel
            // 
            this.viewportPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.viewportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewportPanel.Location = new System.Drawing.Point(8, 134);
            this.viewportPanel.Name = "viewportPanel";
            this.viewportPanel.Size = new System.Drawing.Size(1251, 713);
            this.viewportPanel.TabIndex = 2;
            // 
            // GameEngineEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1582, 855);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameEngineEditor";
            this.Text = "Form1";
            this.filePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.editorBackground.ResumeLayout(false);
            this.editorTablePanel.ResumeLayout(false);
            this.componentPanel.ResumeLayout(false);
            this.boxColliderCompPanel.ResumeLayout(false);
            this.boxColliderCompPanel.PerformLayout();
            this.scriptCompPanel.ResumeLayout(false);
            this.scriptCompPanel.PerformLayout();
            this.positionCompPanel.ResumeLayout(false);
            this.positionCompPanel.PerformLayout();
            this.physicsCompPanel.ResumeLayout(false);
            this.physicsCompPanel.PerformLayout();
            this.renderCompPanel.ResumeLayout(false);
            this.renderCompPanel.PerformLayout();
            this.velocityCompPanel.ResumeLayout(false);
            this.velocityCompPanel.PerformLayout();
            this.entityPanel.ResumeLayout(false);
            this.entityPanel.PerformLayout();
            this.scenePanel.ResumeLayout(false);
            this.scenePanel.PerformLayout();
            this.gamePropertiesPanel.ResumeLayout(false);
            this.gamePropertiesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel filePanel;
        public System.Windows.Forms.Button exportBtn;
        public System.Windows.Forms.Button importBtn;
        public System.Windows.Forms.SaveFileDialog ExportFileDialogBox;
        public System.Windows.Forms.OpenFileDialog ImportFileDialogBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel editorBackground;
        private System.Windows.Forms.TableLayoutPanel editorTablePanel;
        public System.Windows.Forms.Panel componentPanel;
        public System.Windows.Forms.Label componentPanelTitle;
        public System.Windows.Forms.ComboBox componentComboBox;
        public System.Windows.Forms.Panel positionCompPanel;
        public System.Windows.Forms.TextBox positionAngularTextBox;
        public System.Windows.Forms.Label positionAngularLabel;
        public System.Windows.Forms.TextBox positionYTextBox;
        public System.Windows.Forms.Label positionYLabel;
        public System.Windows.Forms.TextBox positionXTextBox;
        public System.Windows.Forms.CheckBox positionEnableCheckBox;
        public System.Windows.Forms.Label positionXLabel;
        public System.Windows.Forms.Panel physicsCompPanel;
        public System.Windows.Forms.TextBox physicsAirTweakerTextBox;
        public System.Windows.Forms.Label physicsAirTweakerLabel;
        public System.Windows.Forms.CheckBox physicsAirFrictionCheckBox;
        public System.Windows.Forms.CheckBox physicsGravityCheckBox;
        public System.Windows.Forms.TextBox physicsMasseTextBox;
        public System.Windows.Forms.Label physicsMasseLabel;
        public System.Windows.Forms.CheckBox physicsEnableCheckBox;
        public System.Windows.Forms.Panel renderCompPanel;
        public System.Windows.Forms.TextBox renderSizeYTextBox;
        public System.Windows.Forms.Label renderSizeYLabel;
        public System.Windows.Forms.TextBox renderSizeXTextBox;
        public System.Windows.Forms.Label renderSizeXLabel;
        public System.Windows.Forms.TextBox renderImageTextBox;
        public System.Windows.Forms.CheckBox renderEnableCheckBox;
        public System.Windows.Forms.Label renderImageLabel;
        public System.Windows.Forms.Panel boxColliderCompPanel;
        public System.Windows.Forms.TextBox boxColliderSizeYTextBox;
        public System.Windows.Forms.Label boxColliderSizeYLabel;
        public System.Windows.Forms.TextBox boxColliderSizeXTextBox;
        public System.Windows.Forms.CheckBox boxColliderEnableCheckBox;
        public System.Windows.Forms.Label boxColliderSizeXLabel;
        public System.Windows.Forms.Panel velocityCompPanel;
        public System.Windows.Forms.TextBox velocityMaxTextBox;
        public System.Windows.Forms.CheckBox velocityEnableCheckBox;
        public System.Windows.Forms.Label velocityMaxLabel;
        public System.Windows.Forms.Panel entityPanel;
        public System.Windows.Forms.TextBox entityNameTextBox;
        public System.Windows.Forms.Label entityPanelLabel;
        public System.Windows.Forms.Label entityNameLabel;
        public System.Windows.Forms.ComboBox entityComboBox;
        public System.Windows.Forms.Button entityRemoveBtn;
        public System.Windows.Forms.Button entityAddBtn;
        public System.Windows.Forms.Panel scenePanel;
        public System.Windows.Forms.TextBox backgroundSoundTextBox;
        public System.Windows.Forms.Label backgroundSoundLabel;
        public System.Windows.Forms.TextBox backgroundImgTextBox;
        public System.Windows.Forms.Label backgroundImageLabel;
        public System.Windows.Forms.TextBox sceneNameTextBox;
        public System.Windows.Forms.Label sceneNameLabel;
        public System.Windows.Forms.Label scenePanelTitle;
        public System.Windows.Forms.ComboBox sceneComboBox;
        public System.Windows.Forms.Button sceneRemoveBtn;
        public System.Windows.Forms.Button sceneAddBtn;
        public System.Windows.Forms.Panel gamePropertiesPanel;
        public System.Windows.Forms.TextBox heightTextBox;
        public System.Windows.Forms.Label heightLabel;
        public System.Windows.Forms.TextBox widthTextBox;
        public System.Windows.Forms.Label widthLabel;
        public System.Windows.Forms.TextBox gameTitleTextBox;
        public System.Windows.Forms.Label gameTitleLabel;
        public System.Windows.Forms.Label gamePropTitle;
        public System.Windows.Forms.Panel viewportPanel;
        public System.Windows.Forms.Panel scriptCompPanel;
        public System.Windows.Forms.TextBox scriptNameTextBox;
        public System.Windows.Forms.CheckBox scriptEnableCheckBox;
        public System.Windows.Forms.Label scriptLabel;
        public System.Windows.Forms.CheckBox isTriggerCheckBox;
    }
}

