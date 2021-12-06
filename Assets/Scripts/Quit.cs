using UnityEngine;

public class Quit : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject pausemenuUI;
    public GameObject objectToDisable;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }

    public void resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    void pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("box"))
        {
            QuitGame();
        }
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT!");
    }
    public void MusicOff()
    {
        objectToDisable.SetActive(false);
    }
    public void MusicOn()
    {
        objectToDisable.SetActive(true);
    }


}
