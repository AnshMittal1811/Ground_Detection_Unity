using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private bool soundPlayed = false;

    // Update is called once per frame
    void Update()
    {
        if(!soundPlayed && transform.localPosition.y < 0.05f)
        {
            soundPlayed = true;
            StartCoroutine(DelayPlaySound());
        }
    }

    public void MoveCar()
    {
        transform.localPosition += new Vector3(0, 10, 0);
        transform.eulerAngles += new Vector3(5, 20, 5);
        soundPlayed = false;

    }

    IEnumerator DelayPlaySound()
    {
        yield return new WaitForSeconds(.2f);
        GetComponent<AudioSource>().Play();
    }
}
