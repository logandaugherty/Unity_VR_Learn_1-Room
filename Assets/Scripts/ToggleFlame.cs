using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFlame : MonoBehaviour
{
    private ToggleParticle toggleParticle;
    private bool flame_enabled = false;

    protected void SetFlame(bool state)
    {
        flame_enabled = state;
        if (flame_enabled)
            toggleParticle.Play();
        else toggleParticle.Stop();
    }
    public bool GetFlame()
    {
        return flame_enabled;
    }
    public void Toggle()
    {
        flame_enabled = !flame_enabled;
        SetFlame(flame_enabled);
    }
    // Start is called before the first frame update
    void Start()
    {
        toggleParticle = GetComponent<ToggleParticle>();
        SetFlame(flame_enabled);
    }
}
