﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentInstruction13.  ISO2002 ID# _Lss7yxbwEeOy-PlRuFSUzQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator. This instruction may have to be forwarded several times to complete the settlement chain.|.
/// </summary>
public partial record PaymentInstruction13
     : IIsoXmlSerilizable<PaymentInstruction13>
{
    #nullable enable
    
    /// <summary>
    /// Date at which the initiating party requests that the payment instruction be processed. |.
    /// </summary>
    public IsoISODateTime? RequestedExecutionDateTime { get; init; } 
    /// <summary>
    /// Type, or nature, of the payment, for example an express payment.
    /// </summary>
    public PaymentType4Choice_? PaymentType { get; init; } 
    
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
        if (RequestedExecutionDateTime is IsoISODateTime RequestedExecutionDateTimeValue)
        {
            writer.WriteStartElement(null, "ReqdExctnDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(RequestedExecutionDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (PaymentType is PaymentType4Choice_ PaymentTypeValue)
        {
            writer.WriteStartElement(null, "PmtTp", xmlNamespace );
            PaymentTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PaymentInstruction13 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
