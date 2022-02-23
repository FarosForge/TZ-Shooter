using System.Collections.Generic;
using UnityEngine;

public class GameAIController : IGameController
{
    private readonly GameAIContainer container;
    private List<IEquiped> bots = new List<IEquiped>();
    private Transform player_transform;

    public GameAIController(GameAIContainer container, Transform _player_transform)
    {
        this.container = container;
        player_transform = _player_transform;
    }

    public void Init()
    {
        for (int i = 0; i < container.GetAIViews.Length; i++)
        {
            var bot = new AIController(container.GetAIViews[i], player_transform);
            bot.Init();
            bots.Add(bot);
        }
    }

    public void Tick()
    {
        foreach (var bot in bots)
        {
            bot.Tick();
        }
    }
}
