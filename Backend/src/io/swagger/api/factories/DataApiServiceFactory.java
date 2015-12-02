package io.swagger.api.factories;

import io.swagger.api.DataApiService;
import io.swagger.api.impl.DataApiServiceImpl;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JaxRSServerCodegen", date = "2015-12-02T13:06:30.631Z")
public class DataApiServiceFactory {

   private final static DataApiService service = new DataApiServiceImpl();

   public static DataApiService getDataApi()
   {
      return service;
   }
}
