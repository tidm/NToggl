using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NToggl
{
    public class Client
    {
        private string _apiToken;
        private string _url;

        private string WorkspacesAddress
        {
            get { return _url + "v8/workspaces/"; }
        }

        public Client(string apiToken, string url = "https://www.toggl.com/api/")
        {
            _apiToken = apiToken;
            _url = url;
        }

        public IEnumerable<Workspace> GetWorkspaces()
        {
            
        }
    }
}
