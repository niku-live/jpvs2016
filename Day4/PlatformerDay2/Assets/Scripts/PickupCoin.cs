using UnityEngine;
using System.Collections;

public class PickupCoin : MonoBehaviour 
{

  void Start () 
  {
  }
  
  void Update () 
  {
  }
  
  void OnTriggerEnter2D (Collider2D other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      Destroy(gameObject);
      PlayerController controller = other.gameObject.GetComponent<PlayerController>();
      controller.AddScore();
    }
  }
  
}
