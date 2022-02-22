using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float dead_time;
    [SerializeField] private float speed;

    void Start()
    {
        Destroy(gameObject, dead_time);
    }

    void Update()
    {
        transform.Translate(0,0,speed);
    }


}
