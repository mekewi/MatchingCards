using EventsSystem.Scripts.Editor;
using ProjectArchitectureBase.Event;
using UnityEditor;
namespace ProjectArchitectureBase.Editor
{
#if UNITY_EDITOR
    [CustomEditor(typeof(RequestOpenViewDataEvent))]
    public class RequestOpenViewDataEventEditor : EventEditorBase<RequestOpenViewData,RequestOpenViewDataEvent>
    {
    }
#endif
}
