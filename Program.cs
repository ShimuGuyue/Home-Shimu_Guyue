var builder = WebApplication.CreateBuilder(args);

// 添加控制器和视图服务到容器中
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 配置HTTP请求管道
if (!app.Environment.IsDevelopment())
{
    // 在非开发环境中使用异常处理程序
    app.UseExceptionHandler("/Home/Error");
    // 使用HTTP严格传输安全协议（HSTS），默认值为30天
    app.UseHsts();
}

// 强制使用HTTPS重定向
app.UseHttpsRedirection();
// 配置路由
app.UseRouting();

// 启用授权中间件
app.UseAuthorization();

// 映射静态资源
app.MapStaticAssets();

// 配置默认的控制器路由
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

// 运行应用程序
app.Run();
