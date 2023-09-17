using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public bool _alive;
    private Rigidbody2D _rigidbody;
    public float _velocity;

    public GameObject _up;
    public GameObject _right;
    public GameObject _left;
    public GameObject _down;

    // Start is called before the first frame update
    void Start()
    {
        _alive = true;
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (_alive && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
        {
            ChangeRotation('u');
            _rigidbody.velocity = Vector2.up * _velocity;
        }
        else if (_alive && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
        {
            ChangeRotation('l');
            _rigidbody.velocity = Vector2.left * _velocity;
        }
        else if (_alive && (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
        {
            ChangeRotation('r');
            _rigidbody.velocity = Vector2.right * _velocity;
        }
        else if (_alive && (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
        {
            ChangeRotation('d');
            _rigidbody.velocity = Vector2.down * _velocity;
        }
        else
        {
            
        }
    }
    private void ChangeRotation(char direction)
    {
        if (direction == 'u')
        {
            _up.SetActive(true);
            _right.SetActive(false);
            _left.SetActive(false);
            _down.SetActive(false);
        }
        else if (direction == 'r')
        {
            _up.SetActive(false);
            _right.SetActive(true);
            _left.SetActive(false);
            _down.SetActive(false);
        }
        else if (direction == 'l')
        {
            _up.SetActive(false);
            _right.SetActive(false);
            _left.SetActive(true);
            _down.SetActive(false);
        }
        else
        {
            _up.SetActive(false);
            _right.SetActive(false);
            _left.SetActive(false);
            _down.SetActive(true);
        }
    }
}
