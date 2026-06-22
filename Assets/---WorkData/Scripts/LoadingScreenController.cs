using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadingScreenController : MonoBehaviour
{
    [Header("Boot Lines")]
    [SerializeField] private TextMeshProUGUI[] bootStatusTexts;

    [Header("Progress")]
    [SerializeField] private TextMeshProUGUI percentText;
    [SerializeField] private RectTransform    progressFill;

    [Header("Flow")]
    [SerializeField] private UI_Manager uiManager;

    private static readonly string[] StatusOK    = { "OK", "OK", "OK", "02 / 03", "DONE" };
    private static readonly Color    ColorOK     = new Color(0.29f, 0.78f, 0.69f, 1f);
    private static readonly Color    ColorWarn   = new Color(0.85f, 0.27f, 0.10f, 1f);
    private static readonly Color    ColorGray   = new Color(0.45f, 0.42f, 0.38f, 1f);

    private static readonly float[] BootTimings = { 0.6f, 0.5f, 0.7f, 0.9f, 0.5f };

    void OnEnable()
    {
        StartCoroutine(RunLoading());
    }

    private IEnumerator RunLoading()
    {
        ResetState();

        float totalBoot = 0f;
        foreach (float t in BootTimings) totalBoot += t;

        float elapsed = 0f;
        float bootCursor = 0f;
        int   lineIndex  = 0;

        while (elapsed < totalBoot)
        {
            elapsed    += Time.deltaTime;
            bootCursor += Time.deltaTime;

            if (lineIndex < BootTimings.Length && bootCursor >= BootTimings[lineIndex])
            {
                bootCursor -= BootTimings[lineIndex];
                RevealLine(lineIndex);
                lineIndex++;
            }

            float t = Mathf.Clamp01(elapsed / totalBoot);
            SetProgress(t);
            yield return null;
        }

        SetProgress(1f);
        yield return new WaitForSeconds(0.4f);

        uiManager.ShowInGame();
        gameObject.SetActive(false);
    }

    private void ResetState()
    {
        foreach (var txt in bootStatusTexts)
        {
            txt.text  = "_ _";
            txt.color = ColorGray;
        }
        SetProgress(0f);
    }

    private void RevealLine(int index)
    {
        if (index >= bootStatusTexts.Length) return;
        bootStatusTexts[index].text  = StatusOK[index];
        bootStatusTexts[index].color = index == 3 ? ColorWarn : ColorOK;
    }

    private void SetProgress(float t)
    {
        int pct = Mathf.RoundToInt(t * 100f);
        if (percentText  != null) percentText.text = pct.ToString();
        if (progressFill != null)
        {
            progressFill.anchorMax = new Vector2(t, progressFill.anchorMax.y);
        }
    }
}
