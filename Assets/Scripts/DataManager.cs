using UnityEngine;
using Agava.YandexGames;
using System.Collections;

[System.Serializable]
public class PlayerInfo
{
    public BulletData BulletData;
}

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public PlayerInfo PlayerInfo;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(this);
#if !UNITY_EDITOR
            YandexGamesSdk.Initialize();
#endif
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveData()
    {
        string data = JsonUtility.ToJson(PlayerInfo);

        PlayerPrefs.SetString("Data", data);
#if !UNITY_EDITOR
        StartCoroutine(SaveYandexData(data));
#endif
    }

    private IEnumerator SaveYandexData(string data)
    {
        while (!YandexGamesSdk.IsInitialized)
        {
            yield return null;
        }

        PlayerAccount.SetCloudSaveData(data);
    }

    private void LoadData()
    {
        PlayerInfo = JsonUtility.FromJson<PlayerInfo>(PlayerPrefs.GetString("Data", JsonUtility.ToJson(PlayerInfo)));

#if !UNITY_EDITOR
        StartCoroutine(LoadYandexData());
#endif
    }

    private IEnumerator LoadYandexData()
    {
        while (!YandexGamesSdk.IsInitialized)
        {
            yield return null;
        }

        PlayerAccount.GetCloudSaveData((result) =>
        {
            PlayerInfo = JsonUtility.FromJson<PlayerInfo>(result);
        });
    }
}
