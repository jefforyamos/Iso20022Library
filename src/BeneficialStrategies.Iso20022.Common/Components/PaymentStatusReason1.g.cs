﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentStatusReason1.  ISO2002 ID# _qTFCcfSwEemJpbG3s5kY2A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status reason of the transaction.
/// </summary>
public partial record PaymentStatusReason1
     : IIsoXmlSerilizable<PaymentStatusReason1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    public StatusReason6Choice_? Reason { get; init; } 
    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
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
        if (Reason is StatusReason6Choice_ ReasonValue)
        {
            writer.WriteStartElement(null, "Rsn", xmlNamespace );
            ReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalInformation is IsoMax105Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax105Text(AdditionalInformationValue)); // data type Max105Text System.String
            writer.WriteEndElement();
        }
    }
    public static PaymentStatusReason1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
