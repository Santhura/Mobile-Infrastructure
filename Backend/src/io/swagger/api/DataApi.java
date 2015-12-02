package io.swagger.api;

import io.swagger.model.*;
import io.swagger.api.DataApiService;
import io.swagger.api.factories.DataApiServiceFactory;

import io.swagger.annotations.ApiParam;

import com.sun.jersey.multipart.FormDataParam;

import io.swagger.model.Error;
import io.swagger.model.Data;

import java.util.List;
import io.swagger.api.NotFoundException;

import java.io.InputStream;

import com.sun.jersey.core.header.FormDataContentDisposition;
import com.sun.jersey.multipart.FormDataParam;

import javax.ws.rs.core.Response;
import javax.ws.rs.*;

@Path("/Data")

@Produces({ "application/json" })
@io.swagger.annotations.Api(description = "the Data API")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JaxRSServerCodegen", date = "2015-12-02T13:06:30.631Z")
public class DataApi  {
   private final DataApiService delegate = DataApiServiceFactory.getDataApi();

    @GET
    
    
    @Produces({ "application/json" })
    @io.swagger.annotations.ApiOperation(value = "Data Types", notes = "The Products endpoint returns information about the *Uber* products\noffered at a given location. The response includes the display name\nand other details about each product, and lists the products in the\nproper display order.", response = Data.class, responseContainer = "List", tags={ "Products" })
    @io.swagger.annotations.ApiResponses(value = { 
        @io.swagger.annotations.ApiResponse(code = 200, message = "An array of data", response = Data.class, responseContainer = "List"),
        
        @io.swagger.annotations.ApiResponse(code = 200, message = "Unexpected error", response = Data.class, responseContainer = "List") })

    public Response dataGet(@ApiParam(value = "HighScore of the player.",required=true) @QueryParam("highScore") Double highScore,
    @ApiParam(value = "Max sound.",required=true) @QueryParam("maxDecibel") Double maxDecibel,
    @ApiParam(value = "How much light there is in the room.",required=true) @QueryParam("lightLuxes") Double lightLuxes)
    throws NotFoundException {
        return delegate.dataGet(highScore,maxDecibel,lightLuxes);
    }
}

