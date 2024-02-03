using UnityEngine;

public class UIView : MonoBehaviour
{
    private bool _isActive = true;

    public void ChangeView()
    {
        _isActive = false;
        gameObject.SetActive(_isActive);
    }
}