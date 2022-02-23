public class WeaponController : IWeapon
{
    private IAttack attack;
    private IWeaponView view;

    public WeaponController(IWeaponView view, bool ai = false)
    {
        this.view = view;
        attack = new AttackModel(ai);
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
