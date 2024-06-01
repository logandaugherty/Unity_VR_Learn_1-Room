using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSoundControl : MonoBehaviour
{
    private AudioSource audioSource;
    private Rigidbody rigid;

    [SerializeField] private float maxVolVelocity = 4f;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rigid = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        float volumeScale = Vector3.Magnitude(rigid.velocity) / maxVolVelocity;
        volumeScale = Mathf.Clamp(volumeScale, 0.0f, 1f);
        audioSource.volume = volumeScale;

        audioSource.Play();
    }
}
