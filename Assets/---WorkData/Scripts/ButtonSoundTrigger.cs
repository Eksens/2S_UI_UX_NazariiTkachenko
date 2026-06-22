using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonSoundTrigger : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ButtonClickSound.Play);
    }
}
