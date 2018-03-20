using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    public void LoadNewScene(int level)
    {
        if(level == 1)
        {
            TowerLifeSpan.KnightsToKill = 30;
        } else if (level == 0)
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().StopMusic();

        }
        SceneManager.LoadScene(level);
    }
}
