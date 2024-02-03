using System;
namespace TestApi.Model
{
	public class DataRequest: BaseRequest
    {
        public string Name { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}

