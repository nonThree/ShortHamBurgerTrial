using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerComponentsDrop : MonoBehaviour
{
    [Header("Burger Components")]
    public GameObject[] BurgerComponents;
    public Transform spawnPos;

    public int recentComponent;

    public float timeRemaining;

    private void Start()
    {

    }

    private void Update()
    {
        SpawnSpecific();
        Timer();
    }

    private void Timer()
    {
        if(timeRemaining < 0)
        {
            timeRemaining = .8f;
            //SpawnRandom();
        }
        else
        {
            timeRemaining -= Time.deltaTime;
        }
    }

    private void SpawnSpecific()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(BurgerComponents[recentComponent], spawnPos.position, spawnPos.rotation);
            recentComponent--;
        }
    }

    private void SpawnRandom()
    {
        int randomComponent = Random.Range(0, BurgerComponents.Length);
        if(randomComponent == recentComponent)
        {

            switch(randomComponent)
            {
                case 5:
                    randomComponent = 0;
                    break;
                default:
                    randomComponent++;
                    break;
            }
        }
        recentComponent = randomComponent;
        Instantiate(BurgerComponents[randomComponent], spawnPos.position, spawnPos.rotation);
    }

    
}
