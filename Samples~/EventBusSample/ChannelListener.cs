using ED.EventBus.Logic;
using UnityEngine;

namespace Ed.EventBus.Samples
{
    public class ChannelListener : MonoBehaviour
    {
        private void Awake()
        {
            Bus.GetChannel<PlayerChannel>()
                .GetSignal<PlayerChannel.Spawned>()
                .AddListener(OnSpawn);
            Bus.GetChannel<PlayerChannel>()
                .GetSignal<PlayerChannel.Killed>()
                .AddListener(OnKill);
            Bus.GetChannel<PlayerChannel>()
                .GetSignal<PlayerChannel.LevelUp>()
                .AddListener(OnLevelUp);
            
            Bus.GetChannel<PlayerChannel>()
                .GetCommand<PlayerChannel.Respawn>()
                .AddListener(Respawn);
            Bus.GetChannel<PlayerChannel>()
                .GetCommand<PlayerChannel.GiveAmmo>()
                .AddListener(GiveAmmo);
        }

        private void OnDestroy()
        {
            Bus.GetChannel<PlayerChannel>()
                .GetSignal<PlayerChannel.Spawned>()
                .RemoveListener(OnSpawn);
            Bus.GetChannel<PlayerChannel>()
                .GetSignal<PlayerChannel.Killed>()
                .RemoveListener(OnKill);
            Bus.GetChannel<PlayerChannel>()
                .GetSignal<PlayerChannel.LevelUp>()
                .RemoveListener(OnLevelUp);
            
            Bus.GetChannel<PlayerChannel>()
                .GetCommand<PlayerChannel.Respawn>()
                .RemoveListener(Respawn);
            Bus.GetChannel<PlayerChannel>()
                .GetCommand<PlayerChannel.GiveAmmo>()
                .RemoveListener(GiveAmmo);
        }

        private void OnSpawn(Vector3 position, Quaternion rotation) => Debug.Log($"Spawned at position {position} and rotation {rotation}");
        private void OnKill(Vector3 position) => Debug.Log($"Killed at position {position}");
        private void OnLevelUp() => Debug.Log($"Level up!");

        private void Respawn(Vector3 position, Quaternion rotation)
        {
            // respawn logic
            Debug.Log($"Respawn {position} {rotation}");
        }
        private void GiveAmmo(int count)
        {
            // giving ammo logic
            Debug.Log($"Giving ammo {count}");
        }
    }
}