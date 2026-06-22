using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;

    private float _elapsed;
    private bool  _running;

    void OnEnable()
    {
        _elapsed = 0f;
        _running = true;
    }

    void OnDisable()
    {
        _running = false;
    }

    void Update()
    {
        if (!_running) return;
        _elapsed += Time.deltaTime;
        int minutes = (int)(_elapsed / 60f);
        int seconds = (int)(_elapsed % 60f);
        if (timerText != null)
            timerText.text = $"{minutes:00}:{seconds:00}";
    }
}
