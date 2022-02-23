using UnityEngine;

public interface IAIModel
{
    public Vector3 GetDirection(Transform[] points, Transform transform, float speed);
    public bool GetDistanceToTarget(Transform transform, Transform target, float distance);
}
