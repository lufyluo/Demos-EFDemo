// <auto-generated />
namespace Demo.Migration.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.2.0-61023")]
    public sealed partial class EFDemo : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(EFDemo));
        
        string IMigrationMetadata.Id
        {
            get { return "201711240817331_EFDemo"; }
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
