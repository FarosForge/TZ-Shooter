using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IView
{
    public Components components { get; }
    public WeaponView current_Weapon { get; }
    public void Move(Vector3 direction);
    public void Rotate(Vector2 direction);
    public void CameraRotate(Vector2 direction);
}
