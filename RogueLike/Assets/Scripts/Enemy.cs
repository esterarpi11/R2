using UnityEngine;

public class Enemy : EnemyBehaviour
{    
    private Transform jugador;// Referencia al transform del jugador

    private void Awake()
    {
        vida = statVida;
    }
    void Start()
    {
        // Buscar el objeto con el tag "Player" al inicio del juego
        jugador = GameObject.Find("Player").transform;
    }

    void Update()
    {
        alreadyHit = false; // Reiniciar la variable en cada frame
        if (jugador != null && isTurret == false)
        {
            // Calcular la direcci�n hacia el jugador
            Vector3 direccion = jugador.position - transform.position;

            // Normalizar la direcci�n para que el enemigo se mueva a una velocidad constante
            direccion.Normalize();

            // Mover al enemigo en la direcci�n del jugador
            transform.Translate(direccion * velocidad * Time.deltaTime);
        }
        if (isTurret)
        {
            TurretEnemy();
        }

    }

    
}
