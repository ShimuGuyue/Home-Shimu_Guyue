using System.Diagnostics; // 引入用于诊断的命名空间，例如获取当前活动的请求 ID。
using Microsoft.AspNetCore.Mvc; // 引入 ASP.NET Core MVC 的核心功能。
using Home_Shimu_Guyue.Models; // 引入项目中的模型命名空间，用于访问 ErrorViewModel。

namespace Home_Shimu_Guyue.Controllers; // 定义命名空间，组织控制器代码，通常与项目名称一致。

public class HomeController : Controller // 定义一个继承自 Controller 的控制器类，用于处理 Web 请求。
{
    private readonly ILogger<HomeController> _logger; 
    // 定义一个只读字段 _logger，用于记录日志信息。
    // ILogger 是 ASP.NET Core 提供的日志记录接口。

    public HomeController(ILogger<HomeController> logger) 
    {
        _logger = logger; 
        // 构造函数注入 ILogger<HomeController>，用于依赖注入日志记录功能。
    }

    public IActionResult Index() 
    {
        return View(); 
        // 处理对 "Index" 页面的请求，返回一个视图。
        // 默认会寻找 Views/Home/Index.cshtml 文件。
    }

    public IActionResult Privacy() 
    {
        return View(); 
        // 处理对 "Privacy" 页面的请求，返回一个视图。
        // 默认会寻找 Views/Home/Privacy.cshtml 文件。
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // ResponseCache 特性用于配置响应缓存行为。
    // Duration = 0 表示不缓存，Location = None 表示不存储在任何位置，NoStore = true 表示不存储响应。
    public IActionResult Error() 
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }); 
        // 处理对 "Error" 页面的请求，返回一个视图。
        // 使用 ErrorViewModel 传递错误信息，其中 RequestId 用于跟踪请求。
        // 如果当前活动的请求 ID 不存在，则使用 HttpContext.TraceIdentifier。
    }
}
