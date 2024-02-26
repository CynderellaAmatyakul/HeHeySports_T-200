using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Events;

namespace Assets.Character.Player
{
    public interface IInteracttion
    {
        public UnityEvent onInteract { get; protected set; }
        public void Interact();
    }
}
