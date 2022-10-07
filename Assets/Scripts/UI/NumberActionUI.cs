using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberActionUI : MonoBehaviour
{
    [SerializeField]
    private IsItWin winCondition;

    private float numAction;

    public Text numberAction;
    // Start is called before the first frame update
    void Start()
    {
        numberAction.text = "Action Restante";
    }

    // Update is called once per frame
    void Update()
    {
        numAction = winCondition.actionRestante - 1;
        numberAction.text = "Action    Restante" + "    " + numAction;
    }
}
