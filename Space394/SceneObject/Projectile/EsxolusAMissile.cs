﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Space394.Collision;
using BEPUphysics.Entities.Prefabs;


namespace Space394.SceneObjects
{
    public class EsxolusAMissile : Missile
    {
        private const float WANDER_INFLUENCE = 2.5f;
        private const float MISSILE_SPEED = 4500.0f;

        private const float RESIZE = 50.0f;

        public EsxolusAMissile(long _uniqueID, Vector3 _position, Quaternion _rotation)
            : base(_uniqueID, _position, _rotation, "Models/Ships/esxolus_assault_fighter_missile_model")
        {
            Damage = 25.0f;

            projectileSpeed = MISSILE_SPEED;

            ((Sphere)detectionSphere.getPhysicsCollider()).CollisionInformation.CollisionRules.Group = esxolusProjectileGroup;

            CollisionBase.Active = false;
            CollisionBase.Parent = this;
        }

        public override void onCollide(SceneObject caller, float damage)
        {
            if (Parent != null && caller != null && Parent != caller)
            {
                ProjectileManager.addEsxolusAMissile(this);

                base.onCollide(caller, damage);
            }
            else { }
        }
    }
}