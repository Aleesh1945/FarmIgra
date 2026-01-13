using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    [SerializeField] private UIManager uiManager;
    [SerializeField] TextMeshProUGUI healthText;    
    
    void Start()
    {
        healthText.text = "" + health;
    }


    public void DecreaseHealth()
    {
       health--;
       healthText.text = "" + health;
       if (health <= 0)
         {
              uiManager.GameOver();
        }
    }
}
