using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class SliderManager : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI valueText;
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private string mixerParameterName;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    public void OnSliderValueChanged(float sliderValue)
    {
        valueText.text = Mathf.RoundToInt(sliderValue * 100f) + "%";
        float clampedValue = Mathf.Clamp(sliderValue, 0.0001f, 1f);
        float dB = Mathf.Log10(clampedValue) * 20;
        audioMixer.SetFloat(mixerParameterName, dB);
    }
}