using UnityEngine;

/* FOG SETTINGS SCRIPT
 * Modified from @ https://medium.com/@mukulkhanna/creating-basic-underwater-effects-in-unity-9a9400bde928
 */
public class Fog : MonoBehaviour
{
    // Variables 
    private Color underwaterColour;
    private void Start()
    {
        underwaterColour = new Color(0.22f, 0.65f, 0.77f, 0.5f);
    }

    private void Update()
    {
        SetFog();
    }


    private void SetFog()
    {
        RenderSettings.fog = true;
        RenderSettings.fogColor = underwaterColour;
        RenderSettings.fogStartDistance = 0.0f;
        RenderSettings.fogDensity = 0.06f;
    }
}
