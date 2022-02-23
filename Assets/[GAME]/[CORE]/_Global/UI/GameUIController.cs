public class GameUIController : IGameController
{
    private readonly GameUIContainer container;

    private CrosshairModel crosshair;

    public GameUIController(GameUIContainer container)
    {
        this.container = container;
    }

    public void Init()
    {
        crosshair = new CrosshairModel();
    }

    public void Tick()
    {
        crosshair.SetCrosshairColor(container.GetCrosshair);
    }
}
