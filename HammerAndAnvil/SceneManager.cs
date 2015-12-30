using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HA.Scenes;

namespace HA
{
    class SceneManager
    {
        Task sceneTask;
        public SceneManager(IScene startScene)
        {
            currentScene = startScene;
            sceneTask = new Task(currentScene.Run);
            sceneTask.Start();
        }
        IScene currentScene;
        IScene queuedScene;

        public IScene CurrentScene
        {
            get
            {
                return currentScene;
            }
        }
        public void ChangeScene(IScene scene)
        {
            queuedScene = scene;
            new Task(ChangeTask).Start();
        }
        void ChangeTask()
        {
            bool changed = false;
            while (!changed)
            {
                if (sceneTask.IsCompleted)
                {
                    currentScene = queuedScene;
                    changed = true;
                }
            }
            Console.Clear();
            sceneTask.Dispose();
            sceneTask = new Task(currentScene.Run);
            sceneTask.Start();
        }
    }
}
