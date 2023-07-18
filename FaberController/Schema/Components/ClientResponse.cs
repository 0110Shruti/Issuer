// using System;

// public class ClientResponse : Exception
// {
//     public ClientResponse(string message) : base(message)
//     {
//     }
// }

// // using System;
// // using System.Collections.Generic;
// // using System.IO;
// // using System.Security.Policy;
// // using System.Text;
// // using System.Threading.Tasks;
// // using System.Text.RegularExpressions;



// // // public class ClientResponse : Exception
// // // {
// // //     public ClientResponse(string message) : base(message)
// // //     {
// // //     }
// // // }
// // using System.Collections.Generic;
// // using System.Diagnostics;
// // using System.Net.Mime;
// // using FaberController.Connection.Components;

// // public class RequestInfo
// // {
// //     // Properties with auto-implemented getters and setters
// //     public Uri Url { get; set; }
// //     public string Method { get; set; }
// //     public Dictionary<string, string> Headers { get; set; }
// //     public Uri RealUrl { get; }

// //     // Constructor with optional parameter for RealUrl
// //     public RequestInfo(Uri url, string method, Dictionary<string, string> headers, Uri realUrl = null)
// //     {
// //         Url = url;
// //         Method = method;
// //         Headers = headers;
// //         RealUrl = realUrl ?? url;
// //     }
// // }



// // public class ClientResponse
// // {
// //     public string version;
// //     public int status;
// //     public string reason;
// //     public StreamReader content;
// //     public Dictionary<string, string> _headers;
// //     //RawHeaders is a class with tuple tydef
// //     public Array _raw_headers;
// //     private object _connection=null;
// //     private object _source_traceback;
// //     private bool _closed = true;
// //     private bool _released = false;
// //     public string method;
// //     //Implements a simple cookie class in python used to store and retrieve cookies.
// //     public String cookies;
// //     //changed Url to Uri
// //     private Uri _real_url;
// //     //changed URL type to uri
// //     private Uri _url;
// //     private object _body;
// //     private Task _writer;
// //     private Task<bool> _continue;
// //     //initially BaseTimerContext
// //     private IDisposable _timer;
// //     private RequestInfo _request_info;
// //     private List<Trace> _traces;
// //     // private AbstractEventLoop _loop;
// //     // private ClientSession _session;

// //     public ClientResponse(
// //         string method,
// //         Uri url,
// //         Task writer,
// //         Task<bool> continue100,
// //        //initially BaseTimerContext
// //        IDisposable timer,
// //         RequestInfo request_info,
// //         List<Trace> traces
// //     // AbstractEventLoop loop,
// //     // ClientSession session)
// //     )
// //     {
// //         if (url is Uri)
// //         {
// //             _real_url = url;
// //             //this method is within URL class which another package
// //             // _url = url.with_fragment(null);
// //         }
// //         else
// //         {
// //             throw new ArgumentException("url should be of type Uri");
// //         }

// //         this.method = method;
// //         //uncomment when simple cookie class is defined
// //         // this.cookies = new SimpleCookie<string>();
// //         this._writer = writer;
// //         this._continue = continue100;
// //         this._closed = true;
// //         //defined tuple class returning _history changed tuple to list
// //         this._history = new List<ClientResponse>() { };
// //         this._request_info = request_info;
// //         //defined timernoop below
// //         this._timer = timer ?? new TimerNoop();
// //         //it is of type dictionary but not initiazled
// //         // this._cache = new Dictionary<string, object>();
// //         this._traces = traces;
// //         //uncomment when abstracteventloop and clientsession variables are defined
// //         // this._loop = loop;
// //         // this._session = session;
// //     }
   

// //     public Uri url
// //     {
// //         get
// //         {
// //             if (_url != null)
// //             {
// //                 return _url;
// //             }
// //             else
// //             {
// //                 return _real_url;
// //             }
// //         }
// //     }

// //     public Uri url_obj
// //     {
// //         get
// //         {
// //             Console.WriteLine("Deprecated, use .url #1654");
// //             return _url;
// //         }
// //     }

