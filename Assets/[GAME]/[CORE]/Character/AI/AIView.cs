using System.Collections;
using UnityEngine;
using AI;
using System;

public class AIView : MonoBehaviour, IAIView
{
    [SerializeField] private Components components;
    [SerializeField] private AIProperty property;
    [SerializeField] private WeaponView weapon;

    private bool isDisposed;

    public Components Components => components;
    public AIProperty Property => property;
    public WeaponView current_Weapon => weapon;

    public Action<int> onHitAction { get; set; }

    public void Move(Vector3 direction)
    {
        if(Components.moveType == MoveType.Move)
            components.transform.position = direction;
    }

    public void LookToTarget(Vector3 targetPosition)
    {
        components.transform.LookAt(new Vector3(targetPosition.x, components.transform.position.y, targetPosition.z));
    }

    public void Dispose()
    {
        if(!isDisposed)
        {
            StartCoroutine(waitToDisactivate());
        }
    }

    private IEnumerator waitToDisactivate()
    {
        isDisposed = true;
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }
}

namespace AI
{
    [System.Serializable]
    public struct Components
    {
        public MoveType moveType;
        public Transform transform;
        public Transform[] move_points;
    }

    public enum MoveType
    {
        Idle,
        Move
    }

    [System.Serializable]
    public struct AIProperty
    {
        public float move_speed;
        public float attack_distance;
        public int HP;
    }
}


