﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentContext23.  ISO2002 ID# _XMF5cbDIEeaW-9Sj0pzN5A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the transaction is performed (payment and sale).
/// </summary>
public partial record CardPaymentContext23
     : IIsoXmlSerilizable<CardPaymentContext23>
{
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    public required PaymentContext23 PaymentContext { get; init; } 
    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    public SaleContext2? SaleContext { get; init; } 
    
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
        writer.WriteStartElement(null, "PmtCntxt", xmlNamespace );
        PaymentContext.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SaleContext is SaleContext2 SaleContextValue)
        {
            writer.WriteStartElement(null, "SaleCntxt", xmlNamespace );
            SaleContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardPaymentContext23 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
