﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CommodityDerivate4.  ISO2002 ID# _zeGjUWlHEeaLAKoEUNsD9g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transparency calculation specific details for an commodity derivatives.
/// </summary>
public partial record CommodityDerivate4
     : IIsoXmlSerilizable<CommodityDerivate4>
{
    #nullable enable
    
    /// <summary>
    /// Provides specific information related to commodity derivatives.
    /// </summary>
    public CommodityDerivate2Choice_? ClassSpecific { get; init; } 
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
    
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
        if (ClassSpecific is CommodityDerivate2Choice_ ClassSpecificValue)
        {
            writer.WriteStartElement(null, "ClssSpcfc", xmlNamespace );
            ClassSpecificValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "NtnlCcy", xmlNamespace );
        writer.WriteValue(NotionalCurrency.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static CommodityDerivate4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
