using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWandering : MonoBehaviour
{
    [SerializeField] float moveDistance = 2f; 
    [SerializeField] float moveSpeed = 1f;   
    [SerializeField] float waitTime = 3f;    

    private Rigidbody2D rb;
    private Vector2 startPosition;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = rb.position;
    }

    private void Start()
    {
        StartCoroutine(MoveBackAndForth());
    }

    private IEnumerator MoveBackAndForth()
    {
        Vector2 targetPosition = startPosition + Vector2.up * moveDistance;
        Vector2 originalPosition = startPosition;

        while (true)
        {

            while (Vector2.Distance(rb.position, targetPosition) > 0.01f)
            {
                rb.position = Vector2.MoveTowards(rb.position, targetPosition, moveSpeed * Time.deltaTime);
                yield return null;
            }
        
            yield return new WaitForSeconds(waitTime);

            while (Vector2.Distance(rb.position, originalPosition) > 0.01f)
            {
                rb.position = Vector2.MoveTowards(rb.position, originalPosition, moveSpeed * Time.deltaTime);
                yield return null;
            }

            yield return new WaitForSeconds(waitTime);

            Vector2 temp = targetPosition;
            targetPosition = originalPosition;
            originalPosition = temp;
        }
    }
}

