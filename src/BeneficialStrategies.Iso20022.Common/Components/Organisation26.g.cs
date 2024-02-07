﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Organisation26.  ISO2002 ID# __V4_MY0VEeWRYffwL7E13A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Merchant performing the transaction.
/// </summary>
public partial record Organisation26
     : IIsoXmlSerilizable<Organisation26>
{
    #nullable enable
    
    /// <summary>
    /// Name of the merchant.
    /// </summary>
    public required IsoMax70Text CommonName { get; init; } 
    /// <summary>
    /// Location of the merchant.
    /// </summary>
    public IsoMax140Text? Address { get; init; } 
    /// <summary>
    /// Country of the merchant.
    /// </summary>
    public required ISO3NumericCountryCode CountryCode { get; init; } 
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    public required IsoMin3Max4Text MerchantCategoryCode { get; init; } 
    /// <summary>
    /// Identifier of the sponsored merchant assigned by the payment facilitator of their acquirer.
    /// </summary>
    public required IsoMax35Text RegisteredIdentifier { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "CmonNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax70Text(CommonName)); // data type Max70Text System.String
        writer.WriteEndElement();
        if (Address is IsoMax140Text AddressValue)
        {
            writer.WriteStartElement(null, "Adr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(AddressValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CtryCd", xmlNamespace );
        writer.WriteValue(CountryCode.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MrchntCtgyCd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMin3Max4Text(MerchantCategoryCode)); // data type Min3Max4Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RegdIdr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(RegisteredIdentifier)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static Organisation26 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
