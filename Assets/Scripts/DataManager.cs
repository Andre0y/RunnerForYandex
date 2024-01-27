using UnityEngine;
using Agava.YandexGames;

[System.Serializable]
public class PlayerInfo
{

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

    private void LoadData()
    {
        PlayerAccount.GetCloudSaveData((result) =>
        {
            PlayerInfo = JsonUtility.FromJson<PlayerInfo>(result);
        });
    }
}
