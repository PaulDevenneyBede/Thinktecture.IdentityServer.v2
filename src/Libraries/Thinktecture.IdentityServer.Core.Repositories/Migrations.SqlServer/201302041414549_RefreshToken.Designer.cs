// <auto-generated />
namespace Thinktecture.IdentityServer.Core.Repositories.Migrations.SqlServer
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    public sealed partial class RefreshToken : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(RefreshToken));
        
        string IMigrationMetadata.Id
        {
            get { return "201302041414549_RefreshToken"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
