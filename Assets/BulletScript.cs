using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private GameObject _player;
    private int _damage;
    public float _speed;
    private Vector2 _spawnPoint;
    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _player = GameObject.FindGameObjectWithTag("Player");
        _spawnPoint = new Vector2(transform.position.x, transform.position.y);
    }
    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        transform.position = Movement();
    }

    public void SetDifficulty(int difficulty)
    {
        _damage = difficulty;
        _speed = difficulty;
    }

    private Vector2 Movement()
    {
        float x = _timer * _speed * transform.right.x;
        float y = _timer * _speed * transform.right.y;
        return new Vector2((x + _spawnPoint.x), (y + _spawnPoint.y));
    }

    // What the bullet does on collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == _player.GetComponent<BoxCollider2D>())
        {
            _player.GetComponent<PlayerScript>().LoseHP(_damage);
        }
        Destroy(this.gameObject);
    }
}
