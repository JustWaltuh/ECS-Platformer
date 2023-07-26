using Leopotam.Ecs;

namespace NTC.Source.Code.Ecs
{
    sealed class MovementSystem : IEcsRunSystem
    {
        private readonly EcsWorld _world = null;

        private readonly EcsFilter<MovableComponent> movableFilter = null;

        public void Run()
        {
            
        }
    }
}