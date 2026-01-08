using UnityEngine;

public class StateManager : MonoBehaviour
{
    [Header("State Handlers")]
    [SerializeField] private Initialization initialization;
    [SerializeField] private Dealing dealing;

    public static StateManager Instance;
    private GameState currentState;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        ChangeState(GameState.Initialization);
    }

    public void ChangeState(GameState newState)
    {
        Debug.Log($"Changing state to {newState}");
        currentState = newState;
        SetCurrentState();
    }

    private void SetCurrentState()
    {
        switch (currentState)
        {
            case GameState.Initialization:
                initialization.StartInitialization();
                break;

            case GameState.Dealing:
                dealing.StartDealing();
                break;
        }
    }
}
