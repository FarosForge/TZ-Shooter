using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponView : MonoBehaviour, IWeaponView
{
    [SerializeField] private WeaponProperty property;
    public WeaponProperty Property => property;
}

[System.Serializable]
public struct WeaponProperty
{
    public Transform bulletSpawnPoint;
    public GameObject bullet_prefab;
    public float shoot_rate;
}
