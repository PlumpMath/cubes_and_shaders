using UnityEngine;
using System.Collections;

public class SpinAttribute : MonoBehaviour {

  public float rotationSpeed;


  void Start ()
  {
  }


  void Update ()
  {
    transform.RotateAroundLocal(Vector3.up, Time.deltaTime * rotationSpeed);
  }
}
