using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DocuSign.eSign.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AddressInformation : IEquatable<AddressInformation>
    {
        
        /// <summary>
        /// The first line of the address.
        /// </summary>
        /// <value>The first line of the address.</value>
        [DataMember(Name="street1", EmitDefaultValue=false)]
        public string Street1 { get; set; }
  
        
        /// <summary>
        /// The second line of the address (optional).
        /// </summary>
        /// <value>The second line of the address (optional).</value>
        [DataMember(Name="street2", EmitDefaultValue=false)]
        public string Street2 { get; set; }
  
        
        /// <summary>
        /// The city associated with the address.
        /// </summary>
        /// <value>The city associated with the address.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
  
        
        /// <summary>
        /// The state or province associated with the address.
        /// </summary>
        /// <value>The state or province associated with the address.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
  
        
        /// <summary>
        /// The zip or postal code associated with the address.
        /// </summary>
        /// <value>The zip or postal code associated with the address.</value>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }
  
        
        /// <summary>
        /// A phone number associated with the address.
        /// </summary>
        /// <value>A phone number associated with the address.</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
  
        
        /// <summary>
        /// A Fax number associated with the address if one is available.
        /// </summary>
        /// <value>A Fax number associated with the address if one is available.</value>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }
  
        
        /// <summary>
        /// Specifies the country associated with the address.
        /// </summary>
        /// <value>Specifies the country associated with the address.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressInformation {\n");
            sb.Append("  Street1: ").Append(Street1).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            
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
            return this.Equals(obj as AddressInformation);
        }

        /// <summary>
        /// Returns true if AddressInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of AddressInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Street1 == other.Street1 ||
                    this.Street1 != null &&
                    this.Street1.Equals(other.Street1)
                ) && 
                (
                    this.Street2 == other.Street2 ||
                    this.Street2 != null &&
                    this.Street2.Equals(other.Street2)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Fax == other.Fax ||
                    this.Fax != null &&
                    this.Fax.Equals(other.Fax)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                
                if (this.Street1 != null)
                    hash = hash * 57 + this.Street1.GetHashCode();
                
                if (this.Street2 != null)
                    hash = hash * 57 + this.Street2.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 57 + this.City.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 57 + this.State.GetHashCode();
                
                if (this.Zip != null)
                    hash = hash * 57 + this.Zip.GetHashCode();
                
                if (this.Phone != null)
                    hash = hash * 57 + this.Phone.GetHashCode();
                
                if (this.Fax != null)
                    hash = hash * 57 + this.Fax.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 57 + this.Country.GetHashCode();
                
                return hash;
            }
        }

    }
}
