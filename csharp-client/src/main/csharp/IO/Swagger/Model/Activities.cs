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
  public class Activities {
    
    /// <summary>
    /// Position in pagination.
    /// </summary>
    /// <value>Position in pagination.</value>
    [DataMember(Name="offset", EmitDefaultValue=false)]
    public int? Offset { get; set; }

    
    /// <summary>
    /// Number of items to retrieve (100 max).
    /// </summary>
    /// <value>Number of items to retrieve (100 max).</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    public int? Limit { get; set; }

    
    /// <summary>
    /// Total number of items available.
    /// </summary>
    /// <value>Total number of items available.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    public int? Count { get; set; }

    
    /// <summary>
    /// Gets or Sets History
    /// </summary>
    [DataMember(Name="history", EmitDefaultValue=false)]
    public List<Activity> History { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Activities {\n");
      
      sb.Append("  Offset: ").Append(Offset).Append("\n");
      
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      
      sb.Append("  Count: ").Append(Count).Append("\n");
      
      sb.Append("  History: ").Append(History).Append("\n");
      
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
