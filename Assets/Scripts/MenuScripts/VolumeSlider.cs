using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixer mixer;
    public string parameterName;
    public Slider slider;

    void Awake()
    {
        // Load saved value or use default (1.0 for max volume)
        float savedVol = PlayerPrefs.GetFloat(parameterName, 1.0f);
        SetVolume(savedVol);
        slider.value = savedVol;

        slider.onValueChanged.AddListener((float _) => SetVolume(_));
    }

    void SetVolume(float value)
    {

        float dbValue = Mathf.Log10(Mathf.Max(value, 0.0001f)) * 20f;

        mixer.SetFloat(parameterName, dbValue);
        PlayerPrefs.SetFloat(parameterName, value);
        PlayerPrefs.Save();
    }
}