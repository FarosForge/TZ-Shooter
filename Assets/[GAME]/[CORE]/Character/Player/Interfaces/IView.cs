using System;
using UnityEngine;
using PLAYER;

public interface IView
{
    public Action<int> onHitAction { get; set; }
    public Components components { get; }
    public Property Property { get; }
    public WeaponView current_Weapon { get; }
    public void Move(Vector3 direction);
    public void Rotate(Vector2 direction);
    public void CameraRotate(Vector2 direction);
}
