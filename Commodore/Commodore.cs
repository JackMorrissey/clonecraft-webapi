using System.Collections.Generic;
using CloneCraft.Interfaces;
using Ninject;

namespace CloneCraft.Commodore
{
    public class Commodore : ICommodore
    {
        private readonly Dictionary<string, ICommander> _commanders;
        private readonly IKernel _kernel;
        public Commodore(IKernel kernel)
        {
            _commanders = new Dictionary<string, ICommander>();
            _kernel = kernel;
        }
        public ICommander GetCommander(string gameId)
        {
            if (_commanders.ContainsKey(gameId))
            {
                return _commanders[gameId];
            }
            var commander = _kernel.Get<ICommander>();
            _commanders.Add(gameId, commander);
            return commander;
        }
    }
}
