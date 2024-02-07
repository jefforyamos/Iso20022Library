﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentDetails10.  ISO2002 ID# _mKkkMf7xEeCvPoRGOxRobQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reporting per financial instrument.
/// </summary>
public partial record FinancialInstrumentDetails10
     : IIsoXmlSerilizable<FinancialInstrumentDetails10>
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    public FinancialInstrumentAttributes36? FinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Identification of the sub-balance.
    /// </summary>
    public IntraPositionDetails20? SubBalance { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _mKkkS_7xEeCvPoRGOxRobQ
    
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
        if (FinancialInstrumentAttributes is FinancialInstrumentAttributes36 FinancialInstrumentAttributesValue)
        {
            writer.WriteStartElement(null, "FinInstrmAttrbts", xmlNamespace );
            FinancialInstrumentAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize SubBalance, multiplicity Unknown
    }
    public static FinancialInstrumentDetails10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
