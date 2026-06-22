using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [Header("____________ PANELS ____________")]
    [SerializeField] private GameObject LoadingPanel;
    [SerializeField] private GameObject MainMenuPanel;
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private GameObject CreditsPanel;
    [SerializeField] private GameObject InGamePanel;

    void Start()
    {
        ShowMainMenu();
    }

    public void ShowLoading()
    {
        SetAll(false);
        LoadingPanel.SetActive(true);
    }

    public void ShowMainMenu()
    {
        SetAll(false);
        MainMenuPanel.SetActive(true);
    }

    public void ShowSettings()
    {
        SetAll(false);
        SettingsPanel.SetActive(true);
    }

    public void ShowCredits()
    {
        SetAll(false);
        CreditsPanel.SetActive(true);
    }

    public void ShowInGame()
    {
        SetAll(false);
        InGamePanel.SetActive(true);
    }

    private void SetAll(bool state)
    {
        LoadingPanel.SetActive(state);
        MainMenuPanel.SetActive(state);
        SettingsPanel.SetActive(state);
        CreditsPanel.SetActive(state);
        InGamePanel.SetActive(state);
    }
}
