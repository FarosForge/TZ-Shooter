using UnityEngine;

public class AIController : IEquiped
{ 
    private IAIModel model;
    private IAIView view;
    private IWeapon weapon;
    private IStats stats;
    private Transform player_target;

    public AIController(IAIView view, Transform player_transform)
    {
        this.view = view;
        model = new AIModel();
        stats = new Stats(view.Property.HP);
        view.onHitAction += stats.GetHit;
        player_target = player_transform;
    }

    public void Init()
    {
        SetNewWeapon();
    }

    public void SetNewWeapon()
    {
        if (view.current_Weapon != null)
        {
            weapon = new WeaponController(view.current_Weapon, true);
            weapon.Init();
        }
    }

    public void Tick()
    {
        if (stats.IsDead())
        {
            view.Dispose();
            return;
        }

        view.Move(model.GetDirection(view.Components.move_points, view.Components.transform, view.Property.move_speed));

        if (weapon != null && model.GetDistanceToTarget(view.Components.transform, player_target, view.Property.attack_distance))
        {
            view.LookToTarget(player_target.position);
            weapon.Tick();
        }
    }
}
