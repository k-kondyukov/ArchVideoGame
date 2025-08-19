using Unity.Entities;
using Unity.Transforms;
using Unity.Burst;

public partial struct BallSystem : ISystem
{
    // public void OnCreate(ref SystemState state)
    // {
    //     state.RequireForUpdate<BallComponent>();
    // }

    public void OnUpdate(ref SystemState state)
    {
        new BallJob
        {
            DeltaTime = SystemAPI.Time.DeltaTime
        }.ScheduleParallel();
    }

    [BurstCompile]
    public partial struct BallJob : IJobEntity
    {
        public float DeltaTime;
        public void Execute(ref BallComponent ball, ref LocalTransform transform)
        {
            transform = transform.Translate(ball.Dicrection * (ball.Speed * DeltaTime));
        }
    }
}
