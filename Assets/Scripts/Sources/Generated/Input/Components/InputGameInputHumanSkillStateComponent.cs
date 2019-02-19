//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity gameInputHumanSkillStateEntity { get { return GetGroup(InputMatcher.GameInputHumanSkillState).GetSingleEntity(); } }
    public Game.InputHumanSkillState gameInputHumanSkillState { get { return gameInputHumanSkillStateEntity.gameInputHumanSkillState; } }
    public bool hasGameInputHumanSkillState { get { return gameInputHumanSkillStateEntity != null; } }

    public InputEntity SetGameInputHumanSkillState(bool newIsEnd, int newSkillCode) {
        if (hasGameInputHumanSkillState) {
            throw new Entitas.EntitasException("Could not set GameInputHumanSkillState!\n" + this + " already has an entity with Game.InputHumanSkillState!",
                "You should check if the context already has a gameInputHumanSkillStateEntity before setting it or use context.ReplaceGameInputHumanSkillState().");
        }
        var entity = CreateEntity();
        entity.AddGameInputHumanSkillState(newIsEnd, newSkillCode);
        return entity;
    }

    public void ReplaceGameInputHumanSkillState(bool newIsEnd, int newSkillCode) {
        var entity = gameInputHumanSkillStateEntity;
        if (entity == null) {
            entity = SetGameInputHumanSkillState(newIsEnd, newSkillCode);
        } else {
            entity.ReplaceGameInputHumanSkillState(newIsEnd, newSkillCode);
        }
    }

    public void RemoveGameInputHumanSkillState() {
        gameInputHumanSkillStateEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public Game.InputHumanSkillState gameInputHumanSkillState { get { return (Game.InputHumanSkillState)GetComponent(InputComponentsLookup.GameInputHumanSkillState); } }
    public bool hasGameInputHumanSkillState { get { return HasComponent(InputComponentsLookup.GameInputHumanSkillState); } }

    public void AddGameInputHumanSkillState(bool newIsEnd, int newSkillCode) {
        var index = InputComponentsLookup.GameInputHumanSkillState;
        var component = (Game.InputHumanSkillState)CreateComponent(index, typeof(Game.InputHumanSkillState));
        component.IsEnd = newIsEnd;
        component.SkillCode = newSkillCode;
        AddComponent(index, component);
    }

    public void ReplaceGameInputHumanSkillState(bool newIsEnd, int newSkillCode) {
        var index = InputComponentsLookup.GameInputHumanSkillState;
        var component = (Game.InputHumanSkillState)CreateComponent(index, typeof(Game.InputHumanSkillState));
        component.IsEnd = newIsEnd;
        component.SkillCode = newSkillCode;
        ReplaceComponent(index, component);
    }

    public void RemoveGameInputHumanSkillState() {
        RemoveComponent(InputComponentsLookup.GameInputHumanSkillState);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherGameInputHumanSkillState;

    public static Entitas.IMatcher<InputEntity> GameInputHumanSkillState {
        get {
            if (_matcherGameInputHumanSkillState == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.GameInputHumanSkillState);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherGameInputHumanSkillState = matcher;
            }

            return _matcherGameInputHumanSkillState;
        }
    }
}