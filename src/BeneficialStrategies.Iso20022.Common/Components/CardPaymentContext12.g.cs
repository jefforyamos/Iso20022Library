﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentContext12.  ISO2002 ID# _guihcWmIEeS7iYydEtv3Ug.
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
public partial record CardPaymentContext12
     : IIsoXmlSerilizable<CardPaymentContext12>
{
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    public PaymentContext12? PaymentContext { get; init; } 
    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    public SaleContext1? SaleContext { get; init; } 
    
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
        if (PaymentContext is PaymentContext12 PaymentContextValue)
        {
            writer.WriteStartElement(null, "PmtCntxt", xmlNamespace );
            PaymentContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SaleContext is SaleContext1 SaleContextValue)
        {
            writer.WriteStartElement(null, "SaleCntxt", xmlNamespace );
            SaleContextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardPaymentContext12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
