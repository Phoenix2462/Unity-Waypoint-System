using System.Collections.Generic;
using UnityEngine;
public class WaypointSystem : MonoBehaviour
{
    public List<Transform> Waypoint = new List<Transform>();
    public float speed;
    private void Update()
    {
        if (Waypoint.Count <= 0) { Destroy(gameObject); return; }
        {
            transform.right = Waypoint[0].position - transform.position;
            transform.position = Vector3.MoveTowards(transform.position, targetTransform(), speed * Time.deltaTime);
        }
    }

    Vector3 targetTransform()
    {
        Transform targeted = Waypoint[0];
        if (transform.position != Waypoint[0].position) return targeted.position;
        {
            Waypoint.Remove(Waypoint[0]);
            if (Waypoint.Count > 0)
            {
                targeted = Waypoint[0];
            }
            return targeted.position;
        }
    }
}
