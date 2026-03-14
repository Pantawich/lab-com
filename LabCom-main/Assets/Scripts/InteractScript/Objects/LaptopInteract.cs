using UnityEngine;

public class LaptopInteract : MonoBehaviour, IInteractable
{
    public GameObject LaptopUI;
    public Camera mainCamera;
    public Camera laptopCamera;
    public PlayerMovement PlayerMovement;    
    public void Interact()
    {
        if (mainCamera != null) mainCamera.enabled = false;
        if (laptopCamera != null) laptopCamera.enabled = true;

        if (LaptopUI != null) LaptopUI.SetActive(true);

        if (PlayerMovement != null) PlayerMovement.enabled = false;
    }

    public void StopInteract()
    {
        if (mainCamera != null) mainCamera.enabled = true;
        if (laptopCamera != null) laptopCamera.enabled = false;

        if (LaptopUI != null) LaptopUI.SetActive(false);

        if (PlayerMovement != null) PlayerMovement.enabled = true;
    }
}