﻿namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfieldavatar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "avatar", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "avatar");
        }
    }
}
