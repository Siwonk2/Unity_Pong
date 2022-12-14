using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  private Rigidbody2D _rigidbody;

  private float BallSpeed = 100.0f;

  private bool ballPower = false;
  private bool isPowerShot = false;

  

  private void Awake(){
    _rigidbody = GetComponent<Rigidbody2D>();
  }
  private void Start()
  { 
    ResetPosition();
    AddStartingForce();

  }

  public void AddStartingForce()
  {
    float x = Random.value < 0.5f ? -1.0f : 1.0f;
    float y = Random.value < 0.5f ? Random.Range(-1.0f,-0.5f): Random.Range(0.5f,1.0f);

    Vector2 direction = new Vector2(x,y);

    _rigidbody.AddForce(direction * BallSpeed);
  }

  public void addForce(Vector2 force){
    _rigidbody.AddForce(force);
  }

  public void ResetPosition(){
    _rigidbody.position = Vector3.zero;
    _rigidbody.velocity = Vector3.zero;
  }

  public void powerShot(){
    ballPower = true;

  }

  public Rigidbody2D GetRigidbody2D(){
    return _rigidbody;
  }

 

  public bool getPowerReady(){
    return ballPower;
  }

   public void setPowerReadyFalse(){
    ballPower = false;
  }

   public bool getIsPowerShot(){
    return isPowerShot;
  }

   public void setIsPowerShot(bool isPower){
    isPowerShot = isPower;
  }

  public void resetBallSettings(){
    ballPower = false;
    isPowerShot = false;
  }




}
