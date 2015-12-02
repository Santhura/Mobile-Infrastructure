package io.swagger.api.factories;

import io.swagger.api.HistoryApiService;
import io.swagger.api.impl.HistoryApiServiceImpl;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JaxRSServerCodegen", date = "2015-12-02T13:06:30.631Z")
public class HistoryApiServiceFactory {

   private final static HistoryApiService service = new HistoryApiServiceImpl();

   public static HistoryApiService getHistoryApi()
   {
      return service;
   }
}
