﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferUnmatchedStatus.  ISO2002 ID# _U0V2xNp-Ed-ak6NoX_4Aeg_-105274052.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is unmatched.
/// </summary>
public partial record TransferUnmatchedStatus
     : IIsoXmlSerilizable<TransferUnmatchedStatus>
{
    #nullable enable
    
    /// <summary>
    /// Reason for an unmatched status in the report.
    /// </summary>
    public required TransferUnmatchedStatusReason1 Reason { get; init; } 
    /// <summary>
    /// Proprietary identification for a reason of a specific status in the report.
    /// </summary>
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoReason { get; init; } 
    
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
        writer.WriteStartElement(null, "Rsn", xmlNamespace );
        Reason.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DataSrcSchme", xmlNamespace );
        DataSourceScheme.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NoRsn", xmlNamespace );
        writer.WriteValue(NoReason.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static TransferUnmatchedStatus Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
