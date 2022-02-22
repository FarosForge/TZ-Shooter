using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : IEquiped
{
    private IModel model;
    private IView view;
    private IWeapon weapon;

    public PlayerController(IView view)
    {
        this.view = view;
        model = new PlayerModel();
    }

    public void Init()
    {
        SetNewWeapon();
    }

    public void SetNewWeapon()
    {
        if (view.current_Weapon != null)
        {
            weapon = new WeaponController(view.current_Weapon);
            weapon.Init();
        }
    }

    public void Tick()
    {
        view.Move(model.GetDirection(view.components.transform));
        view.Rotate(model.GetRotateDirection());
        view.CameraRotate(model.GetRotateDirection());

        if(weapon != null)
        {
            weapon.Tick();
        }
    }
}
