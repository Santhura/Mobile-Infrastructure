package io.swagger.client.model;

import io.swagger.client.StringUtil;
import io.swagger.client.model.Activity;
import java.util.*;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-02T19:09:28.730Z")
public class Activities   {
  
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
    
    sb.append("    offset: ").append(StringUtil.toIndentedString(offset)).append("\n");
    sb.append("    limit: ").append(StringUtil.toIndentedString(limit)).append("\n");
    sb.append("    count: ").append(StringUtil.toIndentedString(count)).append("\n");
    sb.append("    history: ").append(StringUtil.toIndentedString(history)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
