﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
namespace ELearning.DAL
{
    public class Generic
    {
        UserContext db = new UserContext();
        AdminManager admin = new AdminManager();

        public string EmailFormatForResetLink(string name = null, string emailid = null)
        {
            string resetlink = Global.WebsiteUrl() + "Account/ResetPassword/?EmailID=" + emailid;
            string thankumsg = "Hello" + name + "," + "<br>Seems like you forgot your ELearning password.To reset it just click on bellow button";
            string format = "<!DOCTYPE html><html><head><title></title><meta http-equiv='Content-Type' content='text/html; charset=utf-8' /><meta name='viewport' content='width=device-width, initial-scale=1'><meta http-equiv='X-UA-Compatible' content='IE=edge' />" +
     "<style type='text/css'>body,table,td,a {-webkit-text-size-adjust: 100%;-ms-text-size-adjust: 100%;}table,td {mso-table-lspace: 0pt;mso-table-rspace: 0pt;}img {-ms-interpolation-mode: bicubic;}" +

         "img {border: 0;height: auto;line-height: 100%;outline: none;text-decoration: none;} table { border-collapse: collapse !important;}" +
 "body {height: 100% !important;margin: 0 !important;padding: 0 !important;width: 100% !important;}a[x-apple-data-detectors] { color: inherit !important; text-decoration: none !important;font-size: inherit !important;font-family: inherit !important;font-weight: inherit !important;line-height: inherit !important;}" +
 " @media screen and (max-width: 480px) {.mobile-hide {display: none !important;}.mobile-center { text-align: center !important;}} div[style*='margin: 16px 0;'] { margin: 0 !important;}</style>" +

 "<body style='margin: 0 !important; padding: 0 !important; background-color: #eeeeee;' bgcolor='#eeeeee'>" +
     "<div style='display: none; font-size: 1px; color: #fefefe; line-height: 1px; font-family: Open Sans, Helvetica, Arial, sans-serif; max-height: 0px; max-width: 0px; opacity: 0; overflow: hidden;'>For what reason would it be advisable for me to think about business content? That might be little bit risky to have crew member like them.</div>" +
     "<table border='0' cellpadding='0' cellspacing='0' width='100%'>" +
 "<tr><td align='center' style='background-color: #eeeeee;' bgcolor='#eeeeee'>" +
                 "<table align='center' border='0' cellpadding='0' cellspacing='0' width='100%' style='max-width:600px;'><tr>" +
                        " <td align='center' valign='top' style='font-size:0; padding: 35px;' bgcolor='#4bb777'>" +
                             "<div style='display:inline-block; max-width:50%; min-width:100px; vertical-align:top; width:100%;'>" +
                                 "<table align='left' border='0' cellpadding='0' cellspacing='0' width='100%' style='max-width:300px;'>" +
                                     "<tr>" +
                                        " <td align='left' valign='top' style='font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 36px; font-weight: 800; line-height: 48px;' class='mobile-center'>" +
                                             "<h1 style='font-size: 36px; font-weight: 800; margin: 0; color: #ffffff;'>ELearning</h1>" +
                                         "</td>" +
                                     "</tr>" +
                                 "</table>" +
                             "</div>" +
                             "<div style='display:inline-block; max-width:50%; min-width:100px; vertical-align:top; width:100%;' class='mobile-hide'>"
                                 + "<table align='left' border='0' cellpadding='0' cellspacing='0' width='100%' style='max-width:300px;'>" +
                                     "<tr>" +
                                         "<td align='right' valign='top' style='font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 48px; font-weight: 400; line-height: 48px;'>" +
                                             "<table cellspacing='0' cellpadding='0' border='0' align='right'>" +
                                                 "<tr>" +
                                                     "<td style='font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400;'>" +
                                                         "<p style='font-size: 18px; font-weight: 400; margin: 0; color: #ffffff;'><a href='#' target='_blank' style='color: #ffffff; text-decoration: none;'>Shop &nbsp;</a></p>" +
                                                     "</td>" +
                                                     "<td style='font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 24px;'> <a href='#' target='_blank' style='color: #ffffff; text-decoration: none;'><img src='https://img.icons8.com/color/48/000000/small-business.png' width='27' height='23' style='display: block; border: 0px;' /></a> </td>" +
                                                 "</tr>" +
                                             "</table>" +
                                        " </td>" +
                                     "</tr>" +
                                 "</table>" +
                            " </div>" +
                         "</td>" +
                    " </tr>" +
                    " <tr>" +
                         "<td align='center' style='padding: 35px 35px 20px 35px; background-color: #ffffff;' bgcolor='#ffffff'>" +
                             "<table align='center' border='0' cellpadding='0' cellspacing='0' width='100%' style='max-width:600px;'>" +
                                 "<tr>" +
                                   "<td align='center' style='font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 24px; padding-top: 25px;'> " +
                                         "<h2 style='font-size: 30px; font-weight: 800; line-height: 36px; color: #333333; margin: 0;'> Reset Your Password! </h2>" +
                                     "</td>" +
                                 "</tr>" +
                                 "<tr>" +
                                    " <td align='left' style='font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 24px; padding-top: 10px;'>" +
                                         "<p style='font-size: 16px; font-weight: 400; line-height: 24px; color: #777777;'>" + thankumsg + "</p>" +
                                     "</td>" +
                                 "</tr>" +


                             "</table>" +
                         "</td>" +
                     "</tr>" +

                     "<tr>" +
                         "<td align='center' style=' padding: 35px; background-color: #ff7361;' bgcolor='#1b9ba3'>" +
                             "<table align='center' border='0' cellpadding='0' cellspacing='0' width='100%' style='max-width:600px;'>" +

                                 "<tr>" +
                                     "<td align='center' style='padding: 25px 0 15px 0;'>" +
                                         "<table border='0' cellspacing='0' cellpadding='0'>" +
                                             "<tr>" +
                                                 "<td align='center' style='border-radius: 5px;' bgcolor='#66b3b7'><a href='" + resetlink + "' target='_blank' style='font-size: 18px; font-family: Open Sans, Helvetica, Arial, sans-serif; color: #ffffff; text-decoration: none; border-radius: 5px; background-color: #F44336; padding: 15px 30px; border: 1px solid #F44336; display: block;'>Reset Password</a></td>" +
                                             "</tr>" +
                                         "</table>" +
                                     "</td>" +
                                 "</tr>" +
                             "</table>" +
                         "</td>" +
                     "</tr>" +
                     "<tr>" +
                         "<td align='center' style='padding: 35px; background-color: #ffffff;' bgcolor='#ffffff'>" +
                             "<table align='center' border='0' cellpadding='0' cellspacing='0' width='100%' style='max-width:600px;'>" +
                                 "<tr>" +
                                     "<td align='center'>" + "<img src='http://hygienindia.com/Designs/HygienIndia.png' width='150' height='60' style='display: block; border: 0px;' />" + "</td>" +
                                 "</tr>" +
                                 "<tr>" +

                                     "<td align='center' style='font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 14px; font-weight: 400; line-height: 24px; padding: 5px 0 10px 0;'>" +
                                         "<p style='font-size: 14px; font-weight: 800; line-height: 18px; color: #333333;'>Ground Floor, Shop No. 16 ,<br>Near Fruit Market, <br> Prograssive Point,Lalpur,<br>Raipur, Chhattisgarh (India)<br>Pin Code - 493111</p>" +
                                     "</td>" +
                                 "</tr>" +
                                 "<tr>" +
                                     "<td align='left' style='font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 14px; font-weight: 400; line-height: 24px;'>" +
                                         "<p style='font-size: 14px; font-weight: 400; line-height: 20px; color: #777777;'> If you didn't create an account using this email address, please ignore this email or <a href='#' target='_blank' style='color: #777777;'>unsusbscribe</a></p>" +
                                     "</td>" +
                                 "</tr>" +
                             "</table>" +
                         "</td>" +
                     "</tr>" +
                 "</table>" +
             "</td>" +
         "</tr>" +
    "</table>" + "</body></html>";

            return format;

        }

        public string SendConfirmationMail(string EmailId = null, string subject = null, string msg = null)
        {
            var senderEmail = new MailAddress("hygienindia@gmail.com", "ELearning India Support");
            var receiverEmail = new MailAddress(EmailId, "Receiver");
            var password = "Numanta@123";
            var sub = subject;
            var body = msg;
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)
            };
            using (var mess = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body
            })
            {
                mess.IsBodyHtml = true;
                smtp.Send(mess);
            }
            return "Done";
        }

    }
}