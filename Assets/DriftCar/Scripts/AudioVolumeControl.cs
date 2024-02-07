using UnityEngine;

public class AudioVolumeControl : MonoBehaviour
{
    public AudioSource musicAudioSource;
    public AudioSource gameAudioSource;
    public AudioSource otherAudioSource;

    private void Start()
    {
        LoadVolume();
    }

    // Загрузка громкости из PlayerPrefs
    private void LoadVolume()
    {
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            float volume = PlayerPrefs.GetFloat("MusicVolume");
            ApplyMusicVolume(volume); // Применяем загруженную громкость для музыки
        }

        if (PlayerPrefs.HasKey("GameVolume"))
        {
            float volume = PlayerPrefs.GetFloat("GameVolume");
            ApplyGameVolume(volume); // Применяем загруженную громкость для звуков игры
        }

        if (PlayerPrefs.HasKey("OtherVolume"))
        {
            float volume = PlayerPrefs.GetFloat("OtherVolume");
            ApplyOtherVolume(volume); // Применяем загруженную громкость для других звуков
        }
    }

    // Применяем громкость к музыке
    public void ApplyMusicVolume(float volume)
    {
        if (musicAudioSource != null)
        {
            musicAudioSource.volume = volume;
        }
    }

    // Применяем громкость к звукам игры
    public void ApplyGameVolume(float volume)
    {
        if (gameAudioSource != null)
        {
            gameAudioSource.volume = volume;
        }
    }

    // Применяем громкость к другим звукам
    public void ApplyOtherVolume(float volume)
    {
        if (otherAudioSource != null)
        {
            otherAudioSource.volume = volume;
        }
    }
}
