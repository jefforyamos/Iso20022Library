﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteractionTransactionReport3.  ISO2002 ID# _p3uQgS8PEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Report information for one transaction.
/// </summary>
public partial record PointOfInteractionTransactionReport3
     : IIsoXmlSerilizable<PointOfInteractionTransactionReport3>
{
    #nullable enable
    
    /// <summary>
    /// Response for this specific transaction.
    /// </summary>
    public required ResponseType11 Response { get; init; } 
    /// <summary>
    /// Data responded to a Payment request.
    /// </summary>
    public PaymentResponse3? PaymentResponse { get; init; } 
    
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
        writer.WriteStartElement(null, "Rspn", xmlNamespace );
        Response.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PaymentResponse is PaymentResponse3 PaymentResponseValue)
        {
            writer.WriteStartElement(null, "PmtRspn", xmlNamespace );
            PaymentResponseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PointOfInteractionTransactionReport3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
