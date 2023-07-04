using Microsoft.AspNetCore.Diagnostics;
using System.Net.Mime;
using System.Net;
using System.Text.Json;
using System.Text;
using System.Security.Cryptography;

namespace OnionAPI.API.Extensions
{
    static public class ConfigureExceptionHandlerExtension
    {
        public static void ConfigureExceptionHandler(this WebApplication application, Serilog.ILogger logger)
        {
            application.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = MediaTypeNames.Application.Json;

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {

                        string errorCode = HataKoduUret();
                        logger.Error(contextFeature.Error, errorCode);
                        await context.Response.WriteAsync(JsonSerializer.Serialize(new
                        {

                            StatusCode = context.Response.StatusCode,
                            Message = contextFeature.Error.Message,
                            ErrorCode = errorCode,
                            Title = "Hata alındı!"
                        }));
                    }
                });
            });
        }

        public class RandomGenerator
        {
            private static readonly RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();
            private static int GenerateSeed(int length)
            {
                var ramdomData = new byte[length];
                random.GetNonZeroBytes(ramdomData);
                return BitConverter.ToInt32(ramdomData, 0);
            }
            public static Random Olustur()
            {
                return new Random(GenerateSeed(4));
            }
        }

        private readonly static string sRandomSet = "0123456789ABCDEFGHJKLMNOPRSTUVYZ";
        [ThreadStatic]
        private static Random tsRandom;
        public static Random rRasgeleSayi
        {
            get
            {
                if (tsRandom == null)
                {
                    tsRandom = RandomGenerator.Olustur();
                }
                return tsRandom;
            }
        }

        public static string HataKoduUret()
        {
            var sErrorCode = new StringBuilder();
            sErrorCode.Append(sRandomSet[rRasgeleSayi.Next(0, 31)]);
            sErrorCode.Append(sRandomSet[rRasgeleSayi.Next(0, 31)]);
            sErrorCode.Append(sRandomSet[rRasgeleSayi.Next(0, 31)]);
            sErrorCode.Append(sRandomSet[rRasgeleSayi.Next(0, 31)]);
            sErrorCode.Append(sRandomSet[rRasgeleSayi.Next(0, 31)]);
            sErrorCode.Append(sRandomSet[rRasgeleSayi.Next(0, 31)]);
            sErrorCode.Append(sRandomSet[rRasgeleSayi.Next(0, 31)]);
            sErrorCode.Append(sRandomSet[rRasgeleSayi.Next(0, 31)]);

            var s = sErrorCode.ToString();
            if (s.Length < 8)
            {
                s = s.PadRight(8, '0');
            }
            return s;
        }

    }
}
