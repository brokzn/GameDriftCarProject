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

        LoadVolumes(); // ��������� ����������� ��������� ��� �������� ���������
    }

    // �������� ���������� �� PlayerPrefs
    private void LoadVolumes()
    {
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            float volume = PlayerPrefs.GetFloat("MusicVolume");
            musicVolumeSlider.value = volume;
            SetMusicVolume(); // ������������� ��������� � ������������ � ����������� ���������
        }

        if (PlayerPrefs.HasKey("GameVolume"))
        {
            float volume = PlayerPrefs.GetFloat("GameVolume");
            gameVolumeSlider.value = volume;
            SetGameVolume(); // ������������� ��������� � ������������ � ����������� ���������
        }

        if (PlayerPrefs.HasKey("OtherVolume"))
        {
            float volume = PlayerPrefs.GetFloat("OtherVolume");
            otherVolumeSlider.value = volume;
            SetOtherVolume(); // ������������� ��������� � ������������ � ����������� ���������
        }
    }

    // ������������� ��������� ������ � ��������� ��������
    private void SetMusicVolume()
    {
        float volume = musicVolumeSlider.value;
        PlayerPrefs.SetFloat("MusicVolume", volume);
        PlayerPrefs.Save();
        audioVolumeControl.ApplyMusicVolume(volume); // ��������� ���������� ���������
    }

    // ������������� ��������� ���� � ��������� ��������
    private void SetGameVolume()
    {
        float volume = gameVolumeSlider.value;
        PlayerPrefs.SetFloat("GameVolume", volume);
        PlayerPrefs.Save();
        audioVolumeControl.ApplyGameVolume(volume); // ��������� ���������� ���������
    }

    // ������������� ��������� ������ ������ � ��������� ��������
    private void SetOtherVolume()
    {
        float volume = otherVolumeSlider.value;
        PlayerPrefs.SetFloat("OtherVolume", volume);
        PlayerPrefs.Save();
        audioVolumeControl.ApplyOtherVolume(volume); // ��������� ���������� ���������
    }
}
