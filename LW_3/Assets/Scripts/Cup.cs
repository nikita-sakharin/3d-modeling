using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Cup : MonoBehaviour {
    private const float moveSpeed = 0.25F;
    private float cupTime = 0.0F;

    void Start() {
    }

    void Update() {
        if (Input.GetKey(KeyCode.Return)) {
            transform.Translate(Mathf.Cos(cupTime) * Vector3.right
                * moveSpeed * Time.deltaTime);
            cupTime += Time.deltaTime;
        }
    }
}
