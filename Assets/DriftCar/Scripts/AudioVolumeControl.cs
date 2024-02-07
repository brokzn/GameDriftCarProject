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

    // �������� ��������� �� PlayerPrefs
    private void LoadVolume()
    {
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            float volume = PlayerPrefs.GetFloat("MusicVolume");
            ApplyMusicVolume(volume); // ��������� ����������� ��������� ��� ������
        }

        if (PlayerPrefs.HasKey("GameVolume"))
        {
            float volume = PlayerPrefs.GetFloat("GameVolume");
            ApplyGameVolume(volume); // ��������� ����������� ��������� ��� ������ ����
        }

        if (PlayerPrefs.HasKey("OtherVolume"))
        {
            float volume = PlayerPrefs.GetFloat("OtherVolume");
            ApplyOtherVolume(volume); // ��������� ����������� ��������� ��� ������ ������
        }
    }

    // ��������� ��������� � ������
    public void ApplyMusicVolume(float volume)
    {
        if (musicAudioSource != null)
        {
            musicAudioSource.volume = volume;
        }
    }

    // ��������� ��������� � ������ ����
    public void ApplyGameVolume(float volume)
    {
        if (gameAudioSource != null)
        {
            gameAudioSource.volume = volume;
        }
    }

    // ��������� ��������� � ������ ������
    public void ApplyOtherVolume(float volume)
    {
        if (otherAudioSource != null)
        {
            otherAudioSource.volume = volume;
        }
    }
}
