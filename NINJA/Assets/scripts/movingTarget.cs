using UnityEngine;

public class movingTarget : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10;
    public Transform[] waypoints;
    int currentWaypoint = 0;
    void FixedUpdate()
    {
        movement();
    }
    void movement()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypoint].position) < 0.1f)
        {
            currentWaypoint++;
            currentWaypoint = currentWaypoint % waypoints.Length;
        }
        Vector3 dir = (waypoints[currentWaypoint].position - transform.position).normalized;
        rb.MovePosition(transform.position + dir * speed * Time.deltaTime);
    }
}
