//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public ZoomComponent zoom { get { return (ZoomComponent)GetComponent(ComponentIds.Zoom); } }

        public bool hasZoom { get { return HasComponent(ComponentIds.Zoom); } }

        public Entity AddZoom(float newValue) {
            var component = CreateComponent<ZoomComponent>(ComponentIds.Zoom);
            component.value = newValue;
            return AddComponent(ComponentIds.Zoom, component);
        }

        public Entity ReplaceZoom(float newValue) {
            var component = CreateComponent<ZoomComponent>(ComponentIds.Zoom);
            component.value = newValue;
            ReplaceComponent(ComponentIds.Zoom, component);
            return this;
        }

        public Entity RemoveZoom() {
            return RemoveComponent(ComponentIds.Zoom);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherZoom;

        public static IMatcher Zoom {
            get {
                if (_matcherZoom == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Zoom);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherZoom = matcher;
                }

                return _matcherZoom;
            }
        }
    }
}