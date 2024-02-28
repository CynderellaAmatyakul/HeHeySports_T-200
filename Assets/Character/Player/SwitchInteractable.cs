using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Character.Player
{
    public class SwitchInteractable : MonoBehaviour, IInteracttion
    {
        private bool isOn;
        [SerializeField] private UnityEvent _stopInteract;
        [SerializeField] private UnityEvent _onInteract;

        UnityEvent IInteracttion.onInteract
        {
            get => _onInteract;
            set => _onInteract = value;
        }

        public void Interact()
        {
            if (isOn)
            {
                _stopInteract.Invoke();
            }
            else
            {
                _onInteract.Invoke();
            }

            isOn = !isOn;
        }
    }
}
