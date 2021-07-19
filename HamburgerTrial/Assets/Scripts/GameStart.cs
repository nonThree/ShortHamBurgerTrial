using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject Detector;

    private void Start()
    {
        Instantiate(Detector, transform.position, transform.rotation);
    }
}
