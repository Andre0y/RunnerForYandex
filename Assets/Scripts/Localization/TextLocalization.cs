using TMPro;
using UnityEngine;

public class TextLocalization : MonoBehaviour
{
    [SerializeField] private string _key;
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        string value = LocalizationManager.Instance.GetText(_key);
        _text.SetText(value);
    }
}
