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

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataManager.instance.UpdateSceneProperties();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void scenePanelTitle_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ImportFileDialogBox_FileOk(object sender, CancelEventArgs e)
        {
   
        }

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

        private void gameTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            DataManager.instance.gameProperties.gameName = gameTitleTextBox.Text;
        }

        private void entityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataManager.instance.UpdateEntityProperties();
        }

        private void componentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataManager.instance.ShowCorrectComponentPanel();
        }

        private void entityNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;
            if (indexScene >= 0 && indexEntity >= 0)
            {
                DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].SetName(entityNameTextBox.Text);
            }
        }

        private void backgroundImgTextBox_TextChanged(object sender, EventArgs e)
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            if (indexScene >= 0)
            {
                DataManager.instance._scenes[indexScene].SetBackgroundImage(backgroundImgTextBox.Text);
            }
        }

        private void sceneNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            if (indexScene >= 0)
            {
                DataManager.instance._scenes[indexScene].SetName(sceneNameTextBox.Text);
            }
        }

        private void physicsEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                if (physicsEnableCheckBox.Checked == true)
                {
                    DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].AddComponent(new PhysicsComponent());
                }
                else
                {
                    DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].RemoveComponentOfType(typeof(PhysicsComponent));
                }
            }
            else
            {
                DataManager.instance.ClearComponentPanel();
            }
        }

        private void renderEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                if (renderEnableCheckBox.Checked == true)
                {
                    DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].AddComponent(new RenderComponent());
                }
                else
                {
                    DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].RemoveComponentOfType(typeof(RenderComponent));
                }
            }
            else
            {
                DataManager.instance.ClearComponentPanel();
            }
        }

        private void boxColliderEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                if (boxColliderEnableCheckBox.Checked == true)
                {
                    DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].AddComponent(new BoxCollisionComponent());
                }
                else
                {
                    DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].RemoveComponentOfType(typeof(BoxCollisionComponent));
                }
            }
            else
            {
                DataManager.instance.ClearComponentPanel();
            }
        }

        private void inputEnableCheckBock_CheckedChanged(object sender, EventArgs e)
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                if (inputEnableCheckBox.Checked == true)
                {
                    DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].AddComponent(new InputComponent());
                }
                else
                {
                    DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].RemoveComponentOfType(typeof(InputComponent));
                }
            }
            else
            {
                DataManager.instance.ClearComponentPanel();
            }
        }

        private void velocityEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                if (velocityEnableCheckBox.Checked == true)
                {
                    DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].AddComponent(new VelocityComponent());
                }
                else
                {
                    DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].RemoveComponentOfType(typeof(VelocityComponent));
                }
            }
            else
            {
                DataManager.instance.ClearComponentPanel();
            }
        }

        private void positionEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                if (positionEnableCheckBox.Checked == true)
                {
                    DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].AddComponent(new PositionComponent());
                }
                else
                {
                    DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].RemoveComponentOfType(typeof(PositionComponent));
                }
            }else
            {
                DataManager.instance.ClearComponentPanel();
            }
        }

        private void physicsMasseTextBox_TextChanged(object sender, EventArgs e)
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                ((PhysicsComponent)(DataManager.instance._scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(PhysicsComponent)))).masse = Int32.Parse(physicsMasseTextBox.Text);
            }
        }
    }
}
