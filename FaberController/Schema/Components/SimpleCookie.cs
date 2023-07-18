// public class SimpleCookie<T>
// {
//     private Dictionary<string, T> _cookies = new Dictionary<string, T>();

//     public void SetCookie(string key, T value)
//     {
//         _cookies[key] = value;
//     }

//     public T GetCookie(string key)
//     {
//         if (_cookies.TryGetValue(key, out T value))
//         {
//             return value;
//         }
//         return default(T); // Or handle default value accordingly for your type T
//     }

//     public string ToHeaderValue()
//     {
//         var cookieHeader = new StringBuilder();
//         foreach (var pair in _cookies)
//         {
//             var encodedKey = WebUtility.UrlEncode(pair.Key);
//             var encodedValue = WebUtility.UrlEncode(pair.Value.ToString());
//             cookieHeader.AppendFormat("{0}={1}; ", encodedKey, encodedValue);
//         }
//         return cookieHeader.ToString().TrimEnd(' ', ';');
//     }

//     public void FromHeaderValue(string headerValue)
//     {
//         var cookies = headerValue.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
//         foreach (var cookie in cookies)
//         {
//             var parts = cookie.Split(new[] { '=' }, 2);
//             if (parts.Length == 2)
//             {
//                 var key = WebUtility.UrlDecode(parts[0].Trim());
//                 var value = WebUtility.UrlDecode(parts[1].Trim());
//                 _cookies[key] = (T)Convert.ChangeType(value, typeof(T));
//             }
//         }
//     }

//     // Other methods as needed...
// }