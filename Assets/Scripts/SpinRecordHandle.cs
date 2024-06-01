using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinRecordHandle : MonoBehaviour
{
    private float centerRot = 53;
    private float rangeRot = 10;

    private float targetRot = 53;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RandomizeTarget());
    }

    IEnumerator RandomizeTarget()
    {
        while (true)
        {
            targetRot = centerRot + Random.Range(-0.5f, 0.5f) * rangeRot;
            yield return new WaitForSeconds(2f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetEuler = transform.localEulerAngles;
        targetEuler.y = targetRot;
        transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles, targetEuler, 0.1f);
    }
}
