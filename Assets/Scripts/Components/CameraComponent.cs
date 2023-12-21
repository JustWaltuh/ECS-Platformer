using UnityEngine;
using System;

namespace NTC.Source.Code.Ecs
{
    [Serializable]
    public struct CameraComponent
    {
        //����� ����� ����� �������� ������ �� ������ ������ ����� ���. �������� ����� DI ���������
        public Transform cameraTransform;
        public Transform playerTransform;
        public Vector3 offset;
    }
}