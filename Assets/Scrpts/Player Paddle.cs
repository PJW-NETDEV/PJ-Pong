using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{

    //Check for player input and move

    // Initialise Vector 2 objec (speed, velocity etc) called _direction
    private Vector2 _direction;

    // Function for every frame update
    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input .GetKey(KeyCode.UpArrow)) {
            _direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
            _direction = Vector2.down;
        } else
        {
            _direction = Vector2.zero;
        }
    }


    private void FixedUpdate()
    {
        if ( _direction.sqrMagnitude != 0 ) {
            _rigidbody.AddForce(_direction * this._speed);
        }
    }
}
