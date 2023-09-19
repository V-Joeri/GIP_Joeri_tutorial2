using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int _maxHP;
    public int _hp;
    public bool _alive;
    private Rigidbody2D _rigidbody;
    public float _velocity;
    public float _fast;
    public GameObject _up;
    public GameObject _ne;
    public GameObject _right;
    public GameObject _se;
    public GameObject _left;
    public GameObject _sw;
    public GameObject _down;
    public GameObject _nw;
    public GameObject _dead;
    public AudioSource _src;
    public AudioClip _spawn, _hit0, _hit1, _killed;

    // Start is called before the first frame update
    void Start()
    {
        _hp = _maxHP;
        _alive = true;
        _dead.SetActive(false);
        _rigidbody = GetComponent<Rigidbody2D>();
        _src.clip = _spawn;
        _src.Play();
    }
    // Update is called once per frame
    void Update()
    {
        // To go Up Left
        if (_alive && (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)))
        {
            ChangeRotation('a');
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Space))
            {
                _rigidbody.velocity = (Vector2.left * _fast) + (Vector2.up * _fast);
            }
            else
            {
                _rigidbody.velocity = (Vector2.left * _velocity) + (Vector2.up * _velocity);
            }
        }
        // To go Up Right
        else if (_alive && (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)))
        {
            ChangeRotation('e');
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Space))
            {
                _rigidbody.velocity = (Vector2.right * _fast) + (Vector2.up * _fast);
            }
            else
            {
                _rigidbody.velocity = (Vector2.right * _velocity) + (Vector2.up * _velocity);
            }
        }
        // To go Down Right
        else if (_alive && (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)))
        {
            ChangeRotation('x');
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Space))
            {
                _rigidbody.velocity = (Vector2.right * _fast) + (Vector2.down * _fast);
            }
            else
            {
                _rigidbody.velocity = (Vector2.right * _velocity) + (Vector2.down * _velocity);
            }
        }
        // To go Down Left
        else if (_alive && (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)))
        {
            ChangeRotation('w');
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Space))
            {
                _rigidbody.velocity = (Vector2.left * _fast) + (Vector2.down * _fast);
            }
            else
            {
                _rigidbody.velocity = (Vector2.left * _velocity) + (Vector2.down * _velocity);
            }
        }
        // To go Up
        else if (_alive && Input.GetKey(KeyCode.W))
        {
            ChangeRotation('u');
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Space))
            {
                _rigidbody.velocity = Vector2.up * _fast;
            }
            else
            {
                _rigidbody.velocity = Vector2.up * _velocity;
            }
        }
        // To go Left
        else if (_alive && Input.GetKey(KeyCode.A))
        {
            ChangeRotation('l');
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Space))
            {
                _rigidbody.velocity = Vector2.left * _fast;
            }
            else
            {
                _rigidbody.velocity = Vector2.left * _velocity;
            }
        }
        // To go Right
        else if (_alive && Input.GetKey(KeyCode.D))
        {
            ChangeRotation('r');
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Space))
            {
                _rigidbody.velocity = Vector2.right * _fast;
            }
            else
            {
                _rigidbody.velocity = Vector2.right * _velocity;
            }
        }
        // To go Down
        else if (_alive && Input.GetKey(KeyCode.S))
        {
            ChangeRotation('d');
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Space))
            {
                _rigidbody.velocity = Vector2.down * _fast;
            }
            else
            {
                _rigidbody.velocity = Vector2.down * _velocity;
            }
        }
        // To stay still
        else
        {
            _rigidbody.velocity -= _rigidbody.velocity;
        }
    }
    // Changes player rotation
    private void ChangeRotation(char direction)
    {
        if (direction == 'u')
        {
            _up.SetActive(true);
            _ne.SetActive(false);
            _right.SetActive(false);
            _se.SetActive(false);
            _left.SetActive(false);
            _sw.SetActive(false);
            _down.SetActive(false);
            _nw.SetActive(false);
            _dead.SetActive(false);
        }
        else if (direction == 'e')
        {
            _up.SetActive(false);
            _ne.SetActive(true);
            _right.SetActive(false);
            _se.SetActive(false);
            _left.SetActive(false);
            _sw.SetActive(false);
            _down.SetActive(false);
            _nw.SetActive(false);
            _dead.SetActive(false);
        }
        else if (direction == 'r')
        {
            _up.SetActive(false);
            _ne.SetActive(false);
            _right.SetActive(true);
            _se.SetActive(false);
            _left.SetActive(false);
            _sw.SetActive(false);
            _down.SetActive(false);
            _nw.SetActive(false);
            _dead.SetActive(false);
        }
        else if (direction == 'x')
        {
            _up.SetActive(false);
            _ne.SetActive(false);
            _right.SetActive(false);
            _se.SetActive(true);
            _left.SetActive(false);
            _sw.SetActive(false);
            _down.SetActive(false);
            _nw.SetActive(false);
            _dead.SetActive(false);
        }
        else if (direction == 'l')
        {
            _up.SetActive(false);
            _ne.SetActive(false);
            _right.SetActive(false);
            _se.SetActive(false);
            _left.SetActive(true);
            _sw.SetActive(false);
            _down.SetActive(false);
            _nw.SetActive(false);
            _dead.SetActive(false);
        }
        else if (direction == 'w')
        {
            _up.SetActive(false);
            _ne.SetActive(false);
            _right.SetActive(false);
            _se.SetActive(false);
            _left.SetActive(false);
            _sw.SetActive(true);
            _down.SetActive(false);
            _nw.SetActive(false);
            _dead.SetActive(false);
        }
        else if (direction == 'd')
        {
            _up.SetActive(false);
            _ne.SetActive(false);
            _right.SetActive(false);
            _se.SetActive(false);
            _left.SetActive(false);
            _sw.SetActive(false);
            _down.SetActive(true);
            _nw.SetActive(false);
            _dead.SetActive(false);
        }
        else if (direction == 'a')
        {
            _up.SetActive(false);
            _ne.SetActive(false);
            _right.SetActive(false);
            _se.SetActive(false);
            _left.SetActive(false);
            _sw.SetActive(false);
            _down.SetActive(false);
            _nw.SetActive(true);
            _dead.SetActive(false);
        }
        else
        {
            _up.SetActive(false);
            _ne.SetActive(false);
            _right.SetActive(false);
            _se.SetActive(false);
            _left.SetActive(false);
            _sw.SetActive(false);
            _down.SetActive(false);
            _nw.SetActive(false);
            _dead.SetActive(true);
        }
    }
    public void LoseHP(int damage)
    {
        _hp -= damage;
        if (_hp <= 0)
        {
            Die();
        }
        else
        {
            int rnd = Random.Range(0, 2);
            if (rnd == 0)
            {
                _src.clip = _hit0;
                _src.Play();
            }
            else
            {
                _src.clip = _hit1;
                _src.Play();
            }
        }
    }
    // Kills the player and ends the game
    public void Die()
    {
        _alive = false;
        ChangeRotation('F');
        _src.clip = _killed;
        _src.Play();
    }
}
