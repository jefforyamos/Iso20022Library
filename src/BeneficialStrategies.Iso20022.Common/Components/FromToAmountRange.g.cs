﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FromToAmountRange.  ISO2002 ID# _PVH1A9p-Ed-ak6NoX_4Aeg_-149353967.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of amount values.
/// </summary>
public partial record FromToAmountRange
     : IIsoXmlSerilizable<FromToAmountRange>
{
    #nullable enable
    
    /// <summary>
    /// Lower boundary of a range of amount values.
    /// </summary>
    public required AmountRangeBoundary1 FromAmount { get; init; } 
    /// <summary>
    /// Upper boundary of a range of amount values.
    /// </summary>
    public required AmountRangeBoundary1 ToAmount { get; init; } 
    
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
        writer.WriteStartElement(null, "FrAmt", xmlNamespace );
        FromAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ToAmt", xmlNamespace );
        ToAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static FromToAmountRange Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
