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
        static readonly ControlEnabledComponent controlEnabledComponent = new ControlEnabledComponent();

        public bool isControlEnabled {
            get { return HasComponent(ComponentIds.ControlEnabled); }
            set {
                if (value != isControlEnabled) {
                    if (value) {
                        AddComponent(ComponentIds.ControlEnabled, controlEnabledComponent);
                    } else {
                        RemoveComponent(ComponentIds.ControlEnabled);
                    }
                }
            }
        }

        public Entity IsControlEnabled(bool value) {
            isControlEnabled = value;
            return this;
        }
    }

    public partial class Pool {
        public Entity controlEnabledEntity { get { return GetGroup(Matcher.ControlEnabled).GetSingleEntity(); } }

        public bool isControlEnabled {
            get { return controlEnabledEntity != null; }
            set {
                var entity = controlEnabledEntity;
                if (value != (entity != null)) {
                    if (value) {
                        CreateEntity().isControlEnabled = true;
                    } else {
                        DestroyEntity(entity);
                    }
                }
            }
        }
    }

    public partial class Matcher {
        static IMatcher _matcherControlEnabled;

        public static IMatcher ControlEnabled {
            get {
                if (_matcherControlEnabled == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.ControlEnabled);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherControlEnabled = matcher;
                }

                return _matcherControlEnabled;
            }
        }
    }
}
