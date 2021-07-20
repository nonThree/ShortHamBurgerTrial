using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerDetection : MonoBehaviour
{
    public LoadNextScene loadNextScene;

    //Check for top to bottom
    [Header("Win Conditions")]
    public bool bottomBun = false;
    public bool lettuce = false;
    public bool tomato = false;
    public bool bacon = false;
    public bool cheese = false;
    public bool topBun = false;

    public bool GameWin;

    private void Start()
    {
        bottomBun = false;
        lettuce = false;
        tomato = false;
        bacon = false;
        cheese = false;
        topBun = false;
    }

    private void Update()
    {
        CheckWinConditions();

        if(GameWin == true)
        {
            loadNextScene.LoadNext();
        }
    }

    private void CheckWinConditions()
    {
        if (bottomBun == true && lettuce == true && tomato == true && bacon == true && cheese == true & topBun == true)
        {
            if(!GameWin)
            {
                GameWin = true;
            }
        }
    }
}
