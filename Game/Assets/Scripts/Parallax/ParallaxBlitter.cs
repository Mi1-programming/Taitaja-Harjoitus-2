using UnityEngine;

[System.Serializable]
public struct ParallaxBlit
{
    public Texture texture;
    public float speed;
}
public class ParallaxBlitter : MonoBehaviour
{
    [SerializeField] private ParallaxBlit[] parallaxBlits;
    [SerializeField] private Material backgroundMaterial;
    private Material[] materials; // Store modified parallax materials
    private void Start() {
        materials = new Material[parallaxBlits.Length]; // Create materials for adjusting their properties
        for (int i = 0; i < parallaxBlits.Length; i++) { // Loop parallaxes
            materials[i] = Instantiate(backgroundMaterial); // Create new instance of the backgrond material
            materials[i].SetTexture("_MainTex", parallaxBlits[i].texture); // Sets the main texture of the material
            materials[i].SetFloat("_Scroll", parallaxBlits[i].speed); // Sets the speed of the scrolling effect
        }
    }
    private void OnRenderImage(RenderTexture source, RenderTexture destination) {
        for (int i = 0; i < parallaxBlits.Length; i++) { // Loop parallax effects
            Graphics.Blit(parallaxBlits[i].texture, destination, materials[i]); // Render parallax texture onto the screen, and scroll it using the shader
        }
    }
}
