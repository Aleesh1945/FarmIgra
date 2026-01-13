using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput; // переменная для хранения горизонтального ввода
    [SerializeField] private float speed = 10f; // скорость перемещения игрока
    [SerializeField] private float xRange = 10f; // ограничение по оси х
    [SerializeField] private GameObject projectilePrefab; // префаб еды

    // Update is called once per frame
    void Update()
    {
        // Получение горизонтального ввода
        horizontalInput = Input.GetAxis("Horizontal");

        // Перемещение игрока по горизонтали
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Ограничение игрока в пределах экрана
        // Слева
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Справа
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Стрельба едой по пробелу
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Создание экземпляра префаба еды на позиции игрока
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}