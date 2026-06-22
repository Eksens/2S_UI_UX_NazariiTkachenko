using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FullscreenToggle : MonoBehaviour
{
    [SerializeField] private Image         onHighlight;
    [SerializeField] private Image         offHighlight;
    [SerializeField] private TextMeshProUGUI onText;
    [SerializeField] private TextMeshProUGUI offText;

    static readonly Color ActiveBG   = new Color(0.87f, 0.44f, 0.08f, 1f);
    static readonly Color InactiveBG = Color.clear;
    static readonly Color ActiveTxt  = new Color(0.95f, 0.91f, 0.83f, 1f);
    static readonly Color InactiveTxt= new Color(0.45f, 0.42f, 0.38f, 1f);

    bool _on = true;

    void Start() => Apply();

    public void ToggleFullscreen()
    {
        _on = !_on;
        Screen.fullScreen = _on;
        Apply();
    }

    void Apply()
    {
        if (onHighlight)  onHighlight.color  = _on ? ActiveBG    : InactiveBG;
        if (offHighlight) offHighlight.color = _on ? InactiveBG  : ActiveBG;
        if (onText)       onText.color       = _on ? ActiveTxt   : InactiveTxt;
        if (offText)      offText.color      = _on ? InactiveTxt : ActiveTxt;
    }
}
