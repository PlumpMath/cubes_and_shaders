using UnityEngine;
using System.Collections;

public class SpinForce : MonoBehaviour {

  public float rotationSpeed;


  void Start ()
  {
    rigidbody.AddRelativeTorque (Vector3.up * 15);
  }


  void FixedUpdate ()
  {

  }
}
