using UnityEngine;

public class ConveyorBeltScroll : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        // Calculate movement over time
        float offset = Time.time * scrollSpeed;

        // URP Lit shaders use "_BaseMap" for the main texture
        rend.material.SetTextureOffset("_BaseMap", new Vector2(0, -offset));
    }
}