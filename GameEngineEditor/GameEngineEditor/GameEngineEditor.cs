using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameEngineEditor
{
    public partial class GameEngineEditor : Form
    {
        public static GameEngineEditor instance;

        public GameEngineEditor()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                throw new Exception("An instance of the data manager already exist.");
            }
            InitializeComponent();           
        }

        public void UpdateViewport()
        {
            // Clear viewport
            viewportPanel.Controls.Clear();

            string path = Environment.CurrentDirectory + "\\img\\";
            int indexScene = sceneComboBox.SelectedIndex;

            foreach(Entity entity in DataManager.instance._scenes[indexScene].GetEntities())
            {
                RenderComponent renderComponent = (RenderComponent)entity.GetComponentOfType(typeof(RenderComponent));
                PositionComponent positionComponent = (PositionComponent)entity.GetComponentOfType(typeof(PositionComponent));
                if (renderComponent.componentEnable && positionComponent.componentEnable)
                {
                    try
                    {
                        Panel currentEntity = new Panel();
                        currentEntity.BackgroundImage = Image.FromFile(path + renderComponent.image);
                        currentEntity.BackgroundImageLayout = ImageLayout.Stretch;
                        currentEntity.Size = new Size((int)renderComponent.size.X, (int)renderComponent.size.Y);
                        currentEntity.MaximumSize = currentEntity.Size;
                        currentEntity.Location = new Point((int)positionComponent.position.X, (int)positionComponent.position.Y) ;
                        currentEntity.BackColor = Color.Transparent;
                        

                        viewportPanel.Controls.Add(currentEntity);
                        viewportPanel.Show();
                    }
                    catch
                    {
                       
                    }
                }
            }
        }

        #region "Import/Export EventHandlers"
        private void importBtn_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            DataManager.instance.ImportDataFromXML(myStream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    DataManager.instance.ExportDataToXML(myStream);
                    myStream.Close();
                }
            }
        }
        #endregion

        #region "Game properties EventHandlers"
        private void gameTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            DataManager.instance.GameTitleChanged();
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            DataManager.instance.GameWidthChanged();
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            DataManager.instance.GameHeightChanged();
        }
        #endregion

        #region "Scene EventHandlers"
        private void sceneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataManager.instance.SceneSelectedChanged();
            UpdateViewport();
        }

        private void sceneAddBtn_Click(object sender, EventArgs e)
        {
            DataManager.instance.AddSceneClicked();
        }

        private void sceneRemoveBtn_Click(object sender, EventArgs e)
        {
            DataManager.instance.RemoveSceneClicked();
        }

        private void sceneNameTextBox_TextChanged(object sender, EventArgs e)
        {
            DataManager.instance.SceneNameChanged();
        }

        private void backgroundImgTextBox_TextChanged(object sender, EventArgs e)
        {
            DataManager.instance.SceneBackgroundChanged();
        }
        #endregion

        #region "Entity EventHandlers"
        private void entityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataManager.instance.EntitySelectedChanged();
        }

        private void entityAddBtn_Click(object sender, EventArgs e)
        {
            DataManager.instance.AddEntityClicked();
        }

        private void entityRemoveBtn_Click(object sender, EventArgs e)
        {
            DataManager.instance.RemoveEntityClicked();
        }

        private void entityNameTextBox_TextChanged(object sender, EventArgs e)
        {
            DataManager.instance.EntityNameChanged();           
        }
        #endregion

        #region "Components EventHandlers"
        private void componentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataManager.instance.ComponentSelectedChanged();
        }

            #region "INPUT component EventHandlers"
            private void inputEnableCheckBock_CheckedChanged(object sender, EventArgs e)
            {
                DataManager.instance.InputEnableChanged();
            }
            private void inputTweakerTextBox_TextChanged(object sender, EventArgs e)
            {
                DataManager.instance.InputTweakerChanged();
            }
            #endregion

            #region "PHYSICS component EventHandlers"
            private void physicsEnableCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                DataManager.instance.PhysicsEnableChanged();           
            }
            private void physicsMasseTextBox_TextChanged(object sender, EventArgs e)
            {
                DataManager.instance.MasseChanged();           
            }
            private void physicsGravityCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                DataManager.instance.UseGravityChanged();
            }

            private void physicsAirFrictionCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                DataManager.instance.UseAirFrictionChanged();
            }

            private void physicsAirTweakerTextBox_TextChanged(object sender, EventArgs e)
            {
                DataManager.instance.AirTweakerChanged();
            }
            #endregion

            #region "BOX COLLISION component EventHandlers"
            private void boxColliderEnableCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                DataManager.instance.BoxCollisionEnableChanged();
            }
            private void boxColliderSizeXTextBox_TextChanged(object sender, EventArgs e)
            {
                DataManager.instance.BoxCollisionSizeXChanged();
            }

            private void boxColliderSizeYTextBox_TextChanged(object sender, EventArgs e)
            {
                DataManager.instance.BoxCollisionSizeYChanged();
            }
            #endregion

            #region "POSITION component EventHandlers"
            private void positionEnableCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                DataManager.instance.PositionEnableChanged();
                UpdateViewport();
            }
            private void positionXTextBox_TextChanged(object sender, EventArgs e)
            {
                DataManager.instance.PositionXChanged();
                UpdateViewport();
            }

            private void positionYTextBox_TextChanged(object sender, EventArgs e)
            {
                DataManager.instance.PositionYChanged();
                UpdateViewport();
            }

            private void positionAngularTextBox_TextChanged(object sender, EventArgs e)
            {
                DataManager.instance.OrientationChanged();
            }
            #endregion

            #region "VELOCITY component EventHandlers"
            private void velocityEnableCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                DataManager.instance.VelocityEnableChanged();
            }
            private void velocityMaxTextBox_TextChanged(object sender, EventArgs e)
            {
                DataManager.instance.MaxVelocityChanged();
            }
            #endregion

            #region "RENDER component EventHandlers"
            private void renderEnableCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                DataManager.instance.RenderEnableChanged();
                UpdateViewport();
            }
            private void renderImageTextBox_TextChanged(object sender, EventArgs e)
            {
                DataManager.instance.ImageChanged();
                UpdateViewport();
            }

            private void renderSizeXTextBox_TextChanged(object sender, EventArgs e)
            {
                DataManager.instance.ImageSizeXChanged();
                UpdateViewport();
            }

            private void renderSizeYTextBox_TextChanged(object sender, EventArgs e)
            {
                DataManager.instance.ImageSizeYChanged();
                UpdateViewport();
            }




        #endregion

        #endregion       
    }
}
