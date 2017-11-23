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
        }

        public void UpdateSceneProperties()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            GameEngineEditor.instance.sceneNameTextBox.Text = _scenes[indexScene].GetName();
            GameEngineEditor.instance.backgroundImgTextBox.Text = _scenes[indexScene].GetBackgroundImage();

            UpdateEntityComboBoxValue();
        }

        private void UpdateEntityComboBoxValue()
        {            
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;

            GameEngineEditor.instance.entityComboBox.Items.Clear();
            foreach (Entity entity in _scenes[indexScene].GetEntities())
            {
                GameEngineEditor.instance.entityComboBox.Items.Add(entity.GetName());
            }            
        }

        public void UpdateEntityProperties()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;
            GameEngineEditor.instance.entityNameTextBox.Text = _scenes[indexScene].GetEntities()[indexEntity].GetName();

            UpdateComponentValue();
            ClearComponentPanel();
        }

        public void ShowCorrectComponentPanel()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;
            string componentPanelComboBoxText = GameEngineEditor.instance.componentComboBox.SelectedItem.ToString();

            ClearComponentPanel();

            if(indexScene <= 0 && indexEntity <= 0)
            {
                switch (componentPanelComboBoxText)
                {
                    case ("Input"):
                        GameEngineEditor.instance.inputCompPanel.Visible = true;
                        break;
                    case ("Physics"):
                        GameEngineEditor.instance.physicsCompPanel.Visible = true;
                        break;
                    case ("BoxCollider"):
                        GameEngineEditor.instance.boxColliderCompPanel.Visible = true;
                        break;
                    case ("Position"):
                        GameEngineEditor.instance.positionCompPanel.Visible = true;
                        break;
                    case ("Velocity"):
                        GameEngineEditor.instance.velocityCompPanel.Visible = true;
                        break;
                    case ("Render"):
                        GameEngineEditor.instance.renderCompPanel.Visible = true;
                        break;
                    default:

                        break;
                }

            }
        }

        public void ClearComponentPanel()
        {
            GameEngineEditor.instance.inputCompPanel.Visible = false;
            GameEngineEditor.instance.physicsCompPanel.Visible = false;
            GameEngineEditor.instance.boxColliderCompPanel.Visible = false;
            GameEngineEditor.instance.positionCompPanel.Visible = false;
            GameEngineEditor.instance.velocityCompPanel.Visible = false;
            GameEngineEditor.instance.renderCompPanel.Visible = false;

        }

        private void UpdateComponentValue()
        {
            int indexScene = GameEngineEditor.instance.sceneComboBox.SelectedIndex;
            int indexEntity = GameEngineEditor.instance.entityComboBox.SelectedIndex;

            if (indexScene <= 0 && indexEntity <= 0)
            {
                foreach (IComponent component in _scenes[indexScene].GetEntities()[indexEntity].GetComponents())
                {
                    if (component.GetType() == typeof(InputComponent))
                    {
                        GameEngineEditor.instance.inputEnableCheckBox.Checked = true;
                        GameEngineEditor.instance.inputTweakerTextBox.Text = (((InputComponent)component).inputTweaker).ToString();
                    }
                    else if (component.GetType() == typeof(PhysicsComponent))
                    {
                        GameEngineEditor.instance.physicsEnableCheckBox.Checked = true;
                        GameEngineEditor.instance.physicsMasseTextBox.Text = (((PhysicsComponent)component).masse).ToString();
                        GameEngineEditor.instance.physicsGravityCheckBox.Checked = ((PhysicsComponent)component).useGravity;
                        GameEngineEditor.instance.physicsAirFrictionCheckBox.Checked = ((PhysicsComponent)component).useAirFriction;
                        GameEngineEditor.instance.physicsAirTweakerTextBox.Text = (((PhysicsComponent)component).airFrictionTweaker).ToString();
                    }
                    else if (component.GetType() == typeof(BoxCollisionComponent))
                    {
                        GameEngineEditor.instance.boxColliderEnableCheckBox.Checked = true;
                        GameEngineEditor.instance.boxColliderSizeXTextBox.Text = (((BoxCollisionComponent)component).size.X).ToString();
                        GameEngineEditor.instance.boxColliderSizeYTextBox.Text = (((BoxCollisionComponent)component).size.Y).ToString();
                    }
                    else if (component.GetType() == typeof(PositionComponent))
                    {
                        GameEngineEditor.instance.positionEnableCheckBox.Checked = true;
                        GameEngineEditor.instance.positionXTextBox.Text = (((PositionComponent)component).position.X).ToString();
                        GameEngineEditor.instance.positionYTextBox.Text = (((PositionComponent)component).position.Y).ToString();
                        GameEngineEditor.instance.positionAngularTextBox.Text = (((PositionComponent)component).orientation).ToString();
                    }
                    else if (component.GetType() == typeof(VelocityComponent))
                    {
                        GameEngineEditor.instance.velocityEnableCheckBox.Checked = true;
                        GameEngineEditor.instance.velocityMaxTextBox.Text = (((VelocityComponent)component).maxVelocity).ToString();
                    }
                    else if (component.GetType() == typeof(RenderComponent))
                    {
                        GameEngineEditor.instance.inputEnableCheckBox.Checked = true;
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

        public void ImportDataFromXML(Stream stream)
        {
            XDocument doc = XDocument.Load(stream);
            ImportGameProperties(doc);
            ImportGameContent(doc);

            // Update Editor value GUI
            // Game properties
            UpdateGamePropertiesEditorValue();

            // Scene properties
            UpdateSceneComboBoxValue();

            // Clear component panel to avoid miss moves
            ClearComponentPanel();
        }

        public void ExportDataToXML(Stream stream)
        {
            XDocument doc = new XDocument(new XElement("Game.xml"));
            ExportGameProperties(doc);
            ExportGameContent(doc);
            doc.Save(stream);
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

            // Components
            XElement components = entity.Element("Components");
            foreach (XElement component in components.Elements())
            {
                ImportComponent(currentEntity, component);
            }
        }

        public void ImportComponent(Entity currentEntity, XElement component)
        {
            //Component
            switch (component.Attribute("Type").Value)
            {
                case "Input":
                    InputComponent inputComponent = new InputComponent();
                    inputComponent.inputTweaker = float.Parse(component.Element("inputTweaker").Value);
                    currentEntity.AddComponent(inputComponent);
                    break;
                case "Physics":
                    PhysicsComponent physicsComponent = new PhysicsComponent();
                    physicsComponent.masse = int.Parse(component.Element("masse").Value);
                    physicsComponent.useGravity = bool.Parse(component.Element("useGravity").Value);
                    physicsComponent.useAirFriction = bool.Parse(component.Element("useAirFriction").Value);
                    physicsComponent.airFrictionTweaker = float.Parse(component.Element("airFrictionTweaker").Value);
                    currentEntity.AddComponent(physicsComponent);
                    break;
                case "BoxCollision":
                    BoxCollisionComponent boxCollisionComponent = new BoxCollisionComponent();
                    boxCollisionComponent.size.X = float.Parse(component.Element("sizeX").Value);
                    boxCollisionComponent.size.Y = float.Parse(component.Element("sizeY").Value);
                    currentEntity.AddComponent(boxCollisionComponent);
                    break;
                case "Position":
                    PositionComponent positionComponent = new PositionComponent();
                    positionComponent.position.X = float.Parse(component.Element("posX").Value);
                    positionComponent.position.Y = float.Parse(component.Element("posY").Value);
                    positionComponent.orientation = float.Parse(component.Element("orientation").Value);
                    currentEntity.AddComponent(positionComponent);
                    break;
                case "Velocity":
                    VelocityComponent velocityComponent = new VelocityComponent();
                    velocityComponent.maxVelocity = float.Parse(component.Element("maxVelocity").Value);
                    currentEntity.AddComponent(velocityComponent);
                    break;
                case "Render":
                    RenderComponent renderComponent = new RenderComponent();
                    renderComponent.image = component.Element("image").Value;
                    renderComponent.size.X = int.Parse(component.Element("sizeX").Value);
                    renderComponent.size.Y = int.Parse(component.Element("sizeY").Value);
                    currentEntity.AddComponent(renderComponent);
                    break;
                default:
                    throw new Exception("Undefined Component");
            }
        }

        public struct GameProperties
        {
            public string gameName;
            public int screenWidth;
            public int screenHeight;
        }


    }
}
