using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public Sprite newBackground;
    public GameObject backgroundObject;

    private SpriteRenderer backgroundSpriteRenderer;

    private void Start()
    {
        backgroundSpriteRenderer = backgroundObject.GetComponent<SpriteRenderer>();
    }

    public void ChangeBackground()
    {
        if (backgroundSpriteRenderer != null && newBackground != null)
        {
            backgroundSpriteRenderer.sprite = newBackground;
        }
    }
}
