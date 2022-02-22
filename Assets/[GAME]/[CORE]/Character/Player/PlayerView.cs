using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour, IView
{
    [SerializeField] private Components components;
    [SerializeField] private MovementProperty movementProperty;
    [SerializeField] private WeaponView weapon;

    Components IView.components => components; 

    public WeaponView current_Weapon => weapon;

    private float _rotationX = 0;

    public void Move(Vector3 direction)
    {
        components.rigidbody.velocity = direction * movementProperty.speed;
    }

    public void Rotate(Vector2 direction)
    {
        components.transform.Rotate(new Vector3(0, direction.x * movementProperty.speed_rotate, 0));
    }

    public void CameraRotate(Vector2 direction)
    {
        _rotationX -= direction.y * movementProperty.speed_rotate;
        _rotationX = Mathf.Clamp(_rotationX, movementProperty.camera_clamp.x, movementProperty.camera_clamp.y);
        components.camera_root.localEulerAngles = new Vector3(_rotationX, 0, 0);
    }
}

[System.Serializable]
public struct Components
{
    public Transform transform;
    public Transform camera_root;
    public Rigidbody rigidbody;
}

[System.Serializable]
public struct MovementProperty
{
    public float speed;
    public float speed_rotate;
    public Vector2 camera_clamp;
}
