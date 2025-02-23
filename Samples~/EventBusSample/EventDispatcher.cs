using ED.EventBus;
using UnityEngine;

namespace Ed.EventBus.Samples
{
    public class EventDispatcher : MonoBehaviour
    {
        private void Start()
        {
            Bus.Global.GetChannel<PlayerChannel>()
                .GetSignal<PlayerChannel.Spawned>()
                .Dispatch(Vector3.one, Quaternion.LookRotation(Vector3.right));
            Bus.Global.GetChannel<PlayerChannel>()
                .GetSignal<PlayerChannel.Killed>()
                .Dispatch(Vector3.left);
            Bus.Global.GetChannel<PlayerChannel>()
                .GetSignal<PlayerChannel.LevelUp>()
                .Dispatch();
        }
    }
}