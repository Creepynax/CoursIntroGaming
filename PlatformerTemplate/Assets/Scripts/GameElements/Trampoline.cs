using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // La force du rebond
    public float jumpForce = 10f;

    // Le calque des objets avec lesquels le joueur peut interagir
    public LayerMask playerLayer;

    // La fonction qui se déclenche lorsque le joueur entre en contact avec le trampoline
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Trouver le point de contact entre le joueur et le trampoline
            ContactPoint2D contact = collision.contacts[0];
            Vector2 contactPoint = contact.point;

            // Calculer la direction opposée à partir du point de contact
            Vector2 oppositeDirection = -contact.normal;

            // Propulser le joueur dans la direction opposée
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                if (Mathf.Abs(oppositeDirection.x) > Mathf.Abs(oppositeDirection.y))
                {
                    // Si le joueur a touché le côté droit, propulser vers la droite
                    if (oppositeDirection.x > 0)
                    {
                        rb.AddForce(Vector2.right * jumpForce, ForceMode2D.Impulse);
                    }
                    // Sinon, propulser vers la gauche
                    else
                    {
                        rb.AddForce(Vector2.left * jumpForce, ForceMode2D.Impulse);
                    }
                }
                else
                {
                    // Si le joueur a touché le haut, propulser vers le haut
                    if (oppositeDirection.y > 0)
                    {
                        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                    }
                    // Sinon, propulser vers le bas
                    else
                    {
                        rb.AddForce(Vector2.down * jumpForce, ForceMode2D.Impulse);
                    }
                }
            }
        }
    }
}