// //     public Uri real_url
// //     {
// //         get
// //         {
// //             return _real_url;
// //         }
// //     }

// //     public string host
// //     {
// //         get
// //         {
// //             //changed case host to Host
// //             if (_url.Host != null)
// //             {
// //                 return _url.Host;
// //             }
// //             else
// //             {
// //                 throw new NullReferenceException("Uri does not have a host");
// //             }
// //         }
// //     }

// //     public Dictionary<string, string> headers
// //     {
// //         get
// //         {
// //             return _headers;
// //         }
// //     }

// //     //changed public RawHeaders to Array raw_headers
// //     public Array raw_headers
// //     {
// //         get
// //         {
// //             return _raw_headers;
// //         }
// //     }

// //     public RequestInfo request_info
// //     {
// //         get
// //         {
// //             return _request_info;
// //         }
// //     }

// //     // public ContentDisposition content_disposition
// //     // {
// //     //     get
// //     //     {
// //         //hdrs and multipart are separate python files
// //     //         string raw = _headers[hdrs.CONTENT_DISPOSITION];
// //     //         if (raw == null)
// //     //         {
// //     //             return null;
// //     //         }
// //     //         else
// //     //         {
// //     //             Dictionary<string, string> params_dct = multipart.parse_content_disposition(raw);
// //     //             Dictionary<string, string> paramsDict = new Dictionary<string, string>(params_dct);
// //     //             string filename = multipart.content_disposition_filename(paramsDict);
// //     //             return new ContentDisposition(disposition_type, paramsDict, filename);
// //     //         }
// //     //     }
// //     // }
// //  private List<Action> _callbacks = new List<Action>();
// //     private object _lock = new object();

// //     private void _NotifyRelease()
// //     {
// //         List<Action> callbacks;

// //         lock (_lock)
// //         {
// //             callbacks = new List<Action>(_callbacks);
// //             _callbacks.Clear();
// //         }

// //         foreach (Action cb in callbacks)
// //         {
// //             try
// //             {
// //                 cb();
// //             }
// //             catch (Exception)
// //             {
// //                 // Suppress any exceptions that occur during the callback execution.
// //             }
// //         }
// //     }

// //     public void Release()
// //     {
// //         _NotifyRelease();

// //         if (_protocol != null)
// //         {
// //             _connector.Release(_key, _protocol, shouldClose: _protocol.ShouldClose);
// //             _protocol = null;
// //         }
// //     }
// //     ~ClientResponse()
// //     {
// //         if (_closed)
// //         {
// //             return;
// //         }

// //         if (_connection != null)
// //         {
// //             _connection.release();
// //             _cleanup_writer();

// //             if (_loop.get_debug())
// //             {
// //                 if (PY_36)
// //                 {
// //                     var kwargs = new { source = this };
// //                 }
// //                 else
// //                 {
// //                     var kwargs = new { };
// //                 }
// //                 _warnings.warn($"Unclosed response {this!r}", ResourceWarning, **kwargs);
// //                 var context = new Dictionary<string, object>() { { "client_response", this }, { "message", "Unclosed response" } };
// //                 if (_source_traceback != null)
// //                 {
// //                     context["source_traceback"] = _source_traceback;
// //                 }
// //                 _loop.call_exception_handler(context);
// //             }
// //         }
// //     }

// //     public override string ToString()
// //     {
// //         var out = new StringWriter();
// //         var ascii_encodable_url = url.ToString();
// //         var ascii_encodable_reason = Encoding.ASCII.GetString(Encoding.Default.GetBytes(reason));
// //         out.WriteLine("<ClientResponse({}) [{} {}]>", ascii_encodable_url, status, ascii_encodable_reason);
// //         out.WriteLine(headers);
// //         return out.ToString();
// //     }

// //     public object connection
// //     {
// //         get
// //         {
// //             return _connection;
// //         }
// //     }

// //     private List<ClientResponse> _history;

// //     public List<ClientResponse> History
// //     {
// //         get { return _history; }
// //     }

