using UnityEngine;
using UnityEngine.Video;

public class VideoEventManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject endUI; // Kéo bảng UI thông báo vào đây

    void Start()
    {
        // 1. Đăng ký sự kiện (Lắng nghe)
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;

        // Bắt đầu chuẩn bị video
        videoPlayer.Prepare();
        Debug.Log("Đang chuẩn bị video...");
    }

    // Hàm chạy khi video đã nạp xong
    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video đã sẵn sàng! Bắt đầu phát.");
        vp.Play();
    }

    // Hàm chạy khi video phát hết
    void OnVideoFinished(VideoPlayer vp)
    {
        Debug.Log("Video đã kết thúc!");

        // Lựa chọn 1: Hiện UI
        if (endUI != null) endUI.SetActive(true);

        // Lựa chọn 2: Chuyển sang Scene tiếp theo (Bỏ comment dòng dưới để dùng)
        // SceneManager.LoadScene("NextLevelScene");
    }
}
