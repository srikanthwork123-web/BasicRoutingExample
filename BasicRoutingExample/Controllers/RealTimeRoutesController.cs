using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicRoutingExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealTimeRoutesController : ControllerBase
    {
        //Parameters we can pass two ways:1.Query string way  2.Route way
        //Query string way(? used in route): http://localhost:5020/api/RealTimeRoutes/getdata?SipId=123&SipName=MySip&SipAmount=1000
        //Route way: http://localhost:5020/api/RealTimeRoutes/getdata/123/MySip/1000
        //To implement the QueryString use [FromQuery] attribute in method parameters.(? used in route)
        //To implement the Route way use [FromRoute] attribute in method parameters.(used in routeName after /give the data of your routeparameter)

        //====================[FromQuery]  Arttribute example(Query string way pass the data) ==============================================================
        [HttpGet]
        [Route("SipDetailsByFromQuery")]//RouteName should not be duplicate in the same controller.
                                        //If you use [FromQuery] attribute,In the above route we are not giving the name of route parameters in the route name after / and in method parameters we are using [FromQuery] attribute to get the data from the query string.
                                        //RouteName:http://localhost:5020/api/RealTimeRoutes/SipDetailsByFromQuery?SipId=123&SipName=MySip&SipAmount=1000
        public async Task<IActionResult> SipDetailsByFromQuery([FromQuery] string SipId, [FromQuery] string SipName, [FromQuery] string SipAmount)
        {
            //IActionResult isa return type of APi method. It is used to return the response from the API method. It is a base class for all the action results that can be returned from an API method. It allows us to return different types of responses such as Ok, NotFound, BadRequest, etc.
            // var result = $"SipId: {SipId}, SipName: {SipName}, SipAmount: {SipAmount}";
            //     (or) both lines are same output generate
            var result = string.Format("SipId: {0}, SipName: {1}, SipAmount: {2}", SipId, SipName, SipAmount);
            return Ok(result);//To return the success data we are used Ok() method. It is used to return the success response from the API method. It returns a 200 OK status code along with the data that we want to return.
        }

        //====================[FromRoute]  Arttribute example(Route way pass the data) ==============================================================

        [HttpGet]//HttpGet attribute is used to specify that this action method will handle HTTP GET requests. when we send a GET request to "api/RealTimeRoutes/SipDetailsByFromRoute/123/MySip/1000" this action method will be executed.
        [Route("SipDetailsByFromRoute/{SipId}/{SipName}/{SipAmount}")]//Through route if you want to pass the data we can go for [FromRoute] attribute.by using this attribute we can pass the data in Routename/pass your values
        //RouteName should not be duplicate in the same controller.
        //If you use [FromRoute] attribute,In the above route we are giving the name of route parameters in the route name after / and in method parameters we are using [FromRoute] attribute to get the data from the route.
        //RouteName:http://localhost:5020/api/RealTimeRoutes/SipDetailsByFromRoute/123/MySip/1000
        public async Task<IActionResult> SipDetailsByFromRoute([FromRoute] string SipId, [FromRoute] string SipName, [FromRoute] string SipAmount)
        { 
//IActionResult isa return type of APi method. It is used to return the response from the API method. It is a base class for all the action results that can be returned from an API method. It allows us to return different types of responses such as Ok, NotFound, BadRequest, etc.
            // var result = $"SipId: {SipId}, SipName: {SipName}, SipAmount: {SipAmount}";
            //     (or) both lines are same output generate
            var result =string.Format("SipId: {0}, SipName: {1}, SipAmount: {2}", SipId, SipName, SipAmount);
            return Ok(result);//To return the success data we are used Ok() method. It is used to return the success response from the API method. It returns a 200 OK status code along with the data that we want to return.
        }
        //[]   squre brackets means attributes
        //[HttpGet]  we called this one as HttpGet attribute.
        //[Route("SipDetailsByFromRoute/{SipId}/{SipName}/{SipAmount}")] we called this one as Route attribute.

        //In latest version we can combine the HttpGet and Route attribute in one line and we can give the route name in HttpGet attribute itself.
        //It is used to specify that this action method will handle HTTP GET requests and also to specify the route template for this action method.
        [HttpGet(Name = "GetEmployeesQueryString")]//Httpmethod+Routename we can combine and write like this way.
        //Latest version we can combine the HttpGet and Route attribute in one line and we can give the route name in HttpGet attribute itself.
        public string GetData([FromQuery] string a, [FromQuery] string b, [FromQuery] string c, [FromQuery] string d, [FromQuery] string e)
        {
            return a + b + c + d + e;

        }
        [HttpGet("Sip-comment/{SiphealthCheckDetailId}")]
        public async Task<IActionResult> SipComment([FromRoute] long SiphealthCheckDetailId)
        {
            var checkType = SiphealthCheckDetailId;
            return Ok(checkType);
        }

    }
}
