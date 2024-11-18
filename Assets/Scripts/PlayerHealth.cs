using UnityEngine;
using UnityEngine.SceneManagement; // Add this to use SceneManager

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount; // Subtract damage
        if (health <= 0)
        {
            Debug.Log("Player is dead!");
            LoadLoseScreen(); // Load the lose screen instead of destroying the player
        }
    }

    private void LoadLoseScreen()
    {
        // Replace "LoseScreen" with the name of your actual scene
        SceneManager.LoadScene("LoseScreen");
    }
}
