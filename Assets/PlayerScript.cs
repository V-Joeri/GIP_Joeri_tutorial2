using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public bool _alive;
    private Rigidbody2D _rigidbody;
    public float _velocity;

    public GameObject _up;
    public GameObject _ne;
    public GameObject _right;
    public GameObject _se;
    public GameObject _left;
    public GameObject _sw;
    public GameObject _down;
    public GameObject _nw;

    // Start is called before the first frame update
    void Start()
    {
        _alive = true;
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        
        if (_alive && (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)))
        {
            ChangeRotation('a');
            _rigidbody.velocity = (Vector2.left * _velocity) + (Vector2.up * _velocity);
        }
        else if (_alive && (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)))
        {
            ChangeRotation('e');
            _rigidbody.velocity = (Vector2.right * _velocity) + (Vector2.up * _velocity);
        }
        else if (_alive && (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)))
        {
            ChangeRotation('x');
            _rigidbody.velocity = (Vector2.right * _velocity) + (Vector2.down * _velocity);
        }
        else if (_alive && (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)))
        {
            ChangeRotation('w');
            _rigidbody.velocity = (Vector2.left * _velocity) + (Vector2.down * _velocity);
        }
        else if (_alive && Input.GetKey(KeyCode.W))
        {
            ChangeRotation('u');
            _rigidbody.velocity = Vector2.up * _velocity;
        }
        else if (_alive && Input.GetKey(KeyCode.A))
        {
            ChangeRotation('l');
            _rigidbody.velocity = Vector2.left * _velocity;
        }
        else if (_alive && Input.GetKey(KeyCode.D))
        {
            ChangeRotation('r');
            _rigidbody.velocity = Vector2.right * _velocity;
        }
        else if (_alive && Input.GetKey(KeyCode.S))
        {
            ChangeRotation('d');
            _rigidbody.velocity = Vector2.down * _velocity;
        }
        else
        {
            _rigidbody.velocity -= _rigidbody.velocity;
        }
    }
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
        }
    }
}
