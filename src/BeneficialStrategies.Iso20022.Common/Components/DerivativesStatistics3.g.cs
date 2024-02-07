﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DerivativesStatistics3.  ISO2002 ID# _NHlf5VfdEeqZr5K1Woax-g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass data validations.
/// </summary>
public partial record DerivativesStatistics3
     : IIsoXmlSerilizable<DerivativesStatistics3>
{
    #nullable enable
    
    /// <summary>
    /// Total number of derivatives submitted by the report submitting entity for the reporting counterparty.
    /// </summary>
    public required StatisticsPerActionType1 TotalSubmitted { get; init; } 
    /// <summary>
    /// Total number of rejected derivatives submitted by the report submitting entity for the reporting counterparty.
    /// </summary>
    public required StatisticsPerActionType1 TotalRejected { get; init; } 
    /// <summary>
    /// Total number of rejected derivatives submitted by the report submitting entity for the reporting counterparty which were then corrected within ten business days.
    /// </summary>
    public required StatisticsPerActionType1 TotalCorrectedRejections { get; init; } 
    /// <summary>
    /// Identification of the most common data field in reported derivatives that has not passed the validation rule.
    /// </summary>
    public required TopReasonsForRejections2 TopRejectionReasons { get; init; } 
    
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
        writer.WriteStartElement(null, "TtlSubmittd", xmlNamespace );
        TotalSubmitted.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TtlRjctd", xmlNamespace );
        TotalRejected.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TtlCrrctdRjctns", xmlNamespace );
        TotalCorrectedRejections.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TopRjctnRsns", xmlNamespace );
        TopRejectionReasons.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static DerivativesStatistics3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
