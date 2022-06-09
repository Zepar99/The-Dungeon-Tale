using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsChange : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public string scene;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("box"))
        {
            LoadNextLevel();
        }

    }
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel());
    }
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }
}
