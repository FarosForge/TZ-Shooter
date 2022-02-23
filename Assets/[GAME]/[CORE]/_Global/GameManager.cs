using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerView playerView;
    [SerializeField] private GameAIContainer aIContainer;
    [SerializeField] private GameUIContainer uIContainer;

    private PlayerController player;
    private GameAIController aIController;
    private GameUIController uIController;

    void Start()
    {
        HideCursor();

        player = new PlayerController(playerView);
        player.Init();

        aIController = new GameAIController(aIContainer, playerView.transform);
        aIController.Init();

        uIController = new GameUIController(uIContainer);
        uIController.Init();
    }

    void Update()
    {
        player.Tick();
        aIController.Tick();
        uIController.Tick();
    }

    void HideCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Lose()
    {
        Debug.Log("You Lose");
        SceneManager.LoadScene(0);
    }

    public void Win()
    {
        Debug.Log("You Win");
        SceneManager.LoadScene(0);
    }
}
