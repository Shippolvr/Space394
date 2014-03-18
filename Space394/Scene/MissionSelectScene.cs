﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Space394.Scenes
{
    public class MissionSelectScene : Scene
    {
        public MissionSelectScene()
            : base()
        {

        }

        public override void Update(float deltaTime) { }

        public override void Draw() { }

        public override Space394Game.sceneEnum GetNextScene()
        {
            return Space394Game.sceneEnum.LoadingScene;
        }

        public override void Exit(Scene nextScene)
        {
            SceneObjects.Clear();
            base.Exit(nextScene);
        }
    }
}