// //     public MultiDictProxy<MultiDictProxy<Union<string, Uri>>> links
// //     {
// //         get
// //         {
// //             string links_str = string.Join(", ", headers.getall("link", new string[0]));

// //             if (string.IsNullOrEmpty(links_str))
// //             {
// //                 return new MultiDictProxy<MultiDictProxy<Union<string, Uri>>>(new MultiDict<MultiDictProxy<Union<string, Uri>>>());
// //             }

// //             var links = new MultiDict<MultiDictProxy<Union<string, Uri>>>();

// //             foreach (var val in Regex.Split(links_str, ",(?=\\s*<)"))
// //             {
// //                 var match = Regex.Match(val, "\\s*<(.*?)>(.*)");
// //                 string url = match.Groups[1].Value;
// //                 string params_str = match.Groups[2].Value;
// //                 var params = params_str.Split(';').ToList();

// //                 var link = new MultiDict<Union<string, Uri>>();

// //                 foreach (var param in params)
// //                 {
// //                     var param_match = Regex.Match(param, "^\\s*(.*?)\\s*=\\s*(?:['\"]?)(.*?)(?:\\2)\\s*$");
// //                     string key = param_match.Groups[1].Value;
// //                     string value = param_match.Groups[2].Value;

// //                     link.Add(key, value);
// //                 }

// //                 string key = link["rel"] ?? url;

// //                 link.Add("url", url);
// //                 links.Add(key, new MultiDictProxy<Union<string, Uri>>(link));
// //             }

// //             return new MultiDictProxy<MultiDictProxy<Union<string, Uri>>>(links);
// //         }
// //     }

// //     public async Task<ClientResponse> Start(object connection)
// //     {
// //         _closed = false;
// //         _protocol = connection.protocol;
// //         _connection = connection;

// //         while (true)
// //         {
// //             try
// //             {
// //                 var protocol = _protocol;
// //                 var message_payload = await protocol.read();
// //                 var message = message_payload.Item1;
// //                 var payload = message_payload.Item2;

// //                 if (message.code < 100 || message.code > 199 || message.code == 101)
// //                 {
// //                     break;
// //                 }

// //                 if (_continue != null)
// //                 {
// //                     set_result(_continue, true);
// //                     _continue = null;
// //                 }
// //             }
// //             catch (HttpProcessingError exc)
// //             {
// //                 throw new ClientResponseError(
// //                     request_info,
// //                     history,
// //                     exc.code,
// //                     exc.message,
// //                     exc.headers
// //                 );
// //             }
// //         }

// //         payload.on_eof(_response_eof);

// //         version = message.version;
// //         status = message.code;
// //         reason = message.reason;
// //         _headers = message.headers;
// //         _raw_headers = message.raw_headers;
// //         content = payload;

// //         foreach (var hdr in headers.getall(hdrs.SET_COOKIE, new string[0]))
// //         {
// //             try
// //             {
// //                 cookies.load(hdr);
// //             }
// //             catch (CookieError exc)
// //             {
// //                 client_logger.warning($"Can not load response cookies: {exc}");
// //             }
// //         }

// //         return this;
// //     }

// //     private void _response_eof()
// //     {
// //         if (_closed)
// //         {
// //             return;
// //         }

// //         if (_connection != null)
// //         {
// //             if (_connection.protocol != null && _connection.protocol.upgraded)
// //             {
// //                 return;
// //             }

// //             _connection.release();
// //             _connection = null;
// //         }

// //         _closed = true;
// //         _cleanup_writer();
// //     }

// //     public bool closed
// //     {
// //         get
// //         {
// //             return _closed;
// //         }
// //     }

// //     public void Close()
// //     {
// //         if (!_released)
// //         {
// //             _notify_content();
// //         }
// //         if (_closed)
// //         {
// //             return;
// //         }

// //         _closed = true;
// //         if (_loop == null || _loop.is_closed())
// //         {
// //             return;
// //         }

// //         if (_connection != null)
// //         {
// //             _connection.close();
// //             _connection = null;
// //         }
// //         _cleanup_writer();
// //     }

