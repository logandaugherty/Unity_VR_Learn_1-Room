using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlame : ToggleFlame
{
    [SerializeField] private Rigidbody rigid;
    [SerializeField] private float threshold;
    private void OnTriggerEnter(Collider other)
    {
        bool state = other.GetComponent<ToggleFlame>().GetFlame();
        if (state)
            SetFlame(true);
    }
    private void Update()
    {
        if (rigid.velocity.magnitude > threshold)
            SetFlame(false);
    }
}
