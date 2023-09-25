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
    private float _firingRate;

    private GameObject _spawnedBullet;
    private float _timer;
    private GameObject _logic;
    // Start is called before the first frame update
    void Start()
    {
        _bullet = GameObject.FindGameObjectWithTag("Bullet");
        _bullet.SetDifficulty(_logic.GetDifficulty());
        _spawnedBullet = _bullet;
        _logic = GameObject.FindGameObjectWithTag("Logic");
        if (_logic.GetDifficulty() == 3)
        {
            _firingRate = 0.5;
        }
        else if (_logic.GetDifficulty() == 2)
        {
            _firingRate = 1;
        }
        else
        {
            _firingRate = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_spawnerType == SpawnerType.Spin) transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 1);
        if (_timer >= _firingRate)
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
