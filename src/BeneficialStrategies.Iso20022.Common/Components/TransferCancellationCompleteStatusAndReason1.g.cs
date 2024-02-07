﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferCancellationCompleteStatusAndReason1.  ISO2002 ID# _RQf8mdp-Ed-ak6NoX_4Aeg_2013423795.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the transfer cancellation is complete.
/// </summary>
public partial record TransferCancellationCompleteStatusAndReason1
     : IIsoXmlSerilizable<TransferCancellationCompleteStatusAndReason1>
{
    #nullable enable
    
    /// <summary>
    /// Reason for the transfer cancellation complete status.
    /// </summary>
    public required CancelledStatusReason1Code Reason { get; init; } 
    /// <summary>
    /// Reason for the transfer cancellation complete status.
    /// </summary>
    public required IsoExtended350Code ExtendedReason { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason for the transfer cancellation complete status.
    /// </summary>
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
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
        writer.WriteValue(Reason.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "XtndedRsn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoExtended350Code(ExtendedReason)); // data type Extended350Code System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DataSrcSchme", xmlNamespace );
        DataSourceScheme.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static TransferCancellationCompleteStatusAndReason1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
