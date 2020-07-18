using UnityEngine;

public class Pause : MonoBehaviour
{
    public PlayerMovement movement;
    bool paused = false;

    public void PauseGame()
    {
        if (paused == false) {
            movement.enabled = false;
            paused = true;
        } else {
            movement.enabled = true;
            paused = false;
        }
    }
    
}
