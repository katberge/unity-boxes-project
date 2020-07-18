using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstacle") 
        {
            // stop the player movement script if it hits an obstacle
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
