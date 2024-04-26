using System.Collections;
using UnityEngine;

public class HockeyBoard : MonoBehaviour
{
    public GameObject puck;
    public int regionSize = 100;
    public int points = 10;
    public float regionActivationChance = 0.2f;
    private bool regionActivated = false;
    private int score = 0;

    void Update()
    {
        // Check if puck is within the region
        if (puck.transform.position.x >= transform.position.x - regionSize / 2 &&
            puck.transform.position.x <= transform.position.x + regionSize / 2 &&
            puck.transform.position.y >= transform.position.y - regionSize / 2 &&
            puck.transform.position.y <= transform.position.y + regionSize / 2)
        {
            // Activate region and add points
            if (!regionActivated)
            {
                regionActivated = true;
                score += points;
                Debug.Log("Points: " + score);
            }
        }
        else
        {
            regionActivated = false;
        }
    }

    void OnDrawGizmosSelected()
    {
        // Draw region gizmo
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(transform.position, new Vector3(regionSize, regionSize, 0));
    }
}
