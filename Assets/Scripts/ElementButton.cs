using UnityEngine;
using UnityEngine.EventSystems;

public class ElementButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Vector3 popUpScale = new Vector3(1.2f, 1.2f, 1.2f); // Scale when hovering
    private Vector3 originalScale; // The original scale of the button
    private bool isHovering = false; // Flag to check if the mouse is over the button
    public float smoothTime = 0.1f; // Speed of transition

    private Vector3 currentVelocity = Vector3.zero; // Needed for smooth movement

    void Start()
    {
        originalScale = transform.localScale; // Store the original scale
    }

    void Update()
    {
        // Smoothly change the scale based on whether we're hovering or not
        if (isHovering)
        {
            // Smoothly transition to the popUpScale when hovering
            transform.localScale = Vector3.SmoothDamp(transform.localScale, popUpScale, ref currentVelocity, smoothTime);
        }
        else
        {
            // Smoothly transition back to the original scale when not hovering
            transform.localScale = Vector3.SmoothDamp(transform.localScale, originalScale, ref currentVelocity, smoothTime);
        }
    }

    // This method is called when the pointer enters the button
    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovering = true; // Set hovering to true
    }

    // This method is called when the pointer exits the button
    public void OnPointerExit(PointerEventData eventData)
    {
        isHovering = false; // Set hovering to false
    }
}
