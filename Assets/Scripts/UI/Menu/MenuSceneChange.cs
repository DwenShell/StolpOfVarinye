using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuSceneChange : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Option;

    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Options()
    {
        Option.SetActive(true);
        Menu.SetActive(false);
    }
    public void BackMenu()
    {
        Menu.SetActive(true);
        Option.SetActive(false);
    }
    public void MuteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
