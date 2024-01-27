using System.Collections;
using UnityEngine;

public class GameRestarter : MonoBehaviour
{
    [SerializeField] private Vector3 _startPoint;
    [SerializeField] private Player _player;
    [SerializeField] private float _waitTime;

    public void Restart()
    {
        StartCoroutine(RestartCoroutine());
    }

    private IEnumerator RestartCoroutine()
    {
        yield return new WaitForSeconds(_waitTime);

        _player.transform.position = _startPoint;
        _player.gameObject.SetActive(true);
    }
}
