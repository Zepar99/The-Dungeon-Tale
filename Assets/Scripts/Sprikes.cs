using UnityEngine;
using UnityEngine.SceneManagement;

public class Sprikes : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player") || other.CompareTag("Player2"))
        {
            LoadScene();
        }
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
