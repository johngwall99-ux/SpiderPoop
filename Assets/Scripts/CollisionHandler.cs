using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boulder"))
        {
            Object.FindAnyObjectByType<GameManager>().TriggerGameOver();
            
            //remove player from game when hit by boulder
           Destroy(gameObject); 
        }
        
        
    }
}
