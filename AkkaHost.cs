using Akka.Actor;

namespace AkkaHost
{
    public class AkkaHost
    {
        private ActorSystem _actorSystem;

        public void Start()
        {
            _actorSystem = ActorSystem.Create("AkkaHost");
        }

        public async void Stop()
        {
            await _actorSystem.Terminate();
        }

    }
}
