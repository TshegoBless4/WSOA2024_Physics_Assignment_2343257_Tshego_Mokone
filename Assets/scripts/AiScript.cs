using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiScript : MonoBehaviour
{
    public float MaxMovementSpeed;
    private Rigidbody2D rb;
    private Vector2 startingPosition;

    public Rigidbody2D Puck;

    public Transform aiBoundaryHolder;
    private Boundary aiBoundary;

    public Transform aiPuckBoundaryHolder;
    private Boundary aiPuckBoundary;

    private Vector2 targetPosition;

    private bool isFirstTimeInOpponentsHalf = true;
    private float offsetXFromTarget;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = rb.position;

        aiBoundary = new Boundary(aiBoundaryHolder.GetChild(0).position.y,
                              aiBoundaryHolder.GetChild(1).position.y,
                              aiBoundaryHolder.GetChild(2).position.x,
                              aiBoundaryHolder.GetChild(3).position.x);

        aiPuckBoundary = new Boundary(aiPuckBoundaryHolder.GetChild(0).position.y,
                              aiPuckBoundaryHolder.GetChild(1).position.y,
                              aiPuckBoundaryHolder.GetChild(2).position.x,
                              aiPuckBoundaryHolder.GetChild(3).position.x);
    }

    


        private void FixedUpdate()
            {
                float movementSpeed;
                if (!PuckScript.WasGoal)
                {
                    if (Puck.position.x < aiPuckBoundary.Left)
                    {
                        movementSpeed = MaxMovementSpeed * Random.Range(0.1f, 0.3f);
                        targetPosition = new Vector2(startingPosition.x, Mathf.Clamp(Puck.position.y, aiBoundary.Down, aiBoundary.Up));
                    }
                    else
                    {
                        movementSpeed = Random.Range(MaxMovementSpeed * 0.4f, MaxMovementSpeed);
                        targetPosition = new Vector2(Mathf.Clamp(Puck.position.x, aiBoundary.Left, aiBoundary.Right), Mathf.Clamp(Puck.position.y, aiBoundary.Down, aiBoundary.Up));
                    }

                    rb.MovePosition(Vector2.MoveTowards(rb.position, targetPosition, movementSpeed * Time.fixedDeltaTime));
                }
            }

        }


    

