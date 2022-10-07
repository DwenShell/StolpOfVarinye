using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NumeberActionParameter : MonoBehaviour
{
    [SerializeField]
    private IsItWin winCondition;

    public float numberOfActions;
    [SerializeField] Object nextLevel;

    void Start()
    {
        if (winCondition.characterAtGoodPlace == true)
        {
            winCondition.characterAtGoodPlace = false;
        }
        if (winCondition.moduleAtGoodPlace == true)
        {
            winCondition.moduleAtGoodPlace = false;
        }
        if (winCondition.scdModuleAtGoodPlace == true)
        {
            winCondition.scdModuleAtGoodPlace = false;
        }
        if ( winCondition.actionRestante != numberOfActions + 1f)
        {
            winCondition.actionRestante = 0;
            winCondition.actionRestante = numberOfActions + 1f;
        }
    }
    private void Update()
    {
        if (winCondition.characterAtGoodPlace == true && winCondition.moduleAtGoodPlace == true)
        {
            SceneManager.LoadScene(nextLevel.name);
        }
        if (winCondition.actionRestante == 0 && winCondition.characterAtGoodPlace == false)
        {
            Scene actualLevel = SceneManager.GetActiveScene();
            SceneManager.LoadScene(actualLevel.name, LoadSceneMode.Single);
        }
    }
}
