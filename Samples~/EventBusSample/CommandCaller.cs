using ED.EventBus;
using UnityEngine;

namespace Ed.EventBus.Samples
{
    public class CommandCaller : MonoBehaviour
    {
        private void Start()
        {
            Bus.Global.GetChannel<PlayerChannel>()
                .GetCommand<PlayerChannel.Respawn>()
                .Call(Vector3.forward, Quaternion.LookRotation(Vector3.back));
            Bus.Global.GetChannel<PlayerChannel>()
                .GetCommand<PlayerChannel.GiveAmmo>()
                .Call(10);
        }
    }
}