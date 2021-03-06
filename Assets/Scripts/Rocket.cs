﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
  Rigidbody rigidBody;
  AudioSource audioSource;

  // Start is called before the first frame update
  void Start() {
    rigidBody = GetComponent<Rigidbody>();
    audioSource = GetComponent<AudioSource>();
  }

  // Update is called once per frame
  void Update() {
    ProcessInput();
  }

  void ProcessInput() {
    audioSource.Pause();
    if (Input.GetKey(KeyCode.Space)) {
      rigidBody.AddRelativeForce(Vector3.up);
      audioSource.Play();
    }
    if (Input.GetKey(KeyCode.A)) {
      transform.Rotate(Vector3.forward);
    }
    if (Input.GetKey(KeyCode.D)) {
      transform.Rotate(-Vector3.forward);
    }
  }
}
