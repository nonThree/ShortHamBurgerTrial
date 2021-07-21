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

    [Header("Win Condition Indicators")]
    public GameObject bottombunTick;
    public GameObject lettuceTick;
    public GameObject tomatoTick;
    public GameObject baconTick;
    public GameObject cheeseTick;
    public GameObject topbunTick;

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

        DisplayWinConditions();

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

    private void DisplayWinConditions()
    {
        if(bottomBun)
        {
            bottombunTick.SetActive(true);
        }
        else
        {
            bottombunTick.SetActive(false);
        }
        
        if(lettuce)
        {
            lettuceTick.SetActive(true);
        }
        else
        {
            lettuceTick.SetActive(false);
        }

        if(tomato)
        {
            tomatoTick.SetActive(true);
        }
        else
        {
            tomatoTick.SetActive(false);
        }

        if(bacon)
        {
            baconTick.SetActive(true);
        }
        else
        {
            baconTick.SetActive(false);
        }

        if(cheese)
        {
            cheeseTick.SetActive(true);
        }
        else
        {
            cheeseTick.SetActive(false);
        }

        if(topBun)
        {
            topbunTick.SetActive(true);
        }
        else
        {
            topbunTick.SetActive(false);
        }
    }
}
