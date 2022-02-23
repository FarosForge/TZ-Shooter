using UnityEngine;
using UnityEngine.Events;

public class LocalEventsTrigger : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private bool IsEntered;

    private void OnTriggerEnter(Collider other)
    {
        if (IsEntered) return;

        if(other.GetComponent<PlayerView>())
        {
            triggerEvent?.Invoke();
        }
    }
}
