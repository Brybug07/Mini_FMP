using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void Quit()
    {
        // If we are in the editor, stop playing the scene
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // Otherwise, quit the application
            Application.Quit();
#endif
    }
}