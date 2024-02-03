using UnityEngine;

public class UIManager : MonoBehaviour
{
    private MoveWeapon _moveWeapon;
    
    private bool _isAllowedMoving;

    private void Start()
    {
        _moveWeapon = FindAnyObjectByType<MoveWeapon>();
    }
    
    public void AllowMoving()
    {
        _isAllowedMoving = true;
        _moveWeapon.SetMove(_isAllowedMoving);
    }
}
