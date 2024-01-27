using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private Bullet[] _bullets;
    [SerializeField] private Animator _animator;

    private float _timeBetweenShoots;
    private float _timeAfterShoot;
    private int _currentBullet;
    
    private Vector3 _bulletSpawnPosition => _gun.ShootPoint.position;
    private Gun _gun;

    public Gun Gun => _gun;

    private void Start()
    {
        _gun = FindObjectOfType<Gun>();

        _timeBetweenShoots = _gun.Reload;
    }

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        _timeAfterShoot += Time.deltaTime;

        if (_timeAfterShoot >= _timeBetweenShoots)
        {
            if (_currentBullet > _bullets.Length - 1)
            {
                _currentBullet = 0;
            }

            if (_bullets[_currentBullet].gameObject.activeInHierarchy)
            {
                bool hasAvailavaleBullets = false;

                for (int i = _currentBullet; i < _bullets.Length; i++)
                {
                    if (hasAvailavaleBullets)
                    {
                        continue;
                    }

                    if (_bullets[_currentBullet].gameObject.activeInHierarchy == false)
                    {
                        hasAvailavaleBullets = true;
                    }
                }

                if (hasAvailavaleBullets)
                {
                    Bullet newBullet = Instantiate(_bullet);
                    ExtendBulletArray(newBullet);
                }
            }

            _bullets[_currentBullet].transform.position = _bulletSpawnPosition;
            _bullets[_currentBullet].gameObject.SetActive(true);
            _timeAfterShoot = 0;

            ++_currentBullet;

            _animator.enabled = true;
        }
        else if (_timeAfterShoot >= _timeBetweenShoots / 2)
        {
            _animator.enabled = false;
        }
    }

    private void ExtendBulletArray(Bullet bullet)
    {
        Bullet[] bullets = new Bullet[_bullets.Length + 1];

        for (int i = 0; i < _bullets.Length; i++)
        {
            bullets[i] = _bullets[i];
        }

        bullets[bullets.Length - 1] = bullet;

        _bullets = bullets;
    }
}
