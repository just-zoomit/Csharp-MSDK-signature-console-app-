using System;
using System.Collections.Generic;
using System.Text;
using Jose;


  public class ZoomHelper
  {
      static readonly string sdkKey = "YOUR_SDK_KEY";
      static readonly string sdkSecret = "YOUR_SDK_SECRET";
      static readonly int roleId = 1; // 0 for participant, 1 for host
      private static long ToEpoch(DateTime value) => (value.Ticks - 621355968000000000) / (10000 * 1000);
      public static string GetSignature(long meetingNumber)
      {
          var now = DateTime.UtcNow;
          var iat = ToEpoch(now);
          var exp = ToEpoch(now.AddDays(1));
          var payload = new Dictionary<string, object>()
          {
              { "appKey", sdkKey },
              { "sdkKey", sdkKey },
              { "mn", meetingNumber },
              { "role", roleId },
              { "iat", iat },
              { "exp", exp },
              { "tokenExp", exp },
          };
          return Jose.JWT.Encode(payload, Encoding.UTF8.GetBytes(sdkSecret), JwsAlgorithm.HS256);
      }
  }