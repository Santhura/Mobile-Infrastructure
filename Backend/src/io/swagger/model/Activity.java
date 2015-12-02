package io.swagger.model;


import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JaxRSServerCodegen", date = "2015-12-02T13:06:30.631Z")
public class Activity  {
  
  private String uuid = null;

  
  /**
   * Unique identifier for the activity
   **/
  @ApiModelProperty(value = "Unique identifier for the activity")
  @JsonProperty("uuid")
  public String getUuid() {
    return uuid;
  }
  public void setUuid(String uuid) {
    this.uuid = uuid;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Activity {\n");
    
    sb.append("  uuid: ").append(uuid).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
