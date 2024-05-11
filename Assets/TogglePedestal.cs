using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePedestal : MonoBehaviour
{
    [SerializeField] private bool startState = true;
    [SerializeField] private GameObject pedestal;
    private bool state;
    
    public void Toggle()
    {
        state = !state;
        pedestal.SetActive(state);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (startState)
            pedestal.SetActive(true);
        else
            pedestal.SetActive(false);
    }
}
