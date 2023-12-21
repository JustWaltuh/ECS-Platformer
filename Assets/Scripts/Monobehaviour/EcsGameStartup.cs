using UnityEngine;
using Leopotam.Ecs;
using Voody.UniLeo;

namespace NTC.Source.Code.Ecs
{
    public sealed class EcsGameStartup : MonoBehaviour
    {
        private EcsWorld _world;
        private EcsSystems _systems;

        private void Start()
        {
            _world = new EcsWorld();
            _systems = new EcsSystems(_world);

            _systems.ConvertScene();

            AddInjections();
            AddOneFrames();
            AddSystems();

            _systems.Init();
        }

        private void AddInjections()
        {

        }

        private void AddSystems()
        {
            _systems.
                Add(new PlayerJumpSendEventSystem()).
                Add(new GroundCheckSystem()).
                Add(new PlayerInputSystem()).
                Add(new PlayerJumpSystem()).
                Add(new MovementSystem());
        }

        private void AddOneFrames()
        {
            _systems.OneFrame<JumpEvent>();
        }

        private void Update()
        {
            _systems.Run();
        }

        private void OnDestroy()
        {
            if (_systems == null)
                return;

            _systems.Destroy();
            _systems = null;
            _world.Destroy();
            _world = null;
        }
    }
}
