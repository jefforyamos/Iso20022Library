﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionCancellation3.  ISO2002 ID# _OgdE4SXaEeOFIcNWlDEvdQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate action event cancellation status and reason.
/// </summary>
public partial record CorporateActionCancellation3
     : IIsoXmlSerilizable<CorporateActionCancellation3>
{
    #nullable enable
    
    /// <summary>
    /// Specifies reasons for cancellation of a corporate action event.
    /// </summary>
    public required CorporateActionCancellationReason1Code CancellationReasonCode { get; init; } 
    /// <summary>
    /// Additional information about cancellation of a corporate action event.
    /// </summary>
    public IsoMax140Text? CancellationReason { get; init; } 
    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    public required CorporateActionEventStatus1 ProcessingStatus { get; init; } 
    
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
        writer.WriteStartElement(null, "CxlRsnCd", xmlNamespace );
        writer.WriteValue(CancellationReasonCode.ToString()); // Enum value
        writer.WriteEndElement();
        if (CancellationReason is IsoMax140Text CancellationReasonValue)
        {
            writer.WriteStartElement(null, "CxlRsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(CancellationReasonValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PrcgSts", xmlNamespace );
        ProcessingStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static CorporateActionCancellation3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
