using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    void Start()
    {
        GameObject[] musicPlayers = GameObject.FindGameObjectsWithTag("Music");

        if (musicPlayers.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
