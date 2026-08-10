namespace DOTNET_hocmienphi.service.Utils.Mail;

public static class MailTemplates
{
    public static string GetHelloMailTemplate(string fullName)
    {
        string template = $"""
<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
</head>
<body style="margin:0;padding:0;background:#f4f6f9;font-family:Arial,Helvetica,sans-serif;">

<table width="100%" cellpadding="0" cellspacing="0" style="padding:40px 0;background:#f4f6f9;">
<tr>
<td align="center">

<table width="600" cellpadding="0" cellspacing="0"
       style="background:#ffffff;border-radius:12px;overflow:hidden;">

    <tr>
        <td align="center"
            style="background:#2563eb;padding:40px 20px;">

            <h1 style="margin:0;color:#ffffff;font-size:30px;">
                Chào mừng bạn!
            </h1>

            <p style="margin-top:12px;color:#dbeafe;font-size:16px;">
                Cảm ơn bạn đã đăng ký tài khoản.
            </p>

        </td>
    </tr>

    <tr>
        <td style="padding:40px;">

            <p style="font-size:16px;margin-top:0;">
                Xin chào <strong>{fullName}</strong>,
            </p>

            <p style="font-size:15px;line-height:1.8;color:#555;">
                Chúng tôi rất vui khi bạn đã trở thành thành viên của hệ thống.
                Tài khoản của bạn đã được tạo thành công và hiện đã sẵn sàng sử dụng.
            </p>

            <p style="font-size:15px;line-height:1.8;color:#555;">
                Bạn có thể đăng nhập để trải nghiệm các tính năng và bắt đầu sử dụng dịch vụ ngay hôm nay.
            </p>

            <div style="text-align:center;margin:40px 0;">

                <a href="https://your-domain.com/login"
                   style="
                        background:#2563eb;
                        color:white;
                        text-decoration:none;
                        padding:14px 32px;
                        border-radius:8px;
                        display:inline-block;
                        font-weight:bold;">
                    Đăng nhập
                </a>

            </div>

            <p style="font-size:15px;color:#555;">
                Nếu bạn cần hỗ trợ, hãy liên hệ với đội ngũ của chúng tôi bất kỳ lúc nào.
            </p>

            <p style="margin-top:30px;">
                Trân trọng,<br>
                <strong>TaskCoper Team</strong>
            </p>

        </td>
    </tr>

    <tr>
        <td align="center"
            style="padding:24px;background:#f8f9fb;color:#888;font-size:13px;">

            © 2026 TaskCoper. All rights reserved.

        </td>
    </tr>

</table>

</td>
</tr>
</table>

</body>
</html>
""";
        return template;
    }
}