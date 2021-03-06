﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Space394.Collision;
using BEPUphysics.Entities.Prefabs;

namespace Space394.SceneObjects
{
    public class HalkTurret : Turret
    {
        public HalkTurret(long _uniqueId, Vector3 _position, Quaternion _rotation, Vector3 _fireConeNormal, float _fireConeAngle, Battleship _parent)
            : base(_uniqueId, _position, _rotation, "Models/Ships/HalkTurretBall", _fireConeNormal, _fireConeAngle, _parent)
        {
            // CollisionBase = new CollisionSphere(_position, 10);
            team = Ship.Team.Halk;
        }
    }
}
