﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityAttributes10.  ISO2002 ID# _PxlM8ZJKEeuAlLVx8pyt3w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tangible items of value to a business.
/// </summary>
public partial record SecurityAttributes10
     : IIsoXmlSerilizable<SecurityAttributes10>
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security.
    /// </summary>
    public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Provides additional details about the financial instrument.
    /// </summary>
    public FinancialInstrument97? FinancialInstrumentType { get; init; } 
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public CommonFinancialInstrumentAttributes10? FinancialInstrumentAttributes { get; init; } 
    
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
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (FinancialInstrumentType is FinancialInstrument97 FinancialInstrumentTypeValue)
        {
            writer.WriteStartElement(null, "FinInstrmTp", xmlNamespace );
            FinancialInstrumentTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentAttributes is CommonFinancialInstrumentAttributes10 FinancialInstrumentAttributesValue)
        {
            writer.WriteStartElement(null, "FinInstrmAttrbts", xmlNamespace );
            FinancialInstrumentAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecurityAttributes10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
