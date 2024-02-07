﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntentToPay2.  ISO2002 ID# _9-CfYRVaEeOCqpkCrPgk4g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of an intention to pay based on purchase orders or commercial invoice.
/// </summary>
public partial record IntentToPay2
     : IIsoXmlSerilizable<IntentToPay2>
{
    #nullable enable
    
    /// <summary>
    /// Specifies if breakdown is by purchase order or commercial invoice.
    /// </summary>
    public required BreakDown1Choice_ Breakdown { get; init; } 
    /// <summary>
    /// Date at which the payment would be effected.
    /// </summary>
    public required IsoISODate ExpectedPaymentDate { get; init; } 
    /// <summary>
    /// Specifies the beneficiary's account information.
    /// </summary>
    public SettlementTerms3? SettlementTerms { get; init; } 
    
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
        writer.WriteStartElement(null, "Brkdwn", xmlNamespace );
        Breakdown.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "XpctdPmtDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(ExpectedPaymentDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (SettlementTerms is SettlementTerms3 SettlementTermsValue)
        {
            writer.WriteStartElement(null, "SttlmTerms", xmlNamespace );
            SettlementTermsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static IntentToPay2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
