package io.swagger.model;

import io.swagger.model.Activity;
import java.util.*;

import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JaxRSServerCodegen", date = "2015-12-02T13:06:30.631Z")
public class Activities  {
  
  private Integer offset = null;
  private Integer limit = null;
  private Integer count = null;
  private List<Activity> history = new ArrayList<Activity>();

  
  /**
   * Position in pagination.
   **/
  @ApiModelProperty(value = "Position in pagination.")
  @JsonProperty("offset")
  public Integer getOffset() {
    return offset;
  }
  public void setOffset(Integer offset) {
    this.offset = offset;
  }

  
  /**
   * Number of items to retrieve (100 max).
   **/
  @ApiModelProperty(value = "Number of items to retrieve (100 max).")
  @JsonProperty("limit")
  public Integer getLimit() {
    return limit;
  }
  public void setLimit(Integer limit) {
    this.limit = limit;
  }

  
  /**
   * Total number of items available.
   **/
  @ApiModelProperty(value = "Total number of items available.")
  @JsonProperty("count")
  public Integer getCount() {
    return count;
  }
  public void setCount(Integer count) {
    this.count = count;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  @JsonProperty("history")
  public List<Activity> getHistory() {
    return history;
  }
  public void setHistory(List<Activity> history) {
    this.history = history;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Activities {\n");
    
    sb.append("  offset: ").append(offset).append("\n");
    sb.append("  limit: ").append(limit).append("\n");
    sb.append("  count: ").append(count).append("\n");
    sb.append("  history: ").append(history).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
