using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
 
[RequireComponent(typeof(Image))]
public class SlideButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool onHover;
    CanvasGroup canvasGroup;

    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        onHover = true;
        FindObjectOfType<UiInterface>().anyButtonHover = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        onHover = false;
        FindObjectOfType<UiInterface>().anyButtonHover = false;
    }

    public void FullOpacity()
    {
        canvasGroup.alpha = 1;
    }
    public void HalfOpacity()
    {
        canvasGroup.alpha = 0.5f;
    }

}
