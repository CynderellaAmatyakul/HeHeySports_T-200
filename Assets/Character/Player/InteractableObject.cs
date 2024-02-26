using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Character.Player
{
    public class InteractableObject : MonoBehaviour, IInteracttion
    {
        [SerializeField] private UnityEvent _onInteract;

        UnityEvent IInteracttion.onInteract
        {
            get => _onInteract;
            set => _onInteract = value;
        }

        public void Interact() => _onInteract.Invoke();
    }
}
