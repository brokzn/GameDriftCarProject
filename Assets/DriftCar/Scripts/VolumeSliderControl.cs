using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderControl : MonoBehaviour
{
    public AudioVolumeControl audioVolumeControl;

    public Slider musicVolumeSlider;
    public Slider gameVolumeSlider;
    public Slider otherVolumeSlider;

    void Start()
    {
        musicVolumeSlider.onValueChanged.AddListener(delegate { SetMusicVolume(); });
        gameVolumeSlider.onValueChanged.AddListener(delegate { SetGameVolume(); });
        otherVolumeSlider.onValueChanged.AddListener(delegate { SetOtherVolume(); });

        LoadVolumes(); // Загружаем сохраненные громкости при загрузке слайдеров
    }

    // Загрузка громкостей из PlayerPrefs
    private void LoadVolumes()
    {
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            float volume = PlayerPrefs.GetFloat("MusicVolume");
            musicVolumeSlider.value = volume;
            SetMusicVolume(); // Устанавливаем громкость в соответствии с сохраненным значением
        }

        if (PlayerPrefs.HasKey("GameVolume"))
        {
            float volume = PlayerPrefs.GetFloat("GameVolume");
            gameVolumeSlider.value = volume;
            SetGameVolume(); // Устанавливаем громкость в соответствии с сохраненным значением
        }

        if (PlayerPrefs.HasKey("OtherVolume"))
        {
            float volume = PlayerPrefs.GetFloat("OtherVolume");
            otherVolumeSlider.value = volume;
            SetOtherVolume(); // Устанавливаем громкость в соответствии с сохраненным значением
        }
    }

    // Устанавливаем громкость музыки и сохраняем значение
    private void SetMusicVolume()
    {
        float volume = musicVolumeSlider.value;
        PlayerPrefs.SetFloat("MusicVolume", volume);
        PlayerPrefs.Save();
        audioVolumeControl.ApplyMusicVolume(volume); // Применяем измененную громкость
    }

    // Устанавливаем громкость игры и сохраняем значение
    private void SetGameVolume()
    {
        float volume = gameVolumeSlider.value;
        PlayerPrefs.SetFloat("GameVolume", volume);
        PlayerPrefs.Save();
        audioVolumeControl.ApplyGameVolume(volume); // Применяем измененную громкость
    }

    // Устанавливаем громкость других звуков и сохраняем значение
    private void SetOtherVolume()
    {
        float volume = otherVolumeSlider.value;
        PlayerPrefs.SetFloat("OtherVolume", volume);
        PlayerPrefs.Save();
        audioVolumeControl.ApplyOtherVolume(volume); // Применяем измененную громкость
    }
}
