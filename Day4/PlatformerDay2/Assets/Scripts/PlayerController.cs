using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	
  public float moveForce = 365f;
  public float maxSpeed = 5f;	
  public float jumpForce = 100f;
  public Transform groundCheck;	
  public Text scoreText;
  
  private int score = 0;		
  private bool jump = false;
  private bool grounded = false;	
  private bool facingRight = true;
  private Rigidbody2D rb2d;
  private Animator anim;
  
  void Awake () 
  {        
    rb2d = GetComponent<Rigidbody2D>();
    anim = GetComponent<Animator>();
  }
  
  void FixedUpdate()
  {  
    float x = Input.GetAxis("Horizontal");
    anim.SetFloat("Speed", Mathf.Abs(x));
    if (x * rb2d.velocity.x < maxSpeed)
    {
      rb2d.AddForce(Vector2.right * x * moveForce);
    }
    
    if (Mathf.Abs (rb2d.velocity.x) > maxSpeed)
    {
      rb2d.velocity = new Vector2(Mathf.Sign (rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);
    }
        
    if ((x > 0) && !facingRight)
    {
      Flip ();
    }
    else if ((x < 0) && facingRight)
    {
      Flip ();        
    }
    
    if (jump)
    {            
      rb2d.AddForce(new Vector2(0f, jumpForce));
      jump = false;            
    }        
  }
  
  void Flip()
  {
    facingRight = !facingRight;
    Vector3 theScale = transform.localScale;
    theScale.x = theScale.x * -1;
    transform.localScale = theScale;
  }	
  
  void Start () 
  {  
  }
  
  void Update () 
  {
    grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));    
    if (Input.GetButtonDown("Jump") && grounded)
    {
      jump = true;
    }	
  }
  
  public void AddScore()
  {
    score++;
    scoreText.text = "Score: " + score.ToString();
  }
	
}
