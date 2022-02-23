using UnityEngine;

public class AttackModel : IAttack
{
    private float timer;

    private readonly bool ai;

    public AttackModel(bool _ai)
    {
        ai = _ai;
    }

    public bool CanShoot(float shoot_rate)
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            if (!ai)
            {
                if (Input.GetMouseButton(0))
                {
                    timer = shoot_rate;
                    return true;
                }
            }
            else
            {
                timer = shoot_rate;
                return true;
            }
        }

        return false;
    }
    public GameObject SetBullet(GameObject prefab, Transform point)
    {
        var bullet = Object.Instantiate(prefab);
        bullet.transform.parent = point;
        bullet.transform.localPosition = Vector3.zero;
        bullet.transform.localRotation = Quaternion.Euler(Vector3.zero);
        bullet.transform.parent = null;
        bullet.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

        return bullet;
    }
}
