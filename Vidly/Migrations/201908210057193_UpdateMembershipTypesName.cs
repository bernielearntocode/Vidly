namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypesName : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name = 'Pay As You Go' where ID = 1");
            Sql("Update MembershipTypes Set Name = 'Monthly' where ID = 2");
            Sql("Update MembershipTypes Set Name = 'Quarterly' where ID = 3");
            Sql("Update MembershipTypes Set Name = 'Yearly' where ID = 4");
        }

        public override void Down()
        {
        }
    }
}
