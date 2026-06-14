using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class SliderManager : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI valueText;
    public void Update()
    {
        valueText.text = (Mathf.RoundToInt(slider.value * 100f)+"%");
    }
}