using System.Net;
using System.Net.Mail;
using Business.Sevices.Interfaces;
using DataTransfer.Concrete;

namespace Business.Sevices.Concrete;

public class EmailService : IEmailService
{
    private readonly IUserDetailService _userDetailService;
    private readonly SmtpClient _smtpClient;

    public EmailService(IUserDetailService userDetailService)
    {
        _userDetailService = userDetailService;
        _smtpClient = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            Credentials = new NetworkCredential("ekys.info@gmail.com", "kjas sryi tgmq woxq"),
            EnableSsl = true
        };
    }

    public async Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        var mailMessage = new MailMessage
        {
            From = new MailAddress("ekys.info@gmail.com"),
            Subject = subject,
            Body = htmlMessage,
            IsBodyHtml = true
        };

        mailMessage.To.Add(email);

        try
        {
            await _smtpClient.SendMailAsync(mailMessage);
        }
        catch (Exception)
        {
            throw new InvalidOperationException("Mail gönderilemedi!");
        }
    }

    public async Task SendWelcomeEmail(UserForRegisterModel user)
    {
        var mailMessage = new MailMessage
        {
            From = new MailAddress("ekys.info@gmail.com"),
            Subject = "Hoş Geldiniz",
            Body = $@"
                        <!DOCTYPE html>
                        <html lang='tr'>
                        <head>
                            <meta charset='UTF-8'>
                            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                            <title>Hoş Geldiniz</title>
                            <style>
                                body {{
                                    font-family: Arial, sans-serif;
                                    background-color: #f4f4f4;
                                    margin: 0;
                                    padding: 0;
                                }}
                                .container {{
                                    width: 100%;
                                    max-width: 600px;
                                    margin: 0 auto;
                                    background-color: #ffffff;
                                    padding: 20px;
                                    border-radius: 8px;
                                    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                                }}
                                .header {{
                                    background-color:  #4CAF50;
                                    color: white;
                                    text-align: center;
                                    padding: 10px 0;
                                    border-radius: 10px 10px 10px 10px;
                                }}
                                .content {{
                                    padding: 20px;
                                    text-align: center;
                                }}
                                .button {{
                                    display: inline-block;
                                    padding: 10px 20px;
                                    margin-top: 20px;
                                    color: white;
                                    background-color: #4CAF50;
                                    text-decoration: none;
                                    border-radius: 5px;
                                }}
                            </style>
                        </head>
                        <body>
                            <div class='container'>
                                <div class='header'>
                                    <h1>Hoş Geldiniz</h1>
                                </div>
                                <div class='content'>
                                    <p>Merhaba,</p>
                                    <p>{user.Name.ToUpper() + " " + user.Surname.ToUpper()} Platformumuza kaydolduğunuz için teşekkür ederiz.</p>
                                    <p>Kullanıcı bilgileriniz &#x1F447;</p>
                                    <p>Mail Adresiniz: {user.Email}</p>
                                    <p>Şifreniz: {user.Password}</p>
                                </div>
                            </div>
                        </body>
                        </html>
                        ",
            IsBodyHtml = true
        };

        mailMessage.To.Add(user.Email);

        try
        {
            await _smtpClient.SendMailAsync(mailMessage);
        }
        catch (Exception)
        {
            throw new InvalidOperationException("Mail gönderilemedi!");
        }
    }

    public async Task SendPasswordResetEmail(string email, string resetToken)
    {
        var resetLink = $"http://127.0.0.1:5500/reset-password.html?token={resetToken}";

        var userDetail = await _userDetailService.GetByEmailAsync<UserDetailDto>(x => x.Email == email);

        var mailMessage = new MailMessage
        {
            From = new MailAddress("ekys.info@gmail.com"),
            Subject = "Şifre Sıfırlama Talebi",
            Body = $@"
                    <!DOCTYPE html>
                    <html lang='tr'>
                    <head>
                        <meta charset='UTF-8'>
                        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                        <title>Şifre Sıfırlama</title>
                        <style>
                            body {{
                                font-family: Arial, sans-serif;
                                background-color: #f4f4f4;
                                margin: 0;
                                padding: 0;
                            }}
                            .container {{
                                width: 100%;
                                max-width: 600px;
                                margin: 0 auto;
                                background-color: #ffffff;
                                padding: 20px;
                                border-radius: 8px;
                                box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                            }}
                            .header {{
                                background-color: #4CAF50;
                                color: white;
                                text-align: center;
                                padding: 10px 0;
                                border-radius: 10px 10px 10px 10px;
                            }}
                            .content {{
                                padding: 20px;
                                text-align: center;
                            }}                            
                        </style>
                    </head>
                    <body>
                        <div class='container'>
                            <div class='header'>
                                <h1>Şifre Sıfırlama Talebi</h1>
                            </div>
                            <div class='content'>
                                <p>Merhaba {userDetail.Name.ToUpper()} {userDetail.Surname.ToUpper()},</p>
                                <p>Şifrenizi sıfırlamak için aşağıdaki bağlantıya tıklayınız:</p>
                                <a href='{resetLink}' style='display: inline-block; padding: 10px 20px; margin-top: 20px; color: white; background-color: #007bff; text-decoration: none; border-radius: 5px; font-weight: bold;'>Şifrenizi Sıfırlayın</a>
                                <p>Bu bağlantı 15 dakika geçerli olacaktır.</p>
                            </div>
                        </div>
                    </body>
                    </html>
                    ",
            IsBodyHtml = true
        };

        mailMessage.To.Add(email);

        try
        {
            await _smtpClient.SendMailAsync(mailMessage);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Mail gönderilemedi!", ex);
        }
    }
    
    
    
    public async Task SendTwoFactorCodeEmail(string email, string twoFactorCode)
    {
        var mailMessage = new MailMessage
        {
            From = new MailAddress("ekys.info@gmail.com"),
            Subject = "İki Adımlı Doğrulama Kodu",
            Body = $@"
                    <!DOCTYPE html>
                    <html lang='tr'>
                    <head>
                        <meta charset='UTF-8'>
                        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                        <title>İki Adımlı Doğrulama</title>
                        <style>
                            body {{
                                font-family: Arial, sans-serif;
                                background-color: #f4f4f4;
                                margin: 0;
                                padding: 0;
                            }}
                            .container {{
                                width: 100%;
                                max-width: 600px;
                                margin: 0 auto;
                                background-color: #ffffff;
                                padding: 20px;
                                border-radius: 8px;
                                box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                            }}
                            .header {{
                                background-color: #4CAF50;
                                color: white;
                                text-align: center;
                                padding: 10px 0;
                                border-radius: 10px 10px 10px 10px;
                            }}
                            .content {{
                                padding: 20px;
                                text-align: center;
                            }}                            
                        </style>
                    </head>
                    <body>
                        <div class='container'>
                            <div class='header'>
                                <h1>İki Adımlı Doğrulama</h1>
                            </div>
                            <div class='content'>
                                <p>Merhaba,</p>
                                <p>Giriş yapabilmek için doğrulama kodunuzu aşağıda bulabilirsiniz:</p>
                                <h2>{twoFactorCode}</h2>
                                <p>Bu kod 5 dakika boyunca geçerlidir.</p>
                            </div>
                        </div>
                    </body>
                    </html>
                    ",
            IsBodyHtml = true
        };

        mailMessage.To.Add(email);

        try
        {
            await _smtpClient.SendMailAsync(mailMessage);
        }
        catch (Exception)
        {
            throw new InvalidOperationException("Mail gönderilemedi!");
        }
    }
    
    
    public async Task ContactUsAsync(ContactUsDto dto,bool isRegistered)
    {
        var mailMessage = new MailMessage
    {
        From = new MailAddress("ekys.info@gmail.com"),
        Subject = "Bize Ulaşın Formu",
        Body = $@"
                <!DOCTYPE html>
                <html lang='tr'>
                <head>
                    <meta charset='UTF-8'>
                    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                    <title>Bize Ulaşın</title>
                    <style>
                        body {{
                            font-family: Arial, sans-serif;
                            background-color: #f4f4f4;
                            margin: 0;
                            padding: 0;
                        }}
                        .container {{
                            width: 100%;
                            max-width: 600px;
                            margin: 0 auto;
                            background-color: #ffffff;
                            padding: 20px;
                            border-radius: 8px;
                            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                        }}
                        .header {{
                            background-color: #4CAF50;
                            color: white;
                            text-align: center;
                            padding: 10px 0;
                            border-radius: 10px 10px 0 0;
                        }}
                        .content {{
                            padding: 20px;
                        }}
                        .content p {{
                            font-size: 16px;
                            color: #333333;
                        }}
                        .footer {{
                            margin-top: 20px;
                            text-align: center;
                            font-size: 14px;
                            color: #777777;
                        }}
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <div class='header'>
                            <h1>Bize Ulaşın Talebi</h1>
                        </div>
                        <div class='content'>
                            <p><strong>Kullanıcı Kayıtlı Mı?:</strong> {isRegistered}</p>
                            <p><strong>İsim:</strong> {dto.Name.ToUpper()}</p>
                            <p><strong>E-posta:</strong> {dto.Email}</p>
                            <p><strong>Mesaj:</strong></p>
                            <p>{dto.Message}</p>
                        </div>
                        <div class='footer'>
                            <p>Bu mesaj, platformumuzdaki 'Bize Ulaşın' formu aracılığıyla gönderilmiştir.</p>
                        </div>
                    </div>
                </body>
                </html>
                ",
        IsBodyHtml = true
    };

    // Mail gönderilecek adres eklenir
    mailMessage.To.Add("ekys.info@gmail.com");

    try
    {
        await _smtpClient.SendMailAsync(mailMessage);
    }
    catch (Exception ex)
    {
        throw new InvalidOperationException("Mail gönderilemedi!", ex);
    }
    }
}
    
    
    
    
