﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentInvoice1.  ISO2002 ID# _YJ1FgDD0EeO9waS4ina8CA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed invoice data.
/// </summary>
public partial record CardPaymentInvoice1
     : IIsoXmlSerilizable<CardPaymentInvoice1>
{
    #nullable enable
    
    /// <summary>
    /// General data relevant to the main body of the invoice such as date of issue, currency code and identification number.
    /// </summary>
    public required InvoiceHeader1 InvoiceHeader { get; init; } 
    /// <summary>
    /// Contractual details related to the agreement between parties.
    /// </summary>
    public required TradeAgreement6 TradeAgreement { get; init; } 
    /// <summary>
    /// Supply chain shipping arrangements for delivery of invoiced products and/or services.
    /// </summary>
    public required TradeDelivery1 TradeDelivery { get; init; } 
    /// <summary>
    /// Unit of information showing the related provision of products and/or services and monetary summations reported as a discrete line items.
    /// </summary>
    public LineItem10? LineItem { get; init; } 
    
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
        writer.WriteStartElement(null, "InvcHdr", xmlNamespace );
        InvoiceHeader.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TradAgrmt", xmlNamespace );
        TradeAgreement.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TradDlvry", xmlNamespace );
        TradeDelivery.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (LineItem is LineItem10 LineItemValue)
        {
            writer.WriteStartElement(null, "LineItm", xmlNamespace );
            LineItemValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardPaymentInvoice1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
