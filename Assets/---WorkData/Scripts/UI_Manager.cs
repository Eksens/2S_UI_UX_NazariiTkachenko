using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    #region input Declaration:
    [Header("____________ PANELS ____________")]
    [SerializeField] private GameObject LoadingMainMenuPanel;
    [SerializeField] private GameObject MainMenuPanel;
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private GameObject CreditsPanel;
    #endregion
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadingMainMenuPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
        SettingsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
