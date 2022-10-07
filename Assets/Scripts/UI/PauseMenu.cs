using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseController;
    public Vector2 StartPos;
    public Vector2 EndPos;

    [SerializeField] private AnimationCurve curve;
    private float time = 0;

    private bool allowMovement = false;
    public bool menuOn = false;

    public void Pause()
    {
        time = 0;
        //Time.timeScale = 1f;
        if (menuOn != true)
            menuOn = true;
        else
            menuOn = false;
        allowMovement = true;
    }
    public void Menu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void Restart()
    {

        Scene actualLevel = SceneManager.GetActiveScene();
        SceneManager.LoadScene(actualLevel.name, LoadSceneMode.Single);

    }
    private void Update()
    {

        if (allowMovement == true && menuOn == false)
        {
            MenuOpen();
        }

        else if (allowMovement == true && menuOn == true)
        {
            MenuClose();
        }
        /*if (PauseController.transform.localPosition.y == -50)
            Time.timeScale = 1f;
        if (PauseController.transform.localPosition.y == -617)
            Time.timeScale = 0f;*/
    }

    private void MenuClose()
    {
        MenuDeroulant(PauseController.transform.localPosition, new Vector2(0, -50));
    }

    private void MenuOpen()
    {
        MenuDeroulant(PauseController.transform.localPosition, new Vector2(0, -617));
    }

    private void MenuDeroulant(Vector2 StartPos, Vector2 EndPos)
    {
        time = time + Time.deltaTime;
        if (time > 1)
        {
            time = 1;
            allowMovement = false;
            /*if (Time.timeScale == 1f)
                Time.timeScale = 0f;
            else if (Time.timeScale == 0f)
                Time.timeScale = 1f;*/
        }

        PauseController.transform.localPosition = Vector2.Lerp(StartPos, EndPos, curve.Evaluate(time));
    }
}
