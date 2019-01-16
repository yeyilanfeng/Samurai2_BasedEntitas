//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity gameEntitasInputServiceEntity { get { return GetGroup(GameMatcher.GameEntitasInputService).GetSingleEntity(); } }
    public Game.EntitasInputServiceComponent gameEntitasInputService { get { return gameEntitasInputServiceEntity.gameEntitasInputService; } }
    public bool hasGameEntitasInputService { get { return gameEntitasInputServiceEntity != null; } }

    public GameEntity SetGameEntitasInputService(Game.IInputService newEntitasInputService) {
        if (hasGameEntitasInputService) {
            throw new Entitas.EntitasException("Could not set GameEntitasInputService!\n" + this + " already has an entity with Game.EntitasInputServiceComponent!",
                "You should check if the context already has a gameEntitasInputServiceEntity before setting it or use context.ReplaceGameEntitasInputService().");
        }
        var entity = CreateEntity();
        entity.AddGameEntitasInputService(newEntitasInputService);
        return entity;
    }

    public void ReplaceGameEntitasInputService(Game.IInputService newEntitasInputService) {
        var entity = gameEntitasInputServiceEntity;
        if (entity == null) {
            entity = SetGameEntitasInputService(newEntitasInputService);
        } else {
            entity.ReplaceGameEntitasInputService(newEntitasInputService);
        }
    }

    public void RemoveGameEntitasInputService() {
        gameEntitasInputServiceEntity.Destroy();
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
public partial class GameEntity {

    public Game.EntitasInputServiceComponent gameEntitasInputService { get { return (Game.EntitasInputServiceComponent)GetComponent(GameComponentsLookup.GameEntitasInputService); } }
    public bool hasGameEntitasInputService { get { return HasComponent(GameComponentsLookup.GameEntitasInputService); } }

    public void AddGameEntitasInputService(Game.IInputService newEntitasInputService) {
        var index = GameComponentsLookup.GameEntitasInputService;
        var component = (Game.EntitasInputServiceComponent)CreateComponent(index, typeof(Game.EntitasInputServiceComponent));
        component.EntitasInputService = newEntitasInputService;
        AddComponent(index, component);
    }

    public void ReplaceGameEntitasInputService(Game.IInputService newEntitasInputService) {
        var index = GameComponentsLookup.GameEntitasInputService;
        var component = (Game.EntitasInputServiceComponent)CreateComponent(index, typeof(Game.EntitasInputServiceComponent));
        component.EntitasInputService = newEntitasInputService;
        ReplaceComponent(index, component);
    }

    public void RemoveGameEntitasInputService() {
        RemoveComponent(GameComponentsLookup.GameEntitasInputService);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherGameEntitasInputService;

    public static Entitas.IMatcher<GameEntity> GameEntitasInputService {
        get {
            if (_matcherGameEntitasInputService == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameEntitasInputService);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameEntitasInputService = matcher;
            }

            return _matcherGameEntitasInputService;
        }
    }
}