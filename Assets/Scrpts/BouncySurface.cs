using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D this_collision)
    {
       // Check if collision was with ball
        if(this_collision.gameObject.name == "Ball")
        {
            // Create some variables for tracking speed
            
            //Debug.Log("Collied with ball");

            // Set a loal variable for the ball to reference from the collision object
            Ball ball_var = this_collision.gameObject.GetComponent<Ball>();
            
            // Create a variable with the existing force
            Vector2 normal_force_var = this_collision.GetContact(0).normal;

            // Add normal force to the ball + the bouce strength balue
            // -normal is used to add force in opposite in direction
            ball_var.AddForce(-normal_force_var * this.bounceStrength);
            

        }

    }



}
