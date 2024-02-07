﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestigationExecutionStatusReason1.  ISO2002 ID# _L5azsCFhEeicwehH70nfgw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the reason for a status on the execution of an investigation.
/// </summary>
public partial record InvestigationExecutionStatusReason1
     : IIsoXmlSerilizable<InvestigationExecutionStatusReason1>
{
    #nullable enable
    
    /// <summary>
    /// Provides the reason why the payment cancellation was rejected.
    /// </summary>
    public PaymentCancellationRejection3Code? Rejected { get; init; } 
    /// <summary>
    /// Provides the reason why the payment cancellation is pending.
    /// </summary>
    public PendingPaymentCancellationReason1Code? Pending { get; init; } 
    
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
        if (Rejected is PaymentCancellationRejection3Code RejectedValue)
        {
            writer.WriteStartElement(null, "Rjctd", xmlNamespace );
            writer.WriteValue(RejectedValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Pending is PendingPaymentCancellationReason1Code PendingValue)
        {
            writer.WriteStartElement(null, "Pdg", xmlNamespace );
            writer.WriteValue(PendingValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static InvestigationExecutionStatusReason1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
