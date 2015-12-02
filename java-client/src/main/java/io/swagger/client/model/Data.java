package io.swagger.client.model;

import io.swagger.client.StringUtil;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-02T19:09:28.730Z")
public class Data   {
  
  private String dataId = null;
  private String description = null;
  private String displayName = null;
  private String capacity = null;

  
  /**
   * Unique identifier representing a specific product for a given latitude & longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles.
   **/
  @ApiModelProperty(value = "Unique identifier representing a specific product for a given latitude & longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles.")
  @JsonProperty("data_id")
  public String getDataId() {
    return dataId;
  }
  public void setDataId(String dataId) {
    this.dataId = dataId;
  }

  
  /**
   * Description of data.
   **/
  @ApiModelProperty(value = "Description of data.")
  @JsonProperty("description")
  public String getDescription() {
    return description;
  }
  public void setDescription(String description) {
    this.description = description;
  }

  
  /**
   * Display name of data.
   **/
  @ApiModelProperty(value = "Display name of data.")
  @JsonProperty("display_name")
  public String getDisplayName() {
    return displayName;
  }
  public void setDisplayName(String displayName) {
    this.displayName = displayName;
  }

  
  /**
   * Capacity of data.
   **/
  @ApiModelProperty(value = "Capacity of data.")
  @JsonProperty("capacity")
  public String getCapacity() {
    return capacity;
  }
  public void setCapacity(String capacity) {
    this.capacity = capacity;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Data {\n");
    
    sb.append("    dataId: ").append(StringUtil.toIndentedString(dataId)).append("\n");
    sb.append("    description: ").append(StringUtil.toIndentedString(description)).append("\n");
    sb.append("    displayName: ").append(StringUtil.toIndentedString(displayName)).append("\n");
    sb.append("    capacity: ").append(StringUtil.toIndentedString(capacity)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
