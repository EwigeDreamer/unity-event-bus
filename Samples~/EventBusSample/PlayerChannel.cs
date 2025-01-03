using ED.EventBus.Base;
using ED.EventBus.Signals;
using UnityEngine;

namespace Ed.EventBus.Samples
{
    public class PlayerChannel : BaseChannel
    {
        public class Spawned : Signal<Vector3, Quaternion> { }
        public class Killed : Signal<Vector3> { }
        public class LevelUp : Signal { }
        public class Respawn : Command<Vector3, Quaternion> { }
        public class GiveAmmo : Command<int> { }
    }
}