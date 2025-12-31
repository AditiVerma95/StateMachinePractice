using UnityEngine;

public class StateManager : MonoBehaviour
{
  [Header("StateHandlers")]
  [SerializeField] private Initialization initialization;
  public static StateManager Instance;
  public GameState currentState;
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

  public void SetCurrentState()
  {
    switch (currentState)
    {
      case GameState.Initialization:
        initialization.SpawnCardDeck();
        break;
    }
  }
}
