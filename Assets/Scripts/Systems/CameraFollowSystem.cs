using Leopotam.Ecs;
using UnityEngine;

namespace NTC.Source.Code.Ecs
{
    sealed class CameraFollowSystem : IEcsRunSystem
    {
        private readonly EcsFilter<CameraComponent> cameraFilter = null;

        public void Run()
        {
            foreach (var i in cameraFilter)
            {
                ref var cameraComponent = ref cameraFilter.Get1(i);

                ref var cameraTransform = ref cameraComponent.cameraTransform;
                ref var playerTransform = ref cameraComponent.playerTransform;
                ref var cameraOffset = ref cameraComponent.offset;

                cameraTransform.position = playerTransform.position + cameraOffset;
            }
        }
    }
}
