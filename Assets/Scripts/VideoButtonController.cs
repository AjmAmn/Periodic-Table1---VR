using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoButtonController : MonoBehaviour
{
    public VideoPlayer videoPlayer;  // Reference to the Video Player component
    public Button playButton;        // Reference to the Button

    void Start()
    {
        // Add listener to the button to play the video when pressed
        playButton.onClick.AddListener(PlayVideo);
    }

    void PlayVideo()
    {
        videoPlayer.Play();  // Play the video
    }
}
