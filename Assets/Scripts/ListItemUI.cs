using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ListItemUI : MonoBehaviour
{
    public Text titleText;
    public Button actionButton;

    public void Init(string title, UnityAction onClick)
    {
        titleText.text = title;
        actionButton.onClick.RemoveAllListeners();
        actionButton.onClick.AddListener(onClick);
    }
}
