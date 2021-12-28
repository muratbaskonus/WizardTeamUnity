
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;
    
    void Start ()
    {
        target = Waypoints.points[wavepointIndex];

    }
    void Update()
    {

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime , Space.World);
        if(Vector3.Distance(transform.position,target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

    }
    void GetNextWaypoint()
    {
        if(wavepointIndex >= Waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }  
        wavepointIndex ++;
        target = Waypoints.points[wavepointIndex];
        Vector3 to = new Vector3(0, 270, 0);
        transform.Rotate(to);
    }
    void EndPath()
    {
        if(PlayerStats.lives > 0)
        {
            PlayerStats.lives--;
        }
        Destroy(gameObject);
    }
}