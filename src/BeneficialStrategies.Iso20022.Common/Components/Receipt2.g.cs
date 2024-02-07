﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Receipt2.  ISO2002 ID# _SoDHcZIdEeect698_YsnIA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the request.
/// </summary>
public partial record Receipt2
     : IIsoXmlSerilizable<Receipt2>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the original request message.
    /// </summary>
    public required OriginalMessageAndIssuer1 OriginalMessageIdentification { get; init; } 
    /// <summary>
    /// Identification of the original transaction identification, when the request for which the receipt is generated is a payment transaction.
    /// </summary>
    public PaymentIdentification5Choice_? OriginalPaymentIdentification { get; init; } 
    /// <summary>
    /// Gives the status of the request.
    /// </summary>
    public RequestHandling1? RequestHandling { get; init; } 
    
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
        writer.WriteStartElement(null, "OrgnlMsgId", xmlNamespace );
        OriginalMessageIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OriginalPaymentIdentification is PaymentIdentification5Choice_ OriginalPaymentIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlPmtId", xmlNamespace );
            OriginalPaymentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestHandling is RequestHandling1 RequestHandlingValue)
        {
            writer.WriteStartElement(null, "ReqHdlg", xmlNamespace );
            RequestHandlingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Receipt2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
