package io.swagger.client.model;

import io.swagger.client.StringUtil;



import io.swagger.annotations.*;
import com.fasterxml.jackson.annotation.JsonProperty;


@ApiModel(description = "")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2015-12-02T19:09:28.730Z")
public class Profile   {
  
  private String firstName = null;
  private String lastName = null;
  private String email = null;
  private String picture = null;
  private String promoCode = null;

  
  /**
   * First name of the Uber user.
   **/
  @ApiModelProperty(value = "First name of the Uber user.")
  @JsonProperty("first_name")
  public String getFirstName() {
    return firstName;
  }
  public void setFirstName(String firstName) {
    this.firstName = firstName;
  }

  
  /**
   * Last name of the Uber user.
   **/
  @ApiModelProperty(value = "Last name of the Uber user.")
  @JsonProperty("last_name")
  public String getLastName() {
    return lastName;
  }
  public void setLastName(String lastName) {
    this.lastName = lastName;
  }

  
  /**
   * Email address of the Uber user
   **/
  @ApiModelProperty(value = "Email address of the Uber user")
  @JsonProperty("email")
  public String getEmail() {
    return email;
  }
  public void setEmail(String email) {
    this.email = email;
  }

  
  /**
   * Image URL of the Uber user.
   **/
  @ApiModelProperty(value = "Image URL of the Uber user.")
  @JsonProperty("picture")
  public String getPicture() {
    return picture;
  }
  public void setPicture(String picture) {
    this.picture = picture;
  }

  
  /**
   * Promo code of the Uber user.
   **/
  @ApiModelProperty(value = "Promo code of the Uber user.")
  @JsonProperty("promo_code")
  public String getPromoCode() {
    return promoCode;
  }
  public void setPromoCode(String promoCode) {
    this.promoCode = promoCode;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Profile {\n");
    
    sb.append("    firstName: ").append(StringUtil.toIndentedString(firstName)).append("\n");
    sb.append("    lastName: ").append(StringUtil.toIndentedString(lastName)).append("\n");
    sb.append("    email: ").append(StringUtil.toIndentedString(email)).append("\n");
    sb.append("    picture: ").append(StringUtil.toIndentedString(picture)).append("\n");
    sb.append("    promoCode: ").append(StringUtil.toIndentedString(promoCode)).append("\n");
    sb.append("}");
    return sb.toString();
  }
}
