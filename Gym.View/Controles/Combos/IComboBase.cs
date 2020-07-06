using System;

namespace Gym.View
{    
    public interface IComboBase
    {
        void ObtenerObjetos();

        void Refrescar();

        void SetValor(int idEntity);
    }
}
