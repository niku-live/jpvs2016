using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour 
{
  
  public int maxPlatforms = 20;
  public GameObject platform;
  public GameObject deathPlace;
  public float horizontalMin = 7.5f;
  public float horizontalMax = 14f;
  public float verticalMin = -6f;
  public float verticalMax = 6;
    
  private Vector2 originPosition;
  private float ymax = 0f;
  private int notHit = 0;
  
  void Start () 
  {  
    originPosition = transform.position;
    ymax = originPosition.y;
    Spawn ();  
  }
  
  public void CheckAndSpawn()
  {
    if (notHit > 0)
    {
      notHit--;
    }
    
    if (notHit < 5)
    {  
      Spawn();
    }
  }
  
  public void Spawn()
  {
    ymax = originPosition.y;
    for (int i = 0; i < maxPlatforms; i++)
    {
      Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
      if (randomPosition.y < ymax)
      {
        ymax = randomPosition.y;
      }
      
      if (deathPlace.transform.position.y <= ymax + 30)
      {
        deathPlace.transform.position =  new Vector2(deathPlace.transform.position.x, ymax - 30);
      }
      
      Instantiate(platform, randomPosition, Quaternion.identity);
      originPosition = randomPosition;
      notHit++;
    }
    originPosition = new Vector2(originPosition.x, originPosition.y);    
  }
  
}
