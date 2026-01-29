using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    private AudioSource audioSource;
    void Start() { audioSource = GetComponent<AudioSource>(); }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) audioSource.Play();
        if (Input.GetKeyDown(KeyCode.S)) audioSource.Stop();
    }
}
