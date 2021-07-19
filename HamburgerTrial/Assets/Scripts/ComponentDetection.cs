using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentDetection : MonoBehaviour
{
    public BurgerDetection burgerDetection;

    RaycastHit hit;


    private void FixedUpdate()
    {
        if(transform.name == "Hand Controller")
        {
            HandDrawRay();
        }

        if(transform.name == "Bottom_bun(Clone)")
        {
            BBDrawRay();
        }

        if(transform.name == "Lettuce(Clone)")
        {
            LettuceDrawRay();
        }
        
        if(transform.name == "tomato(Clone)")
        {
            TomatoDrawRay();
        }
        
        if(transform.name == "Bacon(Clone)")
        {
            BaconDrawRay();
        }

        if(transform.name == "Cheese(Clone)")
        {
            CheeseDrawRay();
        }
    }

    public void HandDrawRay()
    {
        if(Physics.Raycast(transform.position,Vector3.up,out hit))
        {
            if(hit.collider.name == "Bottom_bun(Clone)")
            {
                burgerDetection.bottomBun = true;
            }
        }
    }

    public void BBDrawRay()
    {
        if (Physics.Raycast(transform.position, Vector3.up, out hit))
        {
            if (hit.collider.name == "Lettuce(Clone)" && burgerDetection.bottomBun == true)
            {
                burgerDetection.lettuce = true;
            }
        }
    }

    public void LettuceDrawRay()
    {
        if (Physics.Raycast(transform.position, Vector3.up, out hit))
        {
            if (hit.collider.name == "tomato(Clone)" && burgerDetection.lettuce == true)
            {
                burgerDetection.tomato = true;
            }
        }
    }

    public void TomatoDrawRay()
    {
        if (Physics.Raycast(transform.position, Vector3.up, out hit))
        {
            if (hit.collider.name == "Bacon(Clone)" && burgerDetection.tomato == true)
            {
                burgerDetection.bacon = true;
            }
        }
    }

    public void BaconDrawRay()
    {
        if (Physics.Raycast(transform.position, Vector3.up, out hit))
        {
            if (hit.collider.name == "Cheese(Clone)" && burgerDetection.bacon == true)
            {
                burgerDetection.cheese = true;
            }
        }
    }

    private void CheeseDrawRay()
    {
        if (Physics.Raycast(transform.position, Vector3.up, out hit))
        {
            if (hit.collider.name == "Top_Bun(Clone)" && burgerDetection.cheese == true)
            {
                burgerDetection.topBun = true;
            }
        }
    }
}
