using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : IWeapon
{
    private IAttack attack;
    private IWeaponView view;

    public WeaponController(IWeaponView view)
    {
        this.view = view;
        attack = new AttackModel();
    }

    public void Init()
    {
        
    }

    public void Tick()
    {
        if(attack.CanShoot(view.Property.shoot_rate))
        {
            attack.SetBullet(view.Property.bullet_prefab, view.Property.bulletSpawnPoint);
        }
    }
}
