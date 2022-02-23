using UnityEngine;
using UnityEngine.UI;

public class GameUIContainer : MonoBehaviour
{
    [SerializeField] private Image crosshair;
    public Image GetCrosshair => crosshair;
}
