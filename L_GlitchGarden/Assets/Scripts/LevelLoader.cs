using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int loadingTime = 3;
    int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(loadingTime);
        LoadNextScene();
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
