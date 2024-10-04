using UnityEngine;
using UnityEngine.SceneManagement;

public class Room_Transition : MonoBehaviour
{
    // Set the name of the scene you want to transition to in the Inspector
    public string Scene2;

   /*
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger true");
        
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("tag true");
            
            // Load the specified scene
            SceneManager.LoadScene(Scene2);
        }
    }
   */
   
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("collision true");
        
        // Check if the object entering the trigger is the player
        if (collision.collider.CompareTag("Player"))
        {
            //Debug.Log("tag true");

            // Load the specified scene
            SceneManager.LoadScene(Scene2);
        }
    }

   
}
