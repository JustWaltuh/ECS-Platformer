using UnityEngine;
using System;

namespace NTC.Source.Code.Ecs
{
    [Serializable]
    public struct CameraComponent
    {
        //Потом нужно будет передать ссылку на объект игрока через код. Возможно через DI контейнер
        public Transform cameraTransform;
        public Transform playerTransform;
        public Vector3 offset;
    }
}