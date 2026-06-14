using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class SliderKnobHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image img;
    private bool isHovering = false;
    private bool isPressing = false;
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (img != null)
        {
            img.color = Color.red;
        }
        isHovering = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (img != null)
        {
            isHovering = false;
        }
    }

    public void Update()
    {
        if(Input.GetMouseButtonUp(0))
        if (!isHovering)
        {
            img.color = Color.white;
            isPressing = false;
        }
        if (isHovering && Input.GetMouseButtonDown(0))
        {
            img.color = Color.red;
            isPressing = true;
        }
        if (!isPressing && !isHovering)
        {
            img.color = Color.white;
        }
    }
}
