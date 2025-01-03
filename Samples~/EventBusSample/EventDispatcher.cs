using ED.EventBus.Logic;
using UnityEngine;

namespace Ed.EventBus.Samples
{
    public class EventDispatcher : MonoBehaviour
    {
        private void Start()
        {
            Bus.GetChannel<PlayerChannel>()
                .GetSignal<PlayerChannel.Spawned>()
                .Dispatch(Vector3.one, Quaternion.LookRotation(Vector3.right));
            Bus.GetChannel<PlayerChannel>()
                .GetSignal<PlayerChannel.Killed>()
                .Dispatch(Vector3.left);
            Bus.GetChannel<PlayerChannel>()
                .GetSignal<PlayerChannel.LevelUp>()
                .Dispatch();
        }
    }
}