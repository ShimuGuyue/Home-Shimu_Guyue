namespace Home_Shimu_Guyue.Models; // 定义命名空间，组织代码结构，通常与项目名称一致。

public class ErrorViewModel // 定义一个名为 ErrorViewModel 的公共类，用于表示错误信息的模型。
{
    public string? RequestId { get; set; } 
    // RequestId 属性是一个可空字符串，用于存储请求的唯一标识符。
    // 可用于跟踪特定请求的错误信息。

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId); 
    // ShowRequestId 是一个只读属性，返回一个布尔值。
    // 如果 RequestId 不为空或不为 null，则返回 true，表示可以显示 RequestId。
    // 通常用于在错误页面上决定是否显示请求 ID。
}
