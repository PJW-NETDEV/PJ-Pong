using UnityEngine;

public class ComputerPaddle : Paddle
{

    public Rigidbody2D ball;


    private void FixedUpdate()
    {
        // Code to moev computer paddle

        //If ball is coming towards paddle then adjust position
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y) // if ball is higher than than paddle
            {
                _rigidbody.AddForce(Vector2.up * this._speed);  // move up
            }
            else if (this.ball.position.y < this.transform.position.y) // if ball is lower than paddle
            {
                _rigidbody.AddForce(Vector2.down * this._speed); // move down
            }
        }
        else // if call is not coming towards player, reset to middle
        {
            if (this.transform.position.y > 0.0f) // if paddle is higher than center
            {
                _rigidbody.AddForce(Vector2.down * this._speed); // move down
            }
            else if (this.transform.position.y < 0) // if paddle is lower than center
            {
                _rigidbody.AddForce(Vector2.up * this._speed); //move up
            }
        }
    }
}
