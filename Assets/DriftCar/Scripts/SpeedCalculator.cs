using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpeedCalculator : MonoBehaviour
{

    public float Speed;
    public float maxSpeed = 200f;
    public Rigidbody rb;

    public Text SpeedText;
    public Text GearText;
    public Text RPMText;


    void FixedUpdate()
    {
        Vector3 vel = rb.velocity;

        // Вычисление скорости в км/ч
        float Speed = rb.velocity.magnitude * 3.6f;

        // Проверяем, не превышает ли скорость максимальное значение
        if (Speed > maxSpeed)
        {
            // Если скорость превышает максимальное значение, ограничиваем ее
            rb.velocity = rb.velocity.normalized * (maxSpeed / 3.6f);
            Speed = maxSpeed; // Обновляем значение скорости
        }

        SpeedText.text = Speed.ToString("0");
    }


}
