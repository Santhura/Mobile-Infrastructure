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
  public class Error {
    
    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name="code", EmitDefaultValue=false)]
    public int? Code { get; set; }

    
    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    
    /// <summary>
    /// Gets or Sets Fields
    /// </summary>
    [DataMember(Name="fields", EmitDefaultValue=false)]
    public string Fields { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Error {\n");
      
      sb.Append("  Code: ").Append(Code).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  Fields: ").Append(Fields).Append("\n");
      
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
