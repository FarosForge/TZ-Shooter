using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttack
{
    public bool CanShoot(float shoot_rate);
    public GameObject SetBullet(GameObject prefab, Transform point);
}
