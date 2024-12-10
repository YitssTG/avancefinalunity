using UnityEngine;
using UnityEngine.UI;
public class AudioControl : MonoBehaviour
{
    public AudioSource[] audioSource;
    public string key;
    private float value;

    public Slider slider;
    private void Start()
    {
        value = 1;
        value = PlayerPrefs.GetFloat(key, value);
        UpdateSound();
        if (slider != null)
        {
            slider.value = value;
        }
    }
    public void SliderValue(float value)
    {
        this.value = value;
        UpdateSound();
    }
    private void UpdateSound()
    {
        for (int i = 0; i < audioSource.Length; i++)
        {
            audioSource[i].volume = value;
        }
        PlayerPrefs.SetFloat(key, value);
    }
}
