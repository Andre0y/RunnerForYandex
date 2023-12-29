using UnityEngine;

public class WeaponRecoil : MonoBehaviour
{
    [SerializeField] private float _recoilForce;
    [SerializeField] private float _recoilTime;
    [SerializeField] private float _timeAfterRecoil;
    [SerializeField] private float _currentTimeAfterRecoil;
    [SerializeField] private Transform _parent;
    Vector3 o;

    public void Move(float recoilTime, Vector3 direction, ref Vector3 offset)
    {
        offset.z = Mathf.Lerp(offset.z, (offset.z - _recoilForce) * direction.z, recoilTime);
        //offset = Vector3.Slerp(offset, new Vector3(offset.x, offset.y, (offset.z - _recoilForce) * direction.z), recoilTime * Time.deltaTime);
    }
}
