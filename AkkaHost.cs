using Akka.Actor;

namespace Akka.NET_Windows_Service
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
