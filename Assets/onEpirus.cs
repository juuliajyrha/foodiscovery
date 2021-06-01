using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onEpirus : MonoBehaviour
{
    public GameObject epirusMap;
    // Start is called before the first frame update
    void Start()
    {
        epirusMap.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        epirusMap.SetActive(true);
    }

    void OnMouseExit()
    {
        epirusMap.SetActive(false);
    }

}
