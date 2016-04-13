using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PagingInfo :  IEquatable<PagingInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagingInfo" /> class.
        /// </summary>
        public PagingInfo()
        {
            
        }

        
        /// <summary>
        /// The current page number. 1-indexed, so the first page is 1 by default. May be omitted if result is empty (because non-existent page was specified or perPage=0 was requested)
        /// </summary>
        /// <value>The current page number. 1-indexed, so the first page is 1 by default. May be omitted if result is empty (because non-existent page was specified or perPage=0 was requested)</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }
  
        
        /// <summary>
        /// Current page size, describes how many items are in each page. Default value is 100. Maximum value is 1000. If perPage value in the request is greater than 1000, the maximum value (1000) is applied
        /// </summary>
        /// <value>Current page size, describes how many items are in each page. Default value is 100. Maximum value is 1000. If perPage value in the request is greater than 1000, the maximum value (1000) is applied</value>
        [DataMember(Name="perPage", EmitDefaultValue=false)]
        public int? PerPage { get; set; }
  
        
        /// <summary>
        /// The zero-based number of the first element on the current page. Omitted if the page is omitted or result is empty
        /// </summary>
        /// <value>The zero-based number of the first element on the current page. Omitted if the page is omitted or result is empty</value>
        [DataMember(Name="pageStart", EmitDefaultValue=false)]
        public int? PageStart { get; set; }
  
        
        /// <summary>
        /// The zero-based index of the last element on the current page. Omitted if the page is omitted or result is empty
        /// </summary>
        /// <value>The zero-based index of the last element on the current page. Omitted if the page is omitted or result is empty</value>
        [DataMember(Name="pageEnd", EmitDefaultValue=false)]
        public int? PageEnd { get; set; }
  
        
        /// <summary>
        /// The total number of pages in a dataset. May be omitted for some resources due to performance reasons
        /// </summary>
        /// <value>The total number of pages in a dataset. May be omitted for some resources due to performance reasons</value>
        [DataMember(Name="totalPages", EmitDefaultValue=false)]
        public int? TotalPages { get; set; }
  
        
        /// <summary>
        /// The total number of elements in a dataset. May be omitted for some resource due to performance reasons
        /// </summary>
        /// <value>The total number of elements in a dataset. May be omitted for some resource due to performance reasons</value>
        [DataMember(Name="totalElements", EmitDefaultValue=false)]
        public int? TotalElements { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PagingInfo {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  PageStart: ").Append(PageStart).Append("\n");
            sb.Append("  PageEnd: ").Append(PageEnd).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PagingInfo);
        }

        /// <summary>
        /// Returns true if PagingInfo instances are equal
        /// </summary>
        /// <param name="obj">Instance of PagingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PagingInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.PerPage == other.PerPage ||
                    this.PerPage != null &&
                    this.PerPage.Equals(other.PerPage)
                ) && 
                (
                    this.PageStart == other.PageStart ||
                    this.PageStart != null &&
                    this.PageStart.Equals(other.PageStart)
                ) && 
                (
                    this.PageEnd == other.PageEnd ||
                    this.PageEnd != null &&
                    this.PageEnd.Equals(other.PageEnd)
                ) && 
                (
                    this.TotalPages == other.TotalPages ||
                    this.TotalPages != null &&
                    this.TotalPages.Equals(other.TotalPages)
                ) && 
                (
                    this.TotalElements == other.TotalElements ||
                    this.TotalElements != null &&
                    this.TotalElements.Equals(other.TotalElements)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Page != null)
                    hash = hash * 57 + this.Page.GetHashCode();
                
                if (this.PerPage != null)
                    hash = hash * 57 + this.PerPage.GetHashCode();
                
                if (this.PageStart != null)
                    hash = hash * 57 + this.PageStart.GetHashCode();
                
                if (this.PageEnd != null)
                    hash = hash * 57 + this.PageEnd.GetHashCode();
                
                if (this.TotalPages != null)
                    hash = hash * 57 + this.TotalPages.GetHashCode();
                
                if (this.TotalElements != null)
                    hash = hash * 57 + this.TotalElements.GetHashCode();
                
                return hash;
            }
        }

    }
}
