using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameSceneManager : MonoBehaviour
{
    [SerializeField] private float reloadDelay = 2f;
    public void ReloadLevel()
    {
        StartCoroutine(ReloadLevelAfterDelay(reloadDelay));
    }

    IEnumerator ReloadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
