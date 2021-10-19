using System;
using UnityEngine;
using Random = System.Random;

public class CloudGenerator : MonoBehaviour
{
    [SerializeField] private Vector2 cloudsBox = Vector2.one;
    [SerializeField] private int cloudsCount = 1;
    [SerializeField] private Sprite[] sprites;
    
    private void Start()
    {
        var rn = new Random();
        for (var i = 0; i < cloudsCount; i++)
        {
            var cloud = new GameObject("Cloud", typeof(SpriteRenderer), typeof(WindCycle));
            cloud.GetComponent<SpriteRenderer>().sprite = sprites[rn.Next(sprites.Length)];
            cloud.GetComponent<SpriteRenderer>().sortingOrder = -10;
            cloud.GetComponent<WindCycle>().bounding = cloudsBox.x;
            cloud.GetComponent<WindCycle>().speed = 0.5f + (float) rn.NextDouble() * 0.1f;
            cloud.transform.position = UnityEngine.Random.insideUnitCircle * cloudsBox;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireCube(transform.position, cloudsBox * 2);
    }
}
