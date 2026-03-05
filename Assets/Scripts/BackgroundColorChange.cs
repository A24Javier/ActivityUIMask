using UnityEngine;

public class BackgroundColorChange : MonoBehaviour
{
    public float Speed = 1;

    void Update()
    {
        Camera.main.backgroundColor = Color.HSVToRGB(Mathf.PingPong((Time.time * Speed) * 0.1f, 1), 1, 1);
    }
}
