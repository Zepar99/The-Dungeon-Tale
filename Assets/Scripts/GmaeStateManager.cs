using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GmaeStateManager : SingletonGeneric<GmaeStateManager>
{
    public GameState currentGameState { get; private set; }
    public delegate void GameStateChangeHandler(GameState newGameState);
    public event GameStateChangeHandler OnGameStateChanged;

    private GmaeStateManager()
    {

    }
    public void SetState(GameState newGameState)
    {
        if (newGameState == currentGameState)
        {
            return;
        }
        currentGameState = newGameState;
        OnGameStateChanged?.Invoke(newGameState);
    }

}
