using UnityEngine;
using System.Collections.Generic;

class GameManager : Singleton<GameManager> {

    Dictionary<string, IGameState> states = new Dictionary<string, IGameState>();
    string lastTarget;

    private IGameState _getTarget(string target) =>
        states.ContainsKey(target) ? states[target] : null;

    public void AddTarget(string target, IGameState obj) {
        states[target] = obj;
    }

    public void EnterState(string target) {
        if (lastTarget != "" && lastTarget != target) {
            ExitState(lastTarget);
        }
        lastTarget = target;
        _getTarget(target)?.EnterState();
    }

    public void ExitState(string target = null) {
        _getTarget(target)?.ExitState();
        lastTarget = "";
    }

    public void UpdateState(string target) {
        _getTarget(target)?.UpdateState();
    }

}
