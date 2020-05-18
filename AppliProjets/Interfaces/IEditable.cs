using System;
using System.Collections.Generic;
using System.Text;

namespace AppliProjets
{
    public interface IEditable
    {
        void Ajouter(Object obj);

        void Supprimer(Object obj);

        void Modifier(Object obj);
    }
}