using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCheck : MonoBehaviour
{
    [SerializeField] private GameObject Visual;
    [SerializeField] private bool startState = false;

    public void EnableVisual()
    {
        Visual.SetActive(true);
    }

    public void DisableVisual()
    {
        Visual.SetActive(false);
    }
    private void Start()
    {
        if (startState)
            EnableVisual();
    }
}
