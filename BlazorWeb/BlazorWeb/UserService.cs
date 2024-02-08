namespace BlazorWeb
{
    public class UserService
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int CreatedBy { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<UserService>();
            services.AddScoped<UserService>();
        }
    }
}
