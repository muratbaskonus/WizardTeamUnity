using UnityEngine.UI;
using UnityEngine;

public class LıvesUI : MonoBehaviour
{
    public Text livesText;


    // Update is called once per frame
    void Update()
    {
        livesText.text = PlayerStats.lives.ToString() + " LIVES";
    }
}
