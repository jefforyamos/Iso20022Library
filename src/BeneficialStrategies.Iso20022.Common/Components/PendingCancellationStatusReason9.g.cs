﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PendingCancellationStatusReason9.  ISO2002 ID# _Y1ol8f0wEeiKOe8GCUL1Lg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the pending cancellation status.
/// </summary>
public partial record PendingCancellationStatusReason9
     : IIsoXmlSerilizable<PendingCancellationStatusReason9>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the cancellation request is pending.
    /// </summary>
    public required PendingCancellationReason6Choice_ ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoRestrictedFINMax210Text? AdditionalReasonInformation { get; init; } 
    
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
        if (AdditionalReasonInformation is IsoRestrictedFINMax210Text AdditionalReasonInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRsnInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINMax210Text(AdditionalReasonInformationValue)); // data type RestrictedFINMax210Text System.String
            writer.WriteEndElement();
        }
    }
    public static PendingCancellationStatusReason9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
