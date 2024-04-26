using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChanger : MonoBehaviour
{
    public Vector2 direction; // Direction to change the puck's velocity
    public float forceMagnitude = 10f; // Magnitude of the force to apply
    public GameObject directionIndicator; // GameObject to visually indicate the direction

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Puck"))
        {
            Rigidbody2D puckRb = other.GetComponent<Rigidbody2D>();

            // Calculate the force vector based on the desired direction and magnitude
            Vector2 force = direction.normalized * forceMagnitude;

            // Apply the force to the puck without changing its velocity
            puckRb.velocity += force - Vector2.Dot(puckRb.velocity, direction.normalized) * direction.normalized;

            // Debug visualization
            Debug.DrawRay(other.transform.position, force, Color.green, 1f);

            // Instantiate the direction indicator GameObject at the point of collision
            if (directionIndicator != null)
            {
                Instantiate(directionIndicator, transform.position, Quaternion.identity);
            }
        }
    }
}
