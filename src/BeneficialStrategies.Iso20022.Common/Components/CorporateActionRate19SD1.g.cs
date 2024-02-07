﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate19SD1.  ISO2002 ID# _gCCBwHcYEeGgn5GmpWx6yw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to capture new to old ratio with extra digits.
/// </summary>
public partial record CorporateActionRate19SD1
     : IIsoXmlSerilizable<CorporateActionRate19SD1>
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Ratio expressed as a quotient of high precision quantities.
    /// </summary>
    public required LongQuantityToQuantityRatio2 LongQuantityToQuantity { get; init; } 
    
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
        if (PlaceAndName is IsoMax350Text PlaceAndNameValue)
        {
            writer.WriteStartElement(null, "PlcAndNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(PlaceAndNameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "LngQtyToQty", xmlNamespace );
        LongQuantityToQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static CorporateActionRate19SD1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
