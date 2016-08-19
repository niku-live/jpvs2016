using UnityEngine;
using System.Collections;

public class PlatformFall : MonoBehaviour 
{
	
  public float fallDelay = 10f;
  
  private Rigidbody2D rb2d;
  
  void Awake()
  {
    rb2d = GetComponent<Rigidbody2D>();
  }
  
  void OnCollisionEnter2D (Collision2D other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      Invoke ("Fall", fallDelay);
      SpawnPlatforms manager = GameObject.Find ("SpawnManager").GetComponent<SpawnPlatforms>();
      manager.CheckAndSpawn();
    }
  }
  
  void Fall()
  {
    rb2d.isKinematic = false;
  }

}
