using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SliderKnobHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image img;

    [Header("Colors")]
    [SerializeField] private Color normalColor = Color.white;
    [SerializeField] private Color activeColor = Color.red;

    private bool isHovering = false;
    private bool isDragging = false;

    private void Start()
    {
        UpdateVisualState(true); 
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovering = true;
        UpdateVisualState();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHovering = false;
        UpdateVisualState();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;
        UpdateVisualState();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
        UpdateVisualState();
    }

    private void UpdateVisualState(bool forceUpdate = false)
    {
        if (img == null) return;

        if (isDragging || isHovering)
        {
            img.color = activeColor;
        }
        else
        {
            img.color = normalColor;
        }
    }

    private void OnDisable()
    {
        isDragging = false;
        isHovering = false;
        if (img != null) img.color = normalColor;
    }
}