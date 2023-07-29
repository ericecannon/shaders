using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class AssignTextureFromSpriteRenderer : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Material material;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        material = spriteRenderer.material;
    }

    void Update()
    {
        if (spriteRenderer.sprite)
        {
            Texture2D texture = spriteRenderer.sprite.texture;
            if (material.mainTexture != texture)
            {
                material.mainTexture = texture;
            }
        }
    }
}