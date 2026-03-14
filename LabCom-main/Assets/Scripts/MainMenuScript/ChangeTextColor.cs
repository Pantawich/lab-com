using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

[RequireComponent(typeof(Button))]
public class ChangeTextColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TMP_Text textComponent;

    public void OnPointerEnter(PointerEventData eventData)
    {
        textComponent.color = Color.red; // Change to desired color on hover
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        textComponent.color = Color.black; // Change back to original color when not hovering
    }
}
