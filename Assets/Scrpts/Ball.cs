using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float _speed = 200.0f;
    public float _current_speed = 0;
    public TMPro.TMP_Text general_text;
    public float _max_speed = 9;
    private string stop_text;


    private void Awake()
    {
            _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(-1.0f, -0.5f);

        Vector2 direcion = new Vector2(x, y);
        _rigidbody.AddForce(direcion * this._speed);

        Debug.Log(_rigidbody.totalForce);
    }

    public void AddForce(Vector2 force)
    {

        if(Mathf.Abs(_rigidbody.velocity.x) < _max_speed)
        {
            _rigidbody.AddForce(force);
            Debug.Log("Current Speed: " + Mathf.Abs(_rigidbody.velocity.x));
        }

    }

    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
      
  
        
    }





    private void Update()
    {
        // Update HUD Info
        _current_speed = _rigidbody.velocity.x;
        general_text.text = ("Velocity: " + _current_speed.ToString("F2").Replace("-",""));

        WaitForKeyToStart();


    }


    public void WaitForKeyToStart()
    {



        // Pause after ball has been reset (velocity 0)
        if (_rigidbody.velocity.x == 0)
        {
            general_text.text = (
            "Velocity: " + _current_speed.ToString("F2").Replace("-", "") + "\n\n" +
            "Press Space to continue..."
            );

            if (Input.GetKeyDown(KeyCode.Space))
            {
                AddStartingForce();
            }

        }





    }

}
