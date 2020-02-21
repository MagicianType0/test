using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aipath : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject AiSprite;
    public GameObject[] Waypoint;
    public float speed = 5f;
    public float MinDistanceToWaypoint;
    public GameObject Player;
    public float ChasePlayerDistance;

    private int Currentwaypoint = 0;
    void Start()
    {
        
    }

    void Update()
    {
        //if close enough chase player
        if(Vector2.Distance(Player.transform.position, AiSprite.transform.position) < ChasePlayerDistance)
        {
            MoveAI(Player.transform.position);
        }
        else
        {
            Patrol();
        }
        
    }

    // Update is called once per frame
    private void Patrol()//arguments
    {
        //to ask if we are at the target location
        if (Vector3.Distance(AiSprite.transform.position, Waypoint[Currentwaypoint].transform.position) < MinDistanceToWaypoint)
        {
            Currentwaypoint++;
        }

        //to say if we made it to the last waypoint to restart
        if(Currentwaypoint >= Waypoint.Length)
        {
            Currentwaypoint = 0;
        }
        MoveAI(Waypoint[Currentwaypoint].transform.position);
    }

    private void MoveAI(Vector2 targetPosition)//arguments
    {
        //to move the ai
        AiSprite.transform.position = Vector2.MoveTowards(AiSprite.transform.position, targetPosition , speed * Time.deltaTime);
    }
}
