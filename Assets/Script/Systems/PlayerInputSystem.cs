using Leopotam.Ecs;
using UnityEngine;

namespace NTC.Source.Code.Ecs
{
    sealed class PlayerInputSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ModelComponent, PlayerTag, DirectionComponent> directionFilter = null;

        private float _moveDirection;

        public void Run()
        {
            SetDirection();

            foreach (var i in directionFilter)
            {
                ref var directionComponent = ref directionFilter.Get3(i);
                ref var direction = ref directionComponent.Direction;

                direction.x = _moveDirection;
            }
        }

        private void SetDirection()
        {
            _moveDirection = Input.GetAxis("Horizontal"); 
        }
    }
}
