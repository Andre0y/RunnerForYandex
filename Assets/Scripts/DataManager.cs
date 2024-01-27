using UnityEngine;
using Agava.YandexGames;

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
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveData()
    {
        string data = JsonUtility.ToJson(PlayerInfo);

        Debug.Log(data);
        PlayerPrefs.SetString("Data", data);
#if !UNITY_EDITOR && UNITY_WEBGL
        PlayerAccount.SetCloudSaveData(data);
#endif
    }

    private void LoadData()
    {
        PlayerInfo = JsonUtility.FromJson<PlayerInfo>(PlayerPrefs.GetString("Data", JsonUtility.ToJson(PlayerInfo)));

#if !UNITY_EDITOR && UNITY_WEBGL
        PlayerAccount.GetCloudSaveData((result) =>
        {
            PlayerInfo = JsonUtility.FromJson<PlayerInfo>(result);
        });
#endif
    }
}
