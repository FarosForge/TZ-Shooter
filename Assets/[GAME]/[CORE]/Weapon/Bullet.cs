using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float dead_time;
    [SerializeField] private float speed;
    [SerializeField] private int damage;
    [SerializeField] private float force;

    void Start()
    {
        Destroy(gameObject, dead_time);
    }

    void Update()
    {
        transform.Translate(0,0,speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<AIView>(out var aI))
        {
            aI.onHitAction?.Invoke(damage);
            Destroy(gameObject);
        }

        if (other.TryGetComponent<PlayerView>(out var player))
        {
            player.onHitAction?.Invoke(0);
            player.BackForce(force);
            Destroy(gameObject);
        }
    }
}
