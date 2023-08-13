using UnityEngine;
using System;

namespace NTC.Source.Code.Ecs
{
    [Serializable]
    public struct MovableComponent
    {
        public CharacterController characterController;
        public float speed;
    }
}