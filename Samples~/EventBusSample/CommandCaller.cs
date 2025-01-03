using ED.EventBus.Logic;
using UnityEngine;

namespace Ed.EventBus.Samples
{
    public class CommandCaller : MonoBehaviour
    {
        private void Start()
        {
            Bus.GetChannel<PlayerChannel>()
                .GetCammand<PlayerChannel.Respawn>()
                .Call(Vector3.forward, Quaternion.LookRotation(Vector3.back));
            Bus.GetChannel<PlayerChannel>()
                .GetCammand<PlayerChannel.GiveAmmo>()
                .Call(10);
        }
    }
}