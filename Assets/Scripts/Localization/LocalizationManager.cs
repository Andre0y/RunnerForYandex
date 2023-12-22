using Agava.YandexGames;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class LocalizationManager : MonoBehaviour
{
    public static LocalizationManager Instance;
    private Dictionary<string, string> _localizedStrings = new Dictionary<string, string>();
    [SerializeField] private string[] _languages;
    [SerializeField] private TextAsset languageDocument;
    private int _currentLanguageID;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void LoadLocalizedStrings()
    {
        SetCurrentLanguage();
        
        XDocument languageData = XDocument.Parse(languageDocument.text);

        foreach (XElement textElement in languageData.Element("localization").Elements())
        {
            string key = textElement.Attribute("key").Value;
            string value = textElement.Attribute(_languages[_currentLanguageID]).Value;
            _localizedStrings.Add(key, value);
             
        }
    }

    private void SetCurrentLanguage()
    {
#if !UNITY_EDITOR
        string language = YandexGamesSdk.Environment.i18n.lang;

        switch (language)
        {
            case "ru":
                _currentLanguageID = 0;
                break;
            case "en":
                _currentLanguageID = 1;
                break;
            case "tr":
                _currentLanguageID = 2;
                break;
            default:
                _currentLanguageID = 1;
                break;
        }
#else
        _currentLanguageID = 0;
#endif
    }

    public string GetText(string key)
    {
        if (_localizedStrings.TryGetValue(key, out string value))
        {
            return value;
        }

        return null;
    }
}
