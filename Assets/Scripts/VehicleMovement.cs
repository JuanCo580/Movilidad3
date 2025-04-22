using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed;
    private int currentWaypointIndex = 0;

    private void Start()
    {
        speed = 5f;
    }

    void Update()
    {
        if (waypoints.Length == 0)
            return;

        Transform targetWaypoint = waypoints[currentWaypointIndex];
        Vector3 directionToWaypoint = targetWaypoint.position - transform.position;
        Vector3 moveVector = directionToWaypoint.normalized * speed * Time.deltaTime;

        if (moveVector.magnitude < directionToWaypoint.magnitude)
        {
            transform.position += moveVector;
        }
        else
        {
            transform.position = targetWaypoint.position;
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }

        // Opcional: Orientar el vehículo hacia el próximo waypoint
        if (directionToWaypoint != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(directionToWaypoint);
        }
    }
}