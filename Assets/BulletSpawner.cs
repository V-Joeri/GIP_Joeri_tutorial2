using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    enum SpawnerType { Straight, Spin }

    [Header("Bullet Attributes")]
    public GameObject _bullet;

    [Header("Spawner Attributes")]
    private SpawnerType _spawnerType;
    public bool _spin;
    private float _firingRate;

    public GameObject _spawnedBullet;
    private float _timer;
    public GameObject _logic;
    // Start is called before the first frame update
    void Start()
    {
        if (_spin)
        {
            _spawnerType = SpawnerType.Spin;
        }
        else
        {
            _spawnerType= SpawnerType.Straight;
        }
        _bullet.GetComponent<BulletScript>().SetDifficulty(_logic.GetComponent<LogicScript>().GetDifficulty());
        _spawnedBullet = _bullet;
        SetFireRate();
    }

    private void SetFireRate()
    {
        if (_logic.GetComponent<LogicScript>().GetDifficulty() == 1)
        {
            _firingRate = 2;
        }
        else if (_logic.GetComponent<LogicScript>().GetDifficulty() == 2)
        {
            _firingRate = 1;
        }
        else
        {
            _firingRate = 0.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        SetFireRate();
        _timer += Time.deltaTime;
        if (_spawnerType == SpawnerType.Spin)
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 1);
            if (_timer >= _firingRate / 2)
            {
                Fire();
                _timer = 0;
            }
        }
        else if (_timer >= _firingRate)
        {
            Fire();
            _timer = 0;
        }
    }

    private void Fire()
    {
        _spawnedBullet = Instantiate(_bullet, transform.position, Quaternion.identity);
        _spawnedBullet.transform.rotation = transform.rotation;
    }
}
