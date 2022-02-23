using UnityEngine;
using PLAYER;
using System;

public class PlayerView : MonoBehaviour, IView
{
    [SerializeField] private Components components;
    [SerializeField] private Property property;
    [SerializeField] private WeaponView weapon;

    Components IView.components => components; 
    public WeaponView current_Weapon => weapon;
    public Property Property => property;
    public Action<int> onHitAction { get; set; }

    private float _rotationX = 0;

    public void Move(Vector3 direction, bool isGrounded)
    {
        if(isGrounded)
            components.rigidbody.velocity = direction * Property.speed;
    }

    public void Rotate(Vector2 direction)
    {
        components.transform.Rotate(new Vector3(0, direction.x * Property.speed_rotate, 0));
    }

    public void CameraRotate(Vector2 direction)
    {
        _rotationX -= direction.y * Property.speed_rotate;
        _rotationX = Mathf.Clamp(_rotationX, property.camera_clamp.x, Property.camera_clamp.y);
        components.camera_root.localEulerAngles = new Vector3(_rotationX, 0, 0);
    }

    public void BackForce(float force)
    {
        components.rigidbody.AddForce((-components.transform.forward) * force, ForceMode.Impulse);
    }
}

namespace PLAYER
{
    [System.Serializable]
    public struct Components
    {
        public Transform transform;
        public Transform camera_root;
        public Rigidbody rigidbody;
    }

    [System.Serializable]
    public struct Property
    {
        public float speed;
        public float speed_rotate;
        public Vector2 camera_clamp;
        public LayerMask groundMask;
    }
}

