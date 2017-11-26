using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace GameEngineEditor
{
    class DataManager
    {
        public static DataManager instance;

        public GameProperties gameProperties;
        public List<Scene> _scenes = new List<Scene>();

        public DataManager()
        {
            if(instance == null)
            {
                instance = this;
            }
            else
            {
                throw new Exception("An instance of the data manager already exist.");
            }
        }

        #region "Update/Show in editor Section"
        private void UpdateGamePropertiesEditorValue()
        {
            GameEngineEditor.instance.gameTitleTextBox.Text = gameProperties.gameName;
            GameEngineEditor.instance.widthTextBox.Text = gameProperties.screenWidth.ToString();
            GameEngineEditor.instance.heightTextBox.Text = gameProperties.screenHeight.ToString();
        }
        private void UpdateSceneComboBoxValue()
        {
            GameEngineEditor.instance.sceneComboBox.Items.Clear();
            foreach (Scene scene in _scenes)
            {
                GameEngineEditor.instance.sceneComboBox.Items.Add(scene.GetName());
            }

            // Show nothing
            GameEngineEditor.instance.sceneComboBox.SelectedIndex = -1;
            UpdateSceneProperties();
        }            
        private void UpdateSceneProperties()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;

            if (indexScene >= 0)
            {
                GameEngineEditor.instance.sceneNameTextBox.Visible = true;
                GameEngineEditor.instance.backgroundImgTextBox.Visible = true;
                GameEngineEditor.instance.entityPanel.Visible = true;
                GameEngineEditor.instance.sceneNameTextBox.Text = _scenes[indexScene].GetName();
                GameEngineEditor.instance.backgroundImgTextBox.Text = _scenes[indexScene].GetBackgroundImage();
            }
            else
            {
                GameEngineEditor.instance.sceneNameTextBox.Visible = false;
                GameEngineEditor.instance.backgroundImgTextBox.Visible = false;
                GameEngineEditor.instance.entityPanel.Visible = false;
                GameEngineEditor.instance.sceneNameTextBox.Text = "";
                GameEngineEditor.instance.backgroundImgTextBox.Text = "";                
            }

            UpdateEntityComboBoxValue();
        }
        private void UpdateEntityComboBoxValue()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;

            if (indexScene >= 0) { 
                GameEngineEditor.instance.entityComboBox.Items.Clear();
                foreach (Entity entity in _scenes[indexScene].GetEntities())
                {
                    GameEngineEditor.instance.entityComboBox.Items.Add(entity.GetName());
                }
            }

            // Show nothing
            GameEngineEditor.instance.entityComboBox.SelectedIndex = -1;
            UpdateEntityProperties();
        }
        private void UpdateEntityProperties()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                GameEngineEditor.instance.entityNameTextBox.Visible = true;
                GameEngineEditor.instance.componentPanel.Visible = true;
                GameEngineEditor.instance.entityNameTextBox.Text = _scenes[indexScene].GetEntities()[indexEntity].GetName();
            }
            else
            {
                GameEngineEditor.instance.entityNameTextBox.Visible = false;
                GameEngineEditor.instance.componentPanel.Visible = false;
                GameEngineEditor.instance.entityNameTextBox.Text = "";
            }

            // Show nothing
            GameEngineEditor.instance.componentComboBox.SelectedIndex = -1;
            UpdateComponentProperties();            
        }
        private void UpdateComponentProperties()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;
            int indexComponent = GameEngineEditor.instance.componentComboBox.SelectedIndex;

            HideComponentPanel();

            if (indexScene >= 0 && indexEntity >= 0 && indexComponent >= 0)
            {
                string componentPanelComboBoxText = GameEngineEditor.instance.componentComboBox.SelectedItem.ToString();
                switch (componentPanelComboBoxText)
                {
                    case ("Input"):
                        GameEngineEditor.instance.inputCompPanel.Visible = true;
                        InputComponent inputComponent = (InputComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(InputComponent)));
                        GameEngineEditor.instance.inputEnableCheckBox.Checked = inputComponent.componentEnable;
                        GameEngineEditor.instance.inputTweakerTextBox.Text = inputComponent.inputTweaker.ToString();
                        break;
                    case ("Physics"):
                        GameEngineEditor.instance.physicsCompPanel.Visible = true;
                        PhysicsComponent physicsComponent = (PhysicsComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(PhysicsComponent)));
                        GameEngineEditor.instance.physicsEnableCheckBox.Checked = physicsComponent.componentEnable;
                        GameEngineEditor.instance.physicsMasseTextBox.Text = physicsComponent.masse.ToString();
                        GameEngineEditor.instance.physicsGravityCheckBox.Checked = physicsComponent.useGravity;
                        GameEngineEditor.instance.physicsAirFrictionCheckBox.Checked = physicsComponent.useAirFriction;
                        GameEngineEditor.instance.physicsAirTweakerTextBox.Text = physicsComponent.airFrictionTweaker.ToString();

                        break;
                    case ("BoxCollision"):
                        GameEngineEditor.instance.boxColliderCompPanel.Visible = true;                        
                        BoxCollisionComponent boxCollisionComponent = (BoxCollisionComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(BoxCollisionComponent)));
                        GameEngineEditor.instance.boxColliderEnableCheckBox.Checked = boxCollisionComponent.componentEnable;
                        GameEngineEditor.instance.renderSizeXTextBox.Text = boxCollisionComponent.size.X.ToString();
                        GameEngineEditor.instance.renderSizeYTextBox.Text = boxCollisionComponent.size.Y.ToString();
                        break;
                    case ("Position"):
                        GameEngineEditor.instance.positionCompPanel.Visible = true;
                        PositionComponent positionComponent = (PositionComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(PositionComponent)));
                        GameEngineEditor.instance.positionXTextBox.Text = positionComponent.position.X.ToString();
                        GameEngineEditor.instance.positionYTextBox.Text = positionComponent.position.Y.ToString();
                        GameEngineEditor.instance.positionAngularTextBox.Text = positionComponent.orientation.ToString();
                        break;
                    case ("Velocity"):
                        GameEngineEditor.instance.velocityCompPanel.Visible = true;
                        VelocityComponent velocityComponent = (VelocityComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(VelocityComponent)));
                        GameEngineEditor.instance.velocityEnableCheckBox.Checked = velocityComponent.componentEnable;
                        GameEngineEditor.instance.velocityMaxTextBox.Text = velocityComponent.maxVelocity.ToString();
                        break;
                    case ("Render"):
                        GameEngineEditor.instance.renderCompPanel.Visible = true;
                        RenderComponent renderComponent = (RenderComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(RenderComponent)));
                        GameEngineEditor.instance.renderEnableCheckBox.Checked = renderComponent.componentEnable;
                        GameEngineEditor.instance.renderImageTextBox.Text = renderComponent.image.ToString();
                        GameEngineEditor.instance.renderSizeXTextBox.Text = renderComponent.size.X.ToString();
                        GameEngineEditor.instance.renderSizeYTextBox.Text = renderComponent.size.Y.ToString();
                        break;
                    default:
                        break;
                }

            }
        }
        private void HideComponentPanel()
        {
            GameEngineEditor.instance.inputCompPanel.Visible = false;
            GameEngineEditor.instance.physicsCompPanel.Visible = false;
            GameEngineEditor.instance.boxColliderCompPanel.Visible = false;
            GameEngineEditor.instance.positionCompPanel.Visible = false;
            GameEngineEditor.instance.velocityCompPanel.Visible = false;
            GameEngineEditor.instance.renderCompPanel.Visible = false;

        }
        private void UpdateComponentsValues()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                foreach (IComponent component in _scenes[indexScene].GetEntities()[indexEntity].GetComponents())
                {
                    if (component.GetType() == typeof(InputComponent))
                    {
                        GameEngineEditor.instance.inputEnableCheckBox.Checked = component.GetEnable();
                        GameEngineEditor.instance.inputTweakerTextBox.Text = (((InputComponent)component).inputTweaker).ToString();
                    }
                    else if (component.GetType() == typeof(PhysicsComponent))
                    {
                        GameEngineEditor.instance.physicsEnableCheckBox.Checked = component.GetEnable();
                        GameEngineEditor.instance.physicsMasseTextBox.Text = (((PhysicsComponent)component).masse).ToString();
                        GameEngineEditor.instance.physicsGravityCheckBox.Checked = ((PhysicsComponent)component).useGravity;
                        GameEngineEditor.instance.physicsAirFrictionCheckBox.Checked = ((PhysicsComponent)component).useAirFriction;
                        GameEngineEditor.instance.physicsAirTweakerTextBox.Text = (((PhysicsComponent)component).airFrictionTweaker).ToString();
                    }
                    else if (component.GetType() == typeof(BoxCollisionComponent))
                    {
                        GameEngineEditor.instance.boxColliderEnableCheckBox.Checked = component.GetEnable();
                        GameEngineEditor.instance.boxColliderSizeXTextBox.Text = (((BoxCollisionComponent)component).size.X).ToString();
                        GameEngineEditor.instance.boxColliderSizeYTextBox.Text = (((BoxCollisionComponent)component).size.Y).ToString();
                    }
                    else if (component.GetType() == typeof(PositionComponent))
                    {
                        GameEngineEditor.instance.positionEnableCheckBox.Checked = component.GetEnable();
                        GameEngineEditor.instance.positionXTextBox.Text = (((PositionComponent)component).position.X).ToString();
                        GameEngineEditor.instance.positionYTextBox.Text = (((PositionComponent)component).position.Y).ToString();
                        GameEngineEditor.instance.positionAngularTextBox.Text = (((PositionComponent)component).orientation).ToString();
                    }
                    else if (component.GetType() == typeof(VelocityComponent))
                    {
                        GameEngineEditor.instance.velocityEnableCheckBox.Checked = component.GetEnable();
                        GameEngineEditor.instance.velocityMaxTextBox.Text = (((VelocityComponent)component).maxVelocity).ToString();
                    }
                    else if (component.GetType() == typeof(RenderComponent))
                    {
                        GameEngineEditor.instance.renderEnableCheckBox.Checked = component.GetEnable();
                        GameEngineEditor.instance.renderImageTextBox.Text = (((RenderComponent)component).image).ToString();
                        GameEngineEditor.instance.renderSizeXTextBox.Text = (((RenderComponent)component).size.X).ToString();
                        GameEngineEditor.instance.renderSizeYTextBox.Text = (((RenderComponent)component).size.Y).ToString();
                    }
                    else
                    {
                        throw new Exception("Unknow type detected.");
                    }
                }
            }
        }
        #endregion

        #region "Change data from GUI -- React on Event"
        public void GameTitleChanged()
        {
            gameProperties.gameName = GameEngineEditor.instance.gameTitleTextBox.Text;
        }
        public void GameWidthChanged()
        {
            gameProperties.screenWidth = Int32.Parse(GameEngineEditor.instance.widthTextBox.Text);
        }
        public void GameHeightChanged()
        {
            gameProperties.screenHeight = Int32.Parse(GameEngineEditor.instance.heightTextBox.Text);
        }

        public void SceneSelectedChanged()
        {
            UpdateSceneProperties();            
        }
        public void AddSceneClicked()
        {
            Scene newScene = new Scene();
            newScene.SetName("Scene" + _scenes.Count);
            newScene.SetBackgroundImage("background.png");
            _scenes.Add(newScene);

            UpdateSceneComboBoxValue();
        }
        public void RemoveSceneClicked()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;

            _scenes.RemoveAt(indexScene);

            UpdateSceneComboBoxValue();
        }
        public void SceneNameChanged()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;

            // UPDATE DATA
            if (indexScene >= 0)
            {
                _scenes[indexScene].SetName(GameEngineEditor.instance.sceneNameTextBox.Text);
                //GameEngineEditor.instance.sceneComboBox.Text = _scenes[indexScene].GetName();
            }
        }
        public void SceneBackgroundChanged()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;

            // UPDATE DATA
            if (indexScene >= 0)
                _scenes[indexScene].SetBackgroundImage(GameEngineEditor.instance.backgroundImgTextBox.Text);
        }

        public void EntitySelectedChanged()
        {
            UpdateEntityProperties();            
        }
        public void AddEntityClicked()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;

            Entity newEntity = new Entity();
            newEntity.SetName("Entity" + _scenes[indexScene].GetEntities().Count);

            newEntity.AddComponent(new InputComponent());
            newEntity.AddComponent(new PhysicsComponent());
            newEntity.AddComponent(new BoxCollisionComponent());
            newEntity.AddComponent(new PositionComponent());
            newEntity.AddComponent(new VelocityComponent());
            newEntity.AddComponent(new RenderComponent());

            _scenes[indexScene].AddEntity(newEntity);

            UpdateEntityComboBoxValue();
        }
        public void RemoveEntityClicked()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            _scenes[indexScene].RemoveEntity(indexEntity);

            UpdateEntityComboBoxValue();
        }
        public void EntityNameChanged()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;
            if (indexScene >= 0 && indexEntity >= 0)
            {
                _scenes[indexScene].GetEntities()[indexEntity].SetName(GameEngineEditor.instance.entityNameTextBox.Text);
            }
        }

        public void ComponentSelectedChanged()
        {
            UpdateComponentProperties();
        }

        #region "INPUT component callbacks"
        public void InputEnableChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                _scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(InputComponent)).SetEnable(GameEngineEditor.instance.inputEnableCheckBox.Checked);
            }
            else
            {
                HideComponentPanel();
            }
        }
        public void InputTweakerChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0 && float.TryParse(GameEngineEditor.instance.inputTweakerTextBox.Text, out float value))
            {
                ((InputComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(InputComponent)))).inputTweaker = value;
            }
        }
        #endregion

        #region "PHYSICS component callbacks"
        public void PhysicsEnableChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if(indexScene >= 0 && indexEntity >= 0)
            {
                _scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(PhysicsComponent)).SetEnable(GameEngineEditor.instance.physicsEnableCheckBox.Checked);
            }
            else
            {
                HideComponentPanel();
            }
        }
        public void MasseChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0 && Int32.TryParse(GameEngineEditor.instance.physicsMasseTextBox.Text, out Int32 value))
            {
                ((PhysicsComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(PhysicsComponent)))).masse = value;
            }
        }
        public void UseGravityChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                ((PhysicsComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(PhysicsComponent)))).useGravity = GameEngineEditor.instance.physicsGravityCheckBox.Checked;
            }
        }
        public void UseAirFrictionChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                ((PhysicsComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(PhysicsComponent)))).useAirFriction = GameEngineEditor.instance.physicsAirFrictionCheckBox.Checked;
            }
        }
        public void AirTweakerChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0 && float.TryParse(GameEngineEditor.instance.physicsAirTweakerTextBox.Text, out float value))
            {
                ((PhysicsComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(PhysicsComponent)))).airFrictionTweaker = value;
            }
        }
        #endregion

        #region "BOX COLLISION component callbacks"
        public void BoxCollisionEnableChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                _scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(BoxCollisionComponent)).SetEnable(GameEngineEditor.instance.boxColliderEnableCheckBox.Checked);
            }
            else
            {
                HideComponentPanel();
            }
        }
        public void BoxCollisionSizeXChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;
            

            if (indexScene >= 0 && indexEntity >= 0 && float.TryParse(GameEngineEditor.instance.boxColliderSizeXTextBox.Text, out float value))
            {
                ((BoxCollisionComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(BoxCollisionComponent)))).size.X = value;
            }
        }
        public void BoxCollisionSizeYChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0 && float.TryParse(GameEngineEditor.instance.boxColliderSizeYTextBox.Text, out float value))
            {
                ((BoxCollisionComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(BoxCollisionComponent)))).size.Y = value;
            }
        }
        #endregion

        #region "POSITION component callbacks"
        public void PositionEnableChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                _scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(PositionComponent)).SetEnable(GameEngineEditor.instance.positionEnableCheckBox.Checked);
            }
            else
            {
                HideComponentPanel();
            }
        }
        public void PositionXChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0 && float.TryParse(GameEngineEditor.instance.positionXTextBox.Text, out float value))
            {
                ((PositionComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(PositionComponent)))).position.X = value;
            }
        }
        public void PositionYChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0 && float.TryParse(GameEngineEditor.instance.positionYTextBox.Text, out float value))
            {
                ((PositionComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(PositionComponent)))).position.Y = value;
            }
        }
        public void OrientationChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0 && float.TryParse(GameEngineEditor.instance.positionAngularTextBox.Text, out float value))
            {
                ((PositionComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(PositionComponent)))).orientation = value;
            }
        }
        #endregion

        #region "VELOCITY component callbacks"
        public void VelocityEnableChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                _scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(VelocityComponent)).SetEnable(GameEngineEditor.instance.velocityEnableCheckBox.Checked);
            }
            else
            {
                HideComponentPanel();
            }
        }
        public void MaxVelocityChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0 && float.TryParse(GameEngineEditor.instance.velocityMaxTextBox.Text, out float value))
            {
                ((VelocityComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(VelocityComponent)))).maxVelocity = value;
            }
        }
        #endregion

        #region "RENDER component callbacks"
        public void RenderEnableChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0)
            {
                _scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(RenderComponent)).SetEnable(GameEngineEditor.instance.renderEnableCheckBox.Checked);
            }
            else
            {
                HideComponentPanel();
            }
        }
        public void ImageChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0 )
            {
                ((RenderComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(RenderComponent)))).image = GameEngineEditor.instance.renderImageTextBox.Text;
            }
        }
        public void ImageSizeXChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0 && float.TryParse(GameEngineEditor.instance.renderSizeXTextBox.Text, out float value))
            {
                ((RenderComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(RenderComponent)))).size.X = value;
            }
        }
        public void ImageSizeYChanged() {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene >= 0 && indexEntity >= 0 && float.TryParse(GameEngineEditor.instance.renderSizeYTextBox.Text, out float value))
            {
                ((RenderComponent)(_scenes[indexScene].GetEntities()[indexEntity].GetComponentOfType(typeof(RenderComponent)))).size.Y = value;
            }
        }
        #endregion

        #endregion

        #region "Import Section"

        public void ImportDataFromXML(Stream stream)
        {
            // Reset old params
            _scenes.Clear();

            // Load doc
            XDocument doc = XDocument.Load(stream);
            ImportGameProperties(doc);
            ImportGameContent(doc);

            // Update Editor value GUI
            // Game properties
            UpdateGamePropertiesEditorValue();

            // Scene properties
            UpdateSceneComboBoxValue();

            // Hide component panel to avoid miss moves
            HideComponentPanel();
        }     
        /// <summary>
        /// Load xml file (allow us to create game without editor, you can go directly inside the xml file if you want)
        /// </summary>
        public void ImportGameContent(XDocument doc)
        {
            // Scenes
            XElement scenes = doc.Element("Game.xml").Element("GameContent").Element("Scenes");
            foreach (XElement scene in scenes.Elements())
            {
                ImportScene(_scenes, scene);
            }
        }
        public void ImportScene(List<Scene> _scenes, XElement scene)
        {
            // Scene
            Scene currentScene = new Scene();
            currentScene.SetName(scene.Attribute("Name").Value);
            currentScene.SetBackgroundImage(scene.Element("BackgroundImage").Value);
            _scenes.Add(currentScene);

            // Elements
            XElement entityElements = scene.Element("Entities");
            foreach (XElement entityElement in entityElements.Elements())
            {
                ImportEntity(currentScene, entityElement);
            }
        }
        public void ImportEntity(Scene currentScene, XElement entity)
        {
            // Element
            Entity currentEntity = new Entity();
            currentEntity.SetName(entity.FirstAttribute.Value);
            currentScene.GetEntities().Add(currentEntity);

            currentEntity.AddComponent(new InputComponent());
            currentEntity.AddComponent(new PhysicsComponent());
            currentEntity.AddComponent(new BoxCollisionComponent());
            currentEntity.AddComponent(new PositionComponent());
            currentEntity.AddComponent(new VelocityComponent());
            currentEntity.AddComponent(new RenderComponent());

            // Components
            XElement components = entity.Element("Components");
            foreach (XElement component in components.Elements())
            {
                ImportComponentValues(currentEntity, component);
            }
        }
        public void ImportComponentValues(Entity currentEntity, XElement component)
        {
            //Component
            switch (component.Attribute("Type").Value)
            {
                case "Input":
                    InputComponent inputcomponent = ((InputComponent)currentEntity.GetComponentOfType(typeof(InputComponent)));
                    inputcomponent.SetEnable(true);
                    inputcomponent.inputTweaker = float.Parse(component.Element("inputTweaker").Value);
                    break;
                case "Physics":
                    PhysicsComponent physicsComponent = ((PhysicsComponent)currentEntity.GetComponentOfType(typeof(PhysicsComponent)));
                    physicsComponent.SetEnable(true);
                    physicsComponent.masse = int.Parse(component.Element("masse").Value);
                    physicsComponent.useGravity = bool.Parse(component.Element("useGravity").Value);
                    physicsComponent.useAirFriction = bool.Parse(component.Element("useAirFriction").Value);
                    physicsComponent.airFrictionTweaker = float.Parse(component.Element("airFrictionTweaker").Value);
                    break;
                case "BoxCollision":
                    BoxCollisionComponent boxCollisionComponent = ((BoxCollisionComponent)currentEntity.GetComponentOfType(typeof(BoxCollisionComponent)));
                    boxCollisionComponent.SetEnable(true);
                    boxCollisionComponent.size.X = float.Parse(component.Element("sizeX").Value);
                    boxCollisionComponent.size.Y = float.Parse(component.Element("sizeY").Value);
                    break;
                case "Position":
                    PositionComponent positionComponent = ((PositionComponent)currentEntity.GetComponentOfType(typeof(PositionComponent)));
                    positionComponent.SetEnable(true);
                    positionComponent.position.X = float.Parse(component.Element("posX").Value);
                    positionComponent.position.Y = float.Parse(component.Element("posY").Value);
                    positionComponent.orientation = float.Parse(component.Element("orientation").Value);
                    break;
                case "Velocity":
                    VelocityComponent velocityComponent = ((VelocityComponent)currentEntity.GetComponentOfType(typeof(VelocityComponent)));
                    velocityComponent.SetEnable(true);
                    velocityComponent.maxVelocity = float.Parse(component.Element("maxVelocity").Value);
                    break;
                case "Render":
                    RenderComponent renderComponent = ((RenderComponent)currentEntity.GetComponentOfType(typeof(RenderComponent)));
                    renderComponent.SetEnable(true);
                    renderComponent.image = component.Element("image").Value;
                    renderComponent.size.X = int.Parse(component.Element("sizeX").Value);
                    renderComponent.size.Y = int.Parse(component.Element("sizeY").Value);
                    break;
                default:
                    throw new Exception("Undefined Component");
            }
        }
        /// <summary>
        /// Load game properties from xml file
        /// </summary>
        public void ImportGameProperties(XDocument doc)
        {
            gameProperties = new GameProperties();
            XElement gamePropertyElement = doc.Element("Game.xml").Element("GameProperties");

            gameProperties.gameName = gamePropertyElement.Element("Name").Value;
            gameProperties.screenWidth = Int32.Parse(gamePropertyElement.Element("Width").Value);
            gameProperties.screenHeight = Int32.Parse(gamePropertyElement.Element("Height").Value);
        }
        /// <summary>
        /// Load game properties from xml file
        /// </summary>
        public void ExportGameProperties(XDocument doc)
        {
            doc.Element("Game.xml").Add(new XElement("GameProperties",
                new XElement("Name", gameProperties.gameName),
                new XElement("Width", gameProperties.screenWidth),
                new XElement("Height", gameProperties.screenHeight))
                );
        }
        #endregion

        #region "Export Section"
        /// <summary>
        /// Load xml file (allow us to create game without editor, you can go directly inside the xml file if you want)
        /// </summary>
        public void ExportGameContent(XDocument doc)
        {
            doc.Element("Game.xml").Add(new XElement("GameContent",
                 new XElement("Scenes"))
                 );
            XElement scenes = doc.Element("Game.xml").Element("GameContent").Element("Scenes");
            foreach(Scene scene in _scenes)
            {
                AddSceneToDoc(scenes, scene);                
            }
        }
        public void ExportDataToXML(Stream stream)
        {
            XDocument doc = new XDocument(new XElement("Game.xml"));
            ExportGameProperties(doc);
            ExportGameContent(doc);
            doc.Save(stream);
        }
        private void AddSceneToDoc(XElement scenes, Scene scene)
        {
            XElement currentScene = new XElement("Scene", new XAttribute("Name", scene.GetName()));
            currentScene.Add(new XElement("BackgroundImage", scene.GetBackgroundImage()));
            XElement entities = new XElement("Entities");
            currentScene.Add(entities);
            scenes.Add(currentScene);          
            foreach (Entity entity in scene.GetEntities())
            {
                AddEntityToDoc(entities, entity);
            }
        }
        private void AddEntityToDoc(XElement entities, Entity entity)
        {
            XElement currentEntity = new XElement("Entity", new XAttribute("Name", entity.GetName()));
            XElement components = new XElement("Components");
            currentEntity.Add(components);
            entities.Add(currentEntity);
            foreach (IComponent component in entity.GetComponents())
            {
                if(component.GetEnable())
                    AddComponentToDoc(components, component);
            }
        }
        private void AddComponentToDoc(XElement components, IComponent component)
        {
            XElement currentComponent = new XElement("Component");
            if (component.GetType() == typeof(InputComponent))
            {                
                currentComponent.Add(new XAttribute("Type", "Input"));
                currentComponent.Add(new XElement("inputTweaker", ((InputComponent)component).inputTweaker));               
            }
            else if (component.GetType() == typeof(PhysicsComponent))
            {                
                currentComponent.Add(new XAttribute("Type", "Physics"));
                currentComponent.Add(new XElement("masse", ((PhysicsComponent)component).masse));
                currentComponent.Add(new XElement("useGravity", ((PhysicsComponent)component).useGravity));
                currentComponent.Add(new XElement("useAirFriction", ((PhysicsComponent)component).useAirFriction));
                currentComponent.Add(new XElement("airFrictionTweaker", ((PhysicsComponent)component).airFrictionTweaker));
            }
            else if (component.GetType() == typeof(BoxCollisionComponent))
            {
                currentComponent.Add(new XAttribute("Type", "BoxCollision"));
                currentComponent.Add(new XElement("sizeX", ((BoxCollisionComponent)component).size.X));
                currentComponent.Add(new XElement("sizeY", ((BoxCollisionComponent)component).size.Y));
            }
            else if (component.GetType() == typeof(PositionComponent))
            {
                currentComponent.Add(new XAttribute("Type", "Position"));
                currentComponent.Add(new XElement("posX", ((PositionComponent)component).position.X));
                currentComponent.Add(new XElement("posY", ((PositionComponent)component).position.Y));
                currentComponent.Add(new XElement("orientation", ((PositionComponent)component).orientation));
            }
            else if (component.GetType() == typeof(VelocityComponent))
            {
                currentComponent.Add(new XAttribute("Type", "Velocity"));
                currentComponent.Add(new XElement("maxVelocity", ((VelocityComponent)component).maxVelocity));
            }
            else if (component.GetType() == typeof(RenderComponent))
            {
                currentComponent.Add(new XAttribute("Type", "Render"));
                currentComponent.Add(new XElement("image", ((RenderComponent)component).image));
                currentComponent.Add(new XElement("sizeX", ((RenderComponent)component).size.X));
                currentComponent.Add(new XElement("sizeY", ((RenderComponent)component).size.Y));
            }
            else
            {
                throw new Exception("Unknow type detected.");
            }
            components.Add(currentComponent);
        }
        #endregion

        public struct GameProperties
        {
            public string gameName;
            public int screenWidth;
            public int screenHeight;
        }

    }
}
