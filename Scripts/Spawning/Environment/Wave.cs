using UnityEngine;

/** WAVE TEXTURE EFFECT SCRIPT
 * Modified from: https://www.patrykgalach.com/2019/08/01/waves-on-plane/
 **/

public class Wave : MonoBehaviour
{
    // Variables
    private MeshRenderer meshRenderer;
    private readonly float wavesDirection = 0.5f;
    private readonly float textureSpeed = 0.5f;

    // Properties
    public float WavesDirection => wavesDirection;
    public float TextureSpeed => textureSpeed;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        float xSpeed = Mathf.Sin(wavesDirection * Mathf.Deg2Rad);
        float zSpeed = Mathf.Cos(wavesDirection * Mathf.Deg2Rad);

        AddScrollEffectToTexture(xSpeed, zSpeed);
    }

    private Vector2 AddScrollEffectToTexture(float x, float z)
    {
        return meshRenderer.material.mainTextureOffset += textureSpeed * Time.deltaTime * new Vector2(x, z);
    }
}