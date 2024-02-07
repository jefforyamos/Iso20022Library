﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PendingCancellationStatusReason10.  ISO2002 ID# _bw_xgbKjEemux5trsZcCpw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a pending cancellation status.
/// </summary>
public partial record PendingCancellationStatusReason10
     : IIsoXmlSerilizable<PendingCancellationStatusReason10>
{
    #nullable enable
    
    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    public required PendingCancellationReason7Choice_ ReasonCode { get; init; } 
    /// <summary>
    /// Additional information about the pending status.
    /// </summary>
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "RsnCd", xmlNamespace );
        ReasonCode.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalReasonInformation is IsoMax350Text AdditionalReasonInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRsnInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalReasonInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static PendingCancellationStatusReason10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
