using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductsApi
    {
        
        /// <summary>
        /// Data Types
        /// </summary>
        /// <remarks>
        /// The Products endpoint returns information about the *Uber* products\noffered at a given location. The response includes the display name\nand other details about each product, and lists the products in the\nproper display order.
        /// </remarks>
        /// <param name="highScore">HighScore of the player.</param>
        /// <param name="maxDecibel">Max sound.</param>
        /// <param name="lightLuxes">How much light there is in the room.</param>
        /// <returns></returns>
        List<Data> DataGet (double? highScore, double? maxDecibel, double? lightLuxes);
  
        /// <summary>
        /// Data Types
        /// </summary>
        /// <remarks>
        /// The Products endpoint returns information about the *Uber* products\noffered at a given location. The response includes the display name\nand other details about each product, and lists the products in the\nproper display order.
        /// </remarks>
        /// <param name="highScore">HighScore of the player.</param>
        /// <param name="maxDecibel">Max sound.</param>
        /// <param name="lightLuxes">How much light there is in the room.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task<List<Data>> DataGetAsync (double? highScore, double? maxDecibel, double? lightLuxes);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProductsApi : IProductsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProductsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Data Types The Products endpoint returns information about the *Uber* products\noffered at a given location. The response includes the display name\nand other details about each product, and lists the products in the\nproper display order.
        /// </summary>
        /// <param name="highScore">HighScore of the player.</param> 
        /// <param name="maxDecibel">Max sound.</param> 
        /// <param name="lightLuxes">How much light there is in the room.</param> 
        /// <returns></returns>            
        public List<Data> DataGet (double? highScore, double? maxDecibel, double? lightLuxes)
        {
            
            // verify the required parameter 'highScore' is set
            if (highScore == null) throw new ApiException(400, "Missing required parameter 'highScore' when calling DataGet");
            
            // verify the required parameter 'maxDecibel' is set
            if (maxDecibel == null) throw new ApiException(400, "Missing required parameter 'maxDecibel' when calling DataGet");
            
            // verify the required parameter 'lightLuxes' is set
            if (lightLuxes == null) throw new ApiException(400, "Missing required parameter 'lightLuxes' when calling DataGet");
            
    
            var path_ = "/Data";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (highScore != null) queryParams.Add("highScore", ApiClient.ParameterToString(highScore)); // query parameter
            if (maxDecibel != null) queryParams.Add("maxDecibel", ApiClient.ParameterToString(maxDecibel)); // query parameter
            if (lightLuxes != null) queryParams.Add("lightLuxes", ApiClient.ParameterToString(lightLuxes)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DataGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DataGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Data>) ApiClient.Deserialize(response, typeof(List<Data>));
        }
    
        /// <summary>
        /// Data Types The Products endpoint returns information about the *Uber* products\noffered at a given location. The response includes the display name\nand other details about each product, and lists the products in the\nproper display order.
        /// </summary>
        /// <param name="highScore">HighScore of the player.</param>
        /// <param name="maxDecibel">Max sound.</param>
        /// <param name="lightLuxes">How much light there is in the room.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<Data>> DataGetAsync (double? highScore, double? maxDecibel, double? lightLuxes)
        {
            // verify the required parameter 'highScore' is set
            if (highScore == null) throw new ApiException(400, "Missing required parameter 'highScore' when calling DataGet");
            // verify the required parameter 'maxDecibel' is set
            if (maxDecibel == null) throw new ApiException(400, "Missing required parameter 'maxDecibel' when calling DataGet");
            // verify the required parameter 'lightLuxes' is set
            if (lightLuxes == null) throw new ApiException(400, "Missing required parameter 'lightLuxes' when calling DataGet");
            
    
            var path_ = "/Data";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (highScore != null) queryParams.Add("highScore", ApiClient.ParameterToString(highScore)); // query parameter
            if (maxDecibel != null) queryParams.Add("maxDecibel", ApiClient.ParameterToString(maxDecibel)); // query parameter
            if (lightLuxes != null) queryParams.Add("lightLuxes", ApiClient.ParameterToString(lightLuxes)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DataGet: " + response.Content, response.Content);

            return (List<Data>) ApiClient.Deserialize(response, typeof(List<Data>));
        }
        
    }
    
}
