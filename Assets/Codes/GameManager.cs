using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int userPoint;

    [SerializeField]
    public TextMeshProUGUI text;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        userPoint = 0;

        text.text = userPoint.ToString();
    }

    public void PointCalc()
    {
        userPoint++;
        text.text = userPoint.ToString();
    }
}
