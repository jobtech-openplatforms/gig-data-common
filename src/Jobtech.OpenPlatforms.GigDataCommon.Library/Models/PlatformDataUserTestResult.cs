namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models
{
    public class PlatformDataUserTestResult
    {
        public PlatformDataUserTestResult(PlatformDataUserUpdateResult platformDataUserUpdateResult, TestRequest testRequest, TestResponse testResponse)
        {
            Result = platformDataUserUpdateResult;
            Request = testRequest;
            Response = testResponse;
        }

        public PlatformDataUserUpdateResult Result { get; private set; }
        public TestRequest Request { get; private set; }
        public TestResponse Response { get; private set; }
    }

    public class TestResponse
    {
        public TestResponse(string[] headers, string status, string body)
        {
            Headers = headers;
            Status = status;
            Body = body;
        }

        public string[] Headers { get;  }
        public string Status { get; }
        public string Body { get; set; }
    }

    public class TestRequest
    {
        public TestRequest(string[] headers, object body)
        {
            Headers = headers;
        }

        public string[] Headers { get; }
        public object Body { get; set; }
    }
}
