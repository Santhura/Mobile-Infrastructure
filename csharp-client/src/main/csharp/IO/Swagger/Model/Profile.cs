using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Profile {
    
    /// <summary>
    /// First name of the Uber user.
    /// </summary>
    /// <value>First name of the Uber user.</value>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    public string FirstName { get; set; }

    
    /// <summary>
    /// Last name of the Uber user.
    /// </summary>
    /// <value>Last name of the Uber user.</value>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    public string LastName { get; set; }

    
    /// <summary>
    /// Email address of the Uber user
    /// </summary>
    /// <value>Email address of the Uber user</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    public string Email { get; set; }

    
    /// <summary>
    /// Image URL of the Uber user.
    /// </summary>
    /// <value>Image URL of the Uber user.</value>
    [DataMember(Name="picture", EmitDefaultValue=false)]
    public string Picture { get; set; }

    
    /// <summary>
    /// Promo code of the Uber user.
    /// </summary>
    /// <value>Promo code of the Uber user.</value>
    [DataMember(Name="promo_code", EmitDefaultValue=false)]
    public string PromoCode { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Profile {\n");
      
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      
      sb.Append("  Email: ").Append(Email).Append("\n");
      
      sb.Append("  Picture: ").Append(Picture).Append("\n");
      
      sb.Append("  PromoCode: ").Append(PromoCode).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
