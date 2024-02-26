using Assets.Character.Player;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactions : MonoBehaviour
{
    [SerializeField] private LayerMask interactableLayer;
    private PlayerInput _playerInput;
    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
        _playerInput = GetComponent<PlayerInput>();
    }

    private void OnEnable()
    {
        _playerInput.actions["Interact"].performed += DoInteract;
    }

    private void OnDisable()
    {
        _playerInput.actions["Interact"].performed -= DoInteract;
    }

    private void DoInteract(InputAction.CallbackContext context)
    {
        //Raycast
        if (!Physics.Raycast(transform.position + (Vector3.up * 0.3f) + (_transform.forward * 0.2f), transform.forward, out var hit, 1.5f, interactableLayer)) return;

        if (!hit.transform.TryGetComponent(out InteractableObject interactable)) return;
        interactable.Interact();
        Debug.Log("Interact");
    }
}
