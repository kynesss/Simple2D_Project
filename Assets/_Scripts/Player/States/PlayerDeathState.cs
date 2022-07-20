using UnityEngine;

public class PlayerDeathState : BasePlayerState
{
    public PlayerDeathState(PlayerStateMachine playerStateMachine) : base(playerStateMachine)
    {

    }

    public override void EnterState()
    {
        Debug.Log("Death State");
    }

    public override void ExitState()
    {

    }

    public override void UpdateState()
    {
        
    }
}
