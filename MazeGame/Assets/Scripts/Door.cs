using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 openRotation;
    public float time;
    public GameObject door;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onSelect()
    {
        Debug.Log("YO");
        OpenGate();
    }

    public void OpenGate()
    {
        StopAllCoroutines();
        StartCoroutine(DoorMove(transform.eulerAngles, openRotation, 1 / time));
    }

    public IEnumerator DoorMove(Vector3 startPos, Vector3 endPos, float step)
    {
        for (float i = 0; i <= 1f; i += step)
        {
            Vector3 end = new Vector3(0, endPos.y / 180 * Mathf.PI, 0);
            Vector3 newPos = Vector3.Lerp(startPos, end, i);
            door.transform.Rotate(newPos);
            yield return null;
        }
    }

}
