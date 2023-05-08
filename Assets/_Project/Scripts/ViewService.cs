using UnityEngine;

public class ViewService : MonoBehaviour
{
    public static ViewService instance;
    public Sprite[] sprites;



    void Awake()
    {
        instance = this;
    }
    public Sprite GetSprite(int health)
    {
        return sprites[health - 1];
    }
}
