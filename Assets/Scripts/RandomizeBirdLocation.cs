using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeBirdLocation : MonoBehaviour
{
    AudioSource Audio;

    const float radius = 13;
    const float height = 5;

    Vector3 center = new Vector3(4.29f, 0, 1.38f);

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        StartCoroutine(UpdateBird());
    }

    IEnumerator UpdateBird()
    {
        while (true)
        {
            yield return new WaitForSeconds(7 + Random.Range(0, 6));
            float rad = Random.Range(0, 2 * Mathf.PI);
            Vector3 newPosition = new Vector3(Mathf.Cos(rad) * radius, height, Mathf.Sin(rad) * radius);
            newPosition += center;
            Audio.transform.position = newPosition;
            Audio.Play();
        }
    }
}
