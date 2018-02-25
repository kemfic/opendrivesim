using UnityEngine;
using System.Collections;

//so that we can see changes we make without having to run the game
[ExecuteInEditMode]
public class postprocessingdepth : MonoBehaviour
{

    public Material mat;

    void Start()
    {
        GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, mat);
    }
}