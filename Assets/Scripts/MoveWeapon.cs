using UnityEngine;

public class MoveWeapon : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _recoilTime;
    private Vector3 _direction = Vector3.back;
    [SerializeField] private WeaponRecoil _weaponRecoil;

    private void OnValidate()
    {
        if (_target == null)
        {
            _target = FindObjectOfType<Player>().transform;
        }
        else if (_target && _offset == Vector3.zero)
        {
            _offset = _target.position - transform.position;
        }
    }

    private void Update()
    {
        transform.position = _target.position - _offset;
        _weaponRecoil.Move(_recoilTime, _direction, ref _offset);
        _direction *= -1;
    }
}
