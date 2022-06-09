using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject pausemenuUI;
    public AudioSource audioSource;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausemenuUI.SetActive(true);
            GameState currentGameState = GmaeStateManager.Instance.currentGameState;
            GameState newGameState = currentGameState == GameState.Gameplay
               ? GameState.Paused
               : GameState.Gameplay;
            GmaeStateManager.Instance.SetState(newGameState);
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("box"))
        {
            QuitGame();
        }
    }
    public void Resume()
    {
        GameState currentGameState = GmaeStateManager.Instance.currentGameState;
        GameState newGameState = currentGameState == GameState.Gameplay
            ? GameState.Gameplay
            : GameState.Paused;

        pausemenuUI.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT!");
    }
    public void MusicOff()
    {
        audioSource.Pause();
    }
    public void MusicOn()
    {
        audioSource.UnPause();
    }


}
