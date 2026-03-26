using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicRoutingExample.Controllers
{//to implement the routing use this Route attribute in the controller class above. these attributes are used to define the routes for the action methods in the controller.
    [Route("api/[controller]")]//Parent route declareed for this controller. This means that all the routes for the actions in this controller will be prefixed with "api/Sample".
    [ApiController]  //this is one attribute add additional features to our sample controller.it indicates this is api controller
    //[ApiController] attribute is used to indicate that this class is an API controller. It enables several features such as automatic model validation and binding source parameter related things...
    //[]     squre brackets called attributes.these are used to add metadata to the code. These attributes additional information about the code and can be used to control how the code behaves.
    //[] attribute is used to specify the route template for the controller.
    //In this case, it indicates that the route for this controller will be "api/Sample" (since [controller] will be replaced with the name of the controller, which is "Sample").
    //***every controller above 2 attributes are there
    //1.[Route("api/[controller]")] this attribute is used to specify the route template for the controller. In this case, it indicates that the route for this controller will be "api/Sample" (since [controller] will be replaced with the name of the controller, which is "Sample").
    //2.[ApiController] this attribute is used to indicate that this class is an API controller. It enables several features such as automatic model validation and binding source parameter related things...
    public class SampleController : ControllerBase
    {//every controller is ingheriting from ControllerBase class
      //controller inside the controller we have action methods. these action methods are responsible for handling the incoming HTTP requests and returning the appropriate responses.
        [HttpGet]//get api method(It is used to retrieve the data from a database table). [HttpGet] this attribute is used to specify that this action method will handle HTTP GET requests. when we send a GET request to "api/Sample" this action method will be executed.
        [Route("listofData")]//child route name declareed for this action method or api method. This means that the full route for this action method will be "api/Sample/listofData".
        //RoueName:http://localhost:5020/api/Sample/listofData
        public string  listofData()//this is one api method.it contains above 2 attributes.1.[HttpGet] this attribute is used to specify that this action method will handle HTTP GET requests. when we send a GET request to "api/Sample" this action method will be executed.2.[Route("listofData")] this attribute is used to specify the route template for this action method. In this case, it indicates that the full route for this action method will be "api/Sample/listofData".
        {//Route Structe is:api/sample/listofData
            var result = "Hello";
            return result;
        }//if you send the request from postman/insomaina/swagger it will this api method or http get method,it will reyurn the resspone
        //insde controller by using any http methods if you write methods,that is called action methods or api methods.
//=======================================================
        [HttpPost]//post api method(It is used to insert the data)
        [Route("insertdata")]//child routes define here/decalre here
        //RouteName:http://localhost:5020/api/Sample/insertdata?a=10&b=20
        //to pass the data to parameters by using ? (Question mark (or)querystring way)it is possible.
        public int insertdata(int a, int b)
        {//method inside we are writing the logic as per requriment.
            return a + b;
        }
        //By using Routing concept.we can call the correct controller and inside controller api methods.
        [HttpPut]//update api method(It is used to update the data)
        [Route("updatedata")]//child routes define here
        //RouteName:http://localhost:5020/api/Sample/updatedata?a=30&b=30
        public int updatedata(int a, int b)
        {
            return a - b;
        }
        [HttpDelete]//delete api method(It is used to delete the data)
        [Route("deletedata")]//child routes define here
        //RouteName:http://localhost:5020/api/Sample/deletedata?a=10&b=20
        public int deletedata(int a, int b)
        {
            return a - b;

        }


    }
}
