using UnityEngine;

public class GameAIContainer : MonoBehaviour
{
    [SerializeField] private AIView[] aIViews;

    public AIView[] GetAIViews => aIViews;
}
