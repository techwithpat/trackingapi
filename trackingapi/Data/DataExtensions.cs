namespace trackingapi.Data
{
    public static class DatabaseExtensions
    {
        public static void EnsureDatabaseCreated(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<IssueDbContext>();

            context.Database.EnsureCreated();
        }
    }
}
