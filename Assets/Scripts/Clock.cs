using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private Transform hour_hand;
    [SerializeField] private Transform minute_hand;
    [SerializeField] private Transform second_hand;
    [SerializeField] private Transform body;

    private float hour_degress = 0;
    private float minute_degress = 0;
    private float second_degress = 0;

    void rotateHand(int time, int loop, ref Transform hand, ref float stored_deg)
    {
        float degrees = 0;
        if (time != 0)
            degrees = 360 * (1f * time / loop);

        Vector3 center = body.position;

        hand.RotateAround(center, Vector3.right, degrees-stored_deg);

        stored_deg = degrees;
    }

    // Update is called once per frame
    void Update()
    {
        rotateHand(DateTime.Now.Hour, 12, ref hour_hand, ref hour_degress);
        rotateHand(DateTime.Now.Minute, 60, ref minute_hand, ref minute_degress);
        rotateHand(DateTime.Now.Second, 60, ref second_hand, ref second_degress);
    }
}
