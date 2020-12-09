!!! builder.Entity<Hotel>()
            .HasOne(b => b.CheckList)
            .WithOne(i => i.Hotel)
            .HasForeignKey<CheckList>(b => b.Id);   !!!!


 var foreignKeys = entityTypes
                .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.SetNull !!!!!;
            }