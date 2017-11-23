using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameEngineEditor
{
    class Scene
    {
        private string name = "Unknown";
        private string backgroundImage;

        private List<Entity> _entities = new List<Entity>();

        public void AddEntity(Entity entity)
        {
            _entities.Add(entity);
        }

        public List<Entity> GetEntities()
        {
            return _entities;
        }

        public void RemoveEntity(Entity entity)
        {
            _entities.Remove(entity);
        }

        // Get & Set
        public void SetName(string sceneName){name = sceneName;}
        public string GetName(){return name;}

        public void SetBackgroundImage(string imageName) { backgroundImage = imageName; }
        public string GetBackgroundImage() { return backgroundImage; }
    }
}
