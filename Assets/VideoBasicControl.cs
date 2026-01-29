using UnityEngine;
using UnityEngine.Video;

public class VideoBasicControl : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Lấy component VideoPlayer gắn trên cùng Object
        videoPlayer = GetComponent<VideoPlayer>();

        // Tắt tự động chạy khi vào game
        videoPlayer.playOnAwake = false;
    }

    void Update()
    {
        // Nhấn V để Play video
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (!videoPlayer.isPlaying)
            {
                videoPlayer.Play();
                Debug.Log("Video đang chạy!");
            }
        }
    }
}
