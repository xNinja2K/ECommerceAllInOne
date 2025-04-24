using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceAllInOne.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        _logger.LogInformation($"Trang Index có người đăng nhập vào lúc {DateTime.Now}");
        _logger.LogError($"Lỗi xảy ra vào lúc {DateTime.Now}");
        _logger.LogWarning("Người dùng chưa đăng ký nhưng đăng nhập được!");
        _logger.LogCritical("Server Die");
    }
}
