using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    public AudioSource musicSource;
    public AudioMixerGroup mixerGroup; // Optional: Assign your Music Mixer Group here

    void Awake()
    {
        // Singleton Pattern: Check if an instance already exists
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // Destroy duplicate
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); // Persist across scenes

        // Optional: Assign mixer group if not set in Inspector
        if (mixerGroup != null)
        {
            musicSource.outputAudioMixerGroup = mixerGroup;
        }
    }

    public void PlayMusic(AudioClip clip)
    {
        if (musicSource.clip == clip && musicSource.isPlaying) return;

        musicSource.clip = clip;
        musicSource.loop = true;
        musicSource.Play();
    }

    // Optional: Change music based on scene
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Example logic: Play specific track for specific scenes
        // if (scene.name == "Level1") PlayMusic(level1Track);
    }
}