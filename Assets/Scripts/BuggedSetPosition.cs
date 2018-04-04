using UnityEngine;

namespace Assets.Scripts
{
    public sealed class BuggedSetPosition : MonoBehaviour
    {
        private void Start()
        {
            SpawnChildren();
        }

        private void SpawnChildren()
        {
            GameObject child = new GameObject("Child", typeof (RectTransform));

            RectTransform childTransform = child.GetComponent<RectTransform>();
            Debug.Log(string.Format("Bugged - initial position: {0}.", childTransform.localPosition));
            childTransform.SetParent(transform, false);
            childTransform.localPosition = new Vector3(1000, 100, 4);
            childTransform.sizeDelta = new Vector2(1, 1); // localPosition is now (0, 0, 4)
            Debug.Log(string.Format("Bugged - final position: {0}.", childTransform.localPosition));
        }
    }
}