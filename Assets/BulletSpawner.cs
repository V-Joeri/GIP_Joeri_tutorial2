using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    enum SpawnerType { Straight, Spin }

    [Header("Bullet Attributes")]
    public GameObject _bullet;
    public float _speed;

    [Header("Spawner Attributes")]
    private SpawnerType _spawnerType;
    private float _firingRate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
