public class PlayerController : IEquiped
{
    private IModel model;
    private IView view;
    private IWeapon weapon;
    private IStats stats;

    public PlayerController(IView view)
    {
        this.view = view;
        model = new PlayerModel();
        stats = new Stats(10);
        view.onHitAction += stats.GetHit;
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
        if (stats.IsDead()) return;

        view.Move(model.GetDirection(view.components.transform), model.IsGrounded(view.components.transform, view.Property.groundMask));
        view.Rotate(model.GetRotateDirection());
        view.CameraRotate(model.GetRotateDirection());

        if(weapon != null)
        {
            weapon.Tick();
        }
    }
}
