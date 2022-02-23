using UnityEngine;

public class AIModel : IAIModel
{
    private int i = 0;

    public Vector3 GetDirection(Transform[] points, Transform transform, float speed)
    {
        if(Vector3.Distance(transform.position, points[i].position) <= 0.5f)
        {
            i = GetNewPointID(points.Length);
        }

        return Vector3.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    public bool GetDistanceToTarget(Transform transform, Transform target, float distance)
    {
        return Vector3.Distance(transform.position, target.position) <= distance;
    }

    private int GetNewPointID(int length)
    {
        i++;

        if(i >= length)
        {
            i = 0;
        }

        return i;
    }
}