// //     // public void Release()
// //     // {
// //     //     if (!_released)
// //     //     {
// //     //         _notify_content();
// //     //     }
// //     //     if (_closed)
// //     //     {
// //     //         return;
// //     //     }

// //     //     _closed = true;
// //     //     if (_connection != null)
// //     //     {
// //     //         _connection.release();
// //     //         _connection = null;
// //     //     }

// //     //     _cleanup_writer();
// //     // }

// //     public async Task WaitForClose()
// //     {
// //         if (_writer != null)
// //         {
// //             await _writer;
// //             _writer = null;
// //         }

// //         Release();
// //     }

// //     public async Task<byte[]> Read()
// //     {
// //         if (_body == null)
// //         {
// //             _body = await content.read();
// //             foreach (var trace in _traces)
// //             {
// //                 await trace.send_response_chunk_received(method, url, _body);
// //             }
// //         }
// //         else if (_released)
// //         {
// //             throw new ClientConnectionError("Connection closed");
// //         }

// //         return _body;
// //     }

// //     public string GetEncoding()
// //     {
// //         string ctype = headers.get(hdrs.CONTENT_TYPE, "").ToLower();
// //         var mimetype = helpers.parse_mimetype(ctype);

// //         string encoding = mimetype.parameters.get("charset");
// //         if (encoding != null)
// //         {
// //             try
// //             {
// //                 Encoding.GetEncoding(encoding);
// //             }
// //             catch (ArgumentException)
// //             {
// //                 encoding = null;
// //             }
// //         }

// //         if (encoding == null)
// //         {
// //             if (mimetype.type == "application" && (mimetype.subtype == "json" || mimetype.subtype == "rdap"))
// //             {
// //                 encoding = "utf-8";
// //             }
// //             else if (_body == null)
// //             {
// //                 throw new Exception("Cannot guess the encoding of a not yet read body");
// //             }
// //             else
// //             {
// //                 encoding = chardet.detect(_body)["encoding"];
// //             }
// //         }

// //         if (encoding == null)
// //         {
// //             encoding = "utf-8";
// //         }

// //         return encoding;
// //     }

// //     public async Task<string> Text(string encoding = null, string errors = "strict")
// //     {
// //         if (_body == null)
// //         {
// //             await Read();
// //         }

// //         if (encoding == null)
// //         {
// //             encoding = GetEncoding();
// //         }

// //         return Encoding.GetEncoding(encoding).GetString(_body);
// //     }

// //     public async Task<object> Json(string encoding = null, JSONDecoder loads = DEFAULT_JSON_DECODER, string content_type = "application/json")
// //     {
// //         if (_body == null)
// //         {
// //             await Read();
// //         }

// //         if (content_type != null)
// //         {
// //             string ctype = headers.get(hdrs.CONTENT_TYPE, "").ToLower();
// //             if (!_is_expected_content_type(ctype, content_type))
// //             {
// //                 throw new ContentTypeError(request_info, history, $"Attempt to decode JSON with unexpected mimetype: {ctype}", headers);
// //             }
// //         }

// //         string stripped = _body.Trim();
// //         if (stripped.Length == 0)
// //         {
// //             return null;
// //         }

// //         if (encoding == null)
// //         {
// //             encoding = GetEncoding();
// //         }

// //         return loads(Encoding.GetEncoding(encoding).GetString(stripped));
// //     }

// //     public Task Start(Connection connection)
// //     {
// //         return Start((object)connection);
// //     }

// //     private void _cleanup_writer()
// //     {
// //         if (_writer != null)
// //         {
// //             _writer.Dispose();
// //         }
// //         _writer = null;
// //         _session = null;
// //     }

// //     private void _notify_content()
// //     {
// //         if (content != null && content.exception() == null)
// //         {
// //             content.set_exception(new ClientConnectionError("Connection closed"));
// //         }
// //         _released = true;
// //     }
// // }

// // internal class TimerNoop : IDisposable
// // {
// //     public void Dispose()
// //     {
// //         throw new NotImplementedException();
// //     }
// // }