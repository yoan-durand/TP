using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientBugTrack.DataAccess
{
    public class BugTrack
    {

        private ServiceReferenceBugTrack.ServiceClientBugTrackClient _client;

        public ServiceReferenceBugTrack.ServiceClientBugTrackClient Client
        {
            get { return _client; }
            set { _client = value; }
        }

        public BugTrack()
        {
            _client = new ClientBugTrack.ServiceReferenceBugTrack.ServiceClientBugTrackClient();
        }


        public List<ServiceReferenceBugTrack.T_Bug> GetListBugWithEF(int max)
        {
            try
            {
                return _client.GetListBugWithEF(max).ToList();
            }
            catch (Exception ex)
            {
                return new List<ClientBugTrack.ServiceReferenceBugTrack.T_Bug>();
            }
        }

        public List<ServiceReferenceBugTrack.BugTransfert> GetListBug(int max)
        {
            try
            {
                return _client.GetListBug(max).ToList();
            }
            catch (Exception ex)
            {
                return new List<ClientBugTrack.ServiceReferenceBugTrack.BugTransfert>();
            }
        }
    }
}
