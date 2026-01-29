using UnityEngine;
using UnityEngine.UI;

public class SpatialAudioDemo : MonoBehaviour
{
    public float maxDistance = 10f;
    public AudioSource audioSource;
    public Text statusText; // Hiển thị trạng thái lên màn hình

    void Update()
    {
        // Nhấn 1 để chuyển sang 2D
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            audioSource.spatialBlend = 0f;
            if (statusText) statusText.text = "Mode: 2D Audio";
        }
        // Nhấn 2 để chuyển sang 3D
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            audioSource.spatialBlend = 1f;
            if (statusText) statusText.text = "Mode: 3D Audio (Spatial)";
        }
    }
    void OnDrawGizmos()
    {
        // Vẽ vòng tròn màu vàng biểu thị tầm xa tối đa của âm thanh
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, maxDistance);
    }
}
