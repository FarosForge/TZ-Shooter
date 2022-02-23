using UnityEngine;

public interface IModel
{
    public Vector3 GetDirection(Transform transform);
    public Vector2 GetRotateDirection();
}
