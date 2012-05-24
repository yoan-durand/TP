using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace lemett_aBugTrack
{
    // NOTE: If you change the interface name "IServiceClientBugTrack" here, you must also update the reference to "IServiceClientBugTrack" in Web.config.
    [ServiceContract]
    public interface IServiceClientBugTrack
    {
        /// <summary>
        /// permet d'obtenir la liste des bugs en utilisant
        /// un objet WCF
        /// </summary>
        /// <param name="max">nombre max de resultat que l'on veut recuperer</param>
        /// <returns>la liste des bugs</returns>
        [OperationContract]
         List<DBO.BugTransfert> GetListBug(int max);
        /// <summary>
        /// permet d'obtenir la liste des bugs en 
        /// utilisant des objets entities
        /// </summary>
        /// <param name="max">nombre max de resultat que l'on veut recuperer</param>
        /// <returns>la liste des bugs</returns>
        [OperationContract]
         List<DataAccess.T_Bug> GetListBugWithEF(int max);
    }
}
