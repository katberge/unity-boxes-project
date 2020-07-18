using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter() 
    {
        gameManager.CompleteLevel(); // call complete level function in game manager 
    }
}
