using UnityEngine;

interface IInteractable
{
    public void Interact();
    public void StopInteract() { }
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange = 3f;
    private IInteractable currentInteractable;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentInteractable == null)
        {
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hit, InteractRange))
            {
                if (hit.collider.TryGetComponent(out IInteractable interactable))
                {
                    currentInteractable = interactable;
                    currentInteractable.Interact();
                    
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && currentInteractable != null)
        {
            currentInteractable.StopInteract();
            currentInteractable = null;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
