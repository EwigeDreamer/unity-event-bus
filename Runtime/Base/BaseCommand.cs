using System;

namespace ED.EventBus.Base
{
    public abstract class BaseCommand
    {
        internal abstract void Dispose();
    }
}