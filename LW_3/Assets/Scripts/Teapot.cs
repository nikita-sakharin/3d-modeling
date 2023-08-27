using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teapot : MonoBehaviour {
    public AudioClip clip;
    private bool isPlayed = false;
    private const float distance = 2.0F;

    void Start() {
    }

    void Update() {
        if (Vector3.Distance(Camera.main.transform.position,
            transform.position) < distance && !isPlayed) {
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(clip);
            isPlayed = true;
        }
    }
}
