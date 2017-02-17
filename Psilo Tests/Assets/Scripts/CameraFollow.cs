using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
      public GameObject player;
      public float cameraHeight = 20.0f;
      public float cameraDistance = 20.0f;
      public Transform target;

      void Update() {
          Vector3 pos = player.transform.position;
          pos.y += cameraHeight;
          pos.z += cameraDistance;
          transform.position = pos;
          transform.LookAt(target);
      }
  }