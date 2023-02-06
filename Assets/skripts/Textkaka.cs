using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class Textkaka : MonoBehaviour
{
    private static int money;
    private static int rate = 1;

    public Text moneyText;

    [Header("Настройки появления текста")]
    [SerializeField] float FadeSec = 1f; // время появления/исчезания (пол секунды)
    [SerializeField] float ShowSec = 5f; // время показа (одна секунда)

    public void Click()
    {
        money += rate;
        UpdateMoneyUI();
    }

    public void UpgradeClick()
    {
        if (money >= 15)
        {
            money -= 15;
            rate += 1;
            UpdateMoneyUI();
        }
        else
        {
            // ЗДЕСЬ ДОЛЖЕН  ПОЯВЛЯТЬСЯ И ИСЧЕЗАТЬ ТЕКСТ
            BlinkMessage();//Сегодня 31 октября); // <-------------------------
        }

    }
    public void UpdateMoneyUI()
    {
        moneyText.text = "$" + money;
    }

    private void BlinkMessage()
    {
        StopAllCoroutines();
        StartCoroutine(BlinkCoroutine());
    }

    private IEnumerator BlinkCoroutine()
    {
        yield return FadeTextAlpha(0f, 1f);
        yield return new WaitForSeconds(ShowSec);
        yield return FadeTextAlpha(1f, 0f);

    }

    private IEnumerator FadeTextAlpha(float from, float to)
    {
        Color textColor = moneyText.color;
        textColor.a = from;

        float time = 0;

        while (time < FadeSec)
        {
            time += Time.deltaTime;
            textColor.a = Mathf.Lerp(from, to, 1f / FadeSec * time);
            moneyText.color = textColor;

            yield return null;
        }
    }
}