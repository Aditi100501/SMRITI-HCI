using UnityEngine;

public class ScrollTexture : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed;
        // Scrolls the texture along the Y axis. Change to (offset, 0) if it moves sideways.
        rend.material.mainTextureOffset = new Vector2(0, -offset);
    }
}