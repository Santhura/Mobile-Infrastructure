package io.swagger.client.api;

import io.swagger.client.ApiException;
import io.swagger.client.ApiClient;
import io.swagger.client.Configuration;
import io.swagger.client.Pair;
import io.swagger.client.TypeRef;

import io.swagger.client.model.Error;
import io.swagger.client.model.Data;

import java.util.*;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-02T19:09:28.730Z")
public class ProductsApi {
  private ApiClient apiClient;

  public ProductsApi() {
    this(Configuration.getDefaultApiClient());
  }

  public ProductsApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Data Types
   * The Products endpoint returns information about the Uber products\noffered at a given location. The response includes the display name\nand other details about each product, and lists the products in the\nproper display order.
   * @param highScore HighScore of the player.
   * @param maxDecibel Max sound.
   * @param lightLuxes How much light there is in the room.
   * @return List<Data>
   */
  public List<Data> dataGet (Double highScore, Double maxDecibel, Double lightLuxes) throws ApiException {
    Object postBody = null;
    byte[] postBinaryBody = null;
    
     // verify the required parameter 'highScore' is set
     if (highScore == null) {
        throw new ApiException(400, "Missing the required parameter 'highScore' when calling dataGet");
     }
     
     // verify the required parameter 'maxDecibel' is set
     if (maxDecibel == null) {
        throw new ApiException(400, "Missing the required parameter 'maxDecibel' when calling dataGet");
     }
     
     // verify the required parameter 'lightLuxes' is set
     if (lightLuxes == null) {
        throw new ApiException(400, "Missing the required parameter 'lightLuxes' when calling dataGet");
     }
     
    // create path and map variables
    String path = "/Data".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    
    queryParams.addAll(apiClient.parameterToPairs("", "highScore", highScore));
    
    queryParams.addAll(apiClient.parameterToPairs("", "maxDecibel", maxDecibel));
    
    queryParams.addAll(apiClient.parameterToPairs("", "lightLuxes", lightLuxes));
    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] {  };

    

    
    
    TypeRef returnType = new TypeRef<List<Data>>() {};
    return apiClient.invokeAPI(path, "GET", queryParams, postBody, postBinaryBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
    


  }
  
}
