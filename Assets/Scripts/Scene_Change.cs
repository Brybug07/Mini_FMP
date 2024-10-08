using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management
using UnityEngine.UI; // Required for UI components

public class SceneChanger : MonoBehaviour
{
    public string Scene; // The name of the scene to load

    // This method can be linked to a button click
    public void ChangeScene()
    {
        SceneManager.LoadScene(Scene);
    }
}