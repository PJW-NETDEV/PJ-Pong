using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;
    public int angleEffect;

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

            //Calculate extra delfection force
            Vector2 collisionPointWorld = this_collision.contacts[0].point;
            float extraAngle = this_collision.otherCollider.transform.InverseTransformPoint(collisionPointWorld).y;


            float x = this_collision.GetContact(0).normal.x;
            float y = this_collision.GetContact(0).normal.y + (extraAngle * angleEffect);

            //reverse polarity
            if (y < 0)
            {
                y = Mathf.Abs(y); // Convert negative to positive
            } else
            {
                y *= -1;
            }

            // Basic Deflect
            //Vector2 normal_force_var = this_collision.GetContact(0).normal;


            Vector2 normal_force_var = new Vector2(x, y);



          

           // Debug.Log("Collision Position: " + collisionPointWorld);

            Vector2 collisionPointPaddle = this_collision.otherCollider.transform.InverseTransformPoint(collisionPointWorld);

            Debug.Log(this_collision.otherCollider.name + " : " + collisionPointPaddle.y);
           // Debug.Log("Collider Name: " + this_collision.collider.name);




            // Add normal force to the ball + the bouce strength balue
            // -normal is used to add force in opposite in direction
            ball_var.AddForce(-normal_force_var * this.bounceStrength);
            

        }
        
    }



}
