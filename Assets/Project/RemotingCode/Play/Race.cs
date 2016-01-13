using Regulus.Framework;
using Regulus.Utility;

namespace Regulus.Project.ItIsNotAGame1.Game.Play
{
    internal class Race :Regulus.Utility.IUpdatable
    {
        private readonly Zone _Zone;

        private readonly Aboriginal _Aboriginal;

        private readonly Regulus.Utility.Updater _Updater;
        public Race(Zone zone)
        {
            this._Zone = zone;
            _Updater = new Updater();
            _Aboriginal = new Aboriginal(_Zone);
            
        }

        void IBootable.Launch()
        {
            _Updater.Add(_Aboriginal);
        }

        void IBootable.Shutdown()
        {
            _Updater.Shutdown();
        }

        bool IUpdatable.Update()
        {
            _Updater.Working();
            return true;
        }
    }
}