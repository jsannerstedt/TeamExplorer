using System.Collections.Generic;
using System.Linq;
using TeamExplorer.Models;

namespace TeamExplorer.Queries
{
    public class ActiveCharters : Query<IEnumerable<Charter>>
    {
        public override IEnumerable<Charter> Execute()
        {
            return Session.Query<Charter>()
                .Where(charter=>charter.IsActive)
                .OrderBy(charter=>charter.Title);
        }
    }
}