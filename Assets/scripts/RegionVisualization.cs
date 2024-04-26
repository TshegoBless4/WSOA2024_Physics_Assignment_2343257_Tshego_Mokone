
using UnityEngine;

public class RegionVisualization : MonoBehaviour
{
    public int regionSize = 100;
    public int points = 1;
    private int score = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Puck"))
        {
            score += points;
            Debug.Log("Points: " + score);
        }
    }

    void OnDrawGizmosSelected()
    {
        // Draw region gizmo
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(transform.position, new Vector3(regionSize, regionSize, 0));
    }
}
