using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreGithub
{
    public static class Github
    {
        public static async Task<string> GetVersion()
        {
            var client = new GitHubClient(new ProductHeaderValue("Trade-Alert-Responder"));
            var releases = client.Repository.Release.GetAll("BigBitsIO", "Trade-Alert-Responder").GetAwaiter().GetResult();
            return releases[0].TagName;
        }
    }
}
