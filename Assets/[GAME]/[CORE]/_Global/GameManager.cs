using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerView playerView;

    private PlayerController player;

    void Start()
    {
        player = new PlayerController(playerView);
        player.Init();
    }

    void Update()
    {
        player.Tick();
    }
}
