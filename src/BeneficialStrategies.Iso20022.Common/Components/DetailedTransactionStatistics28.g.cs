﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedTransactionStatistics28.  ISO2002 ID# _x4xX8VyGEe24CqbZJK5XxA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about reported derivatives and reported derivatives with outliers.
/// </summary>
public partial record DetailedTransactionStatistics28
     : IIsoXmlSerilizable<DetailedTransactionStatistics28>
{
    #nullable enable
    
    /// <summary>
    /// Number of reported derivatives.
    /// </summary>
    public required IsoNumber NumberOfDerivativesReported { get; init; } 
    /// <summary>
    /// Number of reported derivatives with outliers.
    /// </summary>
    public required IsoNumber NumberOfDerivativesReportedWithOutliers { get; init; } 
    /// <summary>
    /// Details of abnormal values.
    /// </summary>
    public AbnormalValuesData4? Warnings { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _x5wPZVyGEe24CqbZJK5XxA
    
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
        writer.WriteStartElement(null, "NbOfDerivsRptd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoNumber(NumberOfDerivativesReported)); // data type Number System.UInt64
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NbOfDerivsRptdWthOtlrs", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoNumber(NumberOfDerivativesReportedWithOutliers)); // data type Number System.UInt64
        writer.WriteEndElement();
        // Not sure how to serialize Warnings, multiplicity Unknown
    }
    public static DetailedTransactionStatistics28 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
