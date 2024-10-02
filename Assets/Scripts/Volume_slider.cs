using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource;

    private void Start()
    {
        // Set the initial volume based on the slider value
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 0.5f); // Default volume is 0.5
        audioSource.volume = volumeSlider.value;

        // Add a listener to the slider
        volumeSlider.onValueChanged.AddListener(OnVolumeChange);
    }

    private void OnVolumeChange(float value)
    {
        audioSource.volume = value;
        PlayerPrefs.SetFloat("Volume", value); // Save volume preference
    }
}
