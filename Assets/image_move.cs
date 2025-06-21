using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class image_move : MonoBehaviour
{

    int[] posX = new int[] { 0, -20, -40, -60, -80, -100, -120, -140 };
    int idx = 0;
    public AudioSource[] audio;

    // Use this for initialization
    void Start()
    {
        audio[idx].Play();
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (idx < posX.Length - 1)
            {
                audio[idx].Stop();
                idx++;
                audio[idx].Play();
            }
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (idx > 0)
            {
                audio[idx].Stop();
                idx--;
                audio[idx].Play();
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(posX[idx], transform.position.y), 50 * Time.deltaTime);
    }
}