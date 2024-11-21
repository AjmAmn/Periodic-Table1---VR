using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PauseVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;  // Reference to the VideoPlayer component
    public Button pauseButton;       // Reference to the Pause Button

    void Start()
    {
        // Add a listener to the pause button
        pauseButton.onClick.AddListener(PauseVideo);
    }

    // Method to pause the video
    void PauseVideo()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();  // Pause the video if it's playing
        }
    }
}
