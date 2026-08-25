using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text notiText;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private Player player;

    public static UIManager instance;

    void Awake()
    {
        instance = this;
    }

    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }

    public void RestartGame()
    {
        player.transform.position = new Vector3(0, 90, -85);
        player.HP = 100;
        player.Point = 0; // รีเซ็ตคะแนนผู้เล่นใหม่เมื่อเริ่มเกม
        ShowNotiText("Start!");
        Time.timeScale = 1f;
        ShowHideRestartButton(false);
    }

    public void ShowHideRestartButton(bool flag)
    {
        restartButton.SetActive(flag);
    }
}