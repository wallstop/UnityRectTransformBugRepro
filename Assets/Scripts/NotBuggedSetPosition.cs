using UnityEngine;

namespace Assets.Scripts
{
    public class NotBuggedSetPosition : MonoBehaviour
    {
        private void Start()
        {
            SpawnChildren();
        }

        private void SpawnChildren()
        {
            GameObject child = new GameObject("Child", typeof (RectTransform));

            RectTransform childTransform = child.GetComponent<RectTransform>();

            childTransform.SetParent(transform, false);
            childTransform.sizeDelta =
                new Vector2(1, 1); // Changing sizeDelta prior to localPosition update makes localPosition stick
            Debug.Log(string.Format("NotBugged - initial position: {0}.", childTransform.localPosition));
            childTransform.localPosition = new Vector3(1000, 100, 4);
            childTransform.sizeDelta = new Vector2(1, 1); // localPosition should be the same.
            Debug.Log(string.Format("NotBugged - final position: {0}.", childTransform.localPosition));
        }
    }
}