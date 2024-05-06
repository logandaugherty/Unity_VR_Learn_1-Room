using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotateReticle : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Rotate Reticle at a fixed rate
        transform.Rotate(Vector3.up, 100 * Time.deltaTime);
    }
}
