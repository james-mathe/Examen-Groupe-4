using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSingleConnexion
{
    internal interface Iconnexion
    {
        IDbConnection Initialise(Connexion connexion, Connexiontype connectionType);
    }
}
