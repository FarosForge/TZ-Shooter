using System;
using UnityEngine;
using AI;

public interface IAIView
{
    public Action<int> onHitAction { get; set; }
    public Components Components { get; }
    public AIProperty Property { get; }
    public WeaponView current_Weapon { get; }

    public void Move(Vector3 direction);
    public void LookToTarget(Vector3 targetPosition);

    public void Dispose();
}
