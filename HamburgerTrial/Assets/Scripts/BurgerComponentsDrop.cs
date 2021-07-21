using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BurgerComponentsDrop : MonoBehaviour
{
    public BurgerDetection burgerDetection;

    [Header("Burger Components")]
    public GameObject[] BurgerComponents;
    public Transform[] spawnPos;
    public Transform target;

    public Text text;

    public int recentComponent;

    public float t;

    public float timeRemaining;

    private void Start()
    {
        recentComponent = 5;
    }

    private void Update()
    {
        Timer();
    }
    private void FixedUpdate()
    {
        MovingSpawner();
    }

    private void Timer()
    {
        if(timeRemaining < 0)
        {
            timeRemaining = 5f;
            TutorialDrop();
        }
        else
        {
            timeRemaining -= Time.deltaTime;
        }
    }

    private void TutorialDrop()
    {
        Instantiate(BurgerComponents[recentComponent], transform.position, transform.rotation);
       if(!burgerDetection.bottomBun)
        {
            recentComponent = 5;
            text.text = "Bottom Bun";
        }
       else if(!burgerDetection.lettuce)
        {
            recentComponent = 4;
            text.text = "Lettuce";
        }
       else if(!burgerDetection.tomato)
        {
            recentComponent = 3;
            text.text = "Tomato";
        }
       else if(!burgerDetection.bacon)
        {
            recentComponent = 2;
            text.text = "Bacon";
        }
       else if(!burgerDetection.cheese)
        {
            recentComponent = 1;
            text.text = "Cheese";
        }
        else
        {
            recentComponent = 0;
            text.text = "Top Bun";
        }
        
    }

    private void MovingSpawner()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;

        if (Vector3.Distance(transform.position, target.position) < 0.2f)
        {
            target.position = new Vector3(Random.Range(-4,4), b.y , Random.Range(-7.5f,7.5f));

        }
        else
        {
            transform.position = Vector3.MoveTowards(a, b, 0.1f);
        }
    }
    
}
