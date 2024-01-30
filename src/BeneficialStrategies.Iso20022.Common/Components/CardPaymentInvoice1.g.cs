﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentInvoice1.  ISO2002 ID# _YJ1FgDD0EeO9waS4ina8CA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed invoice data.
/// </summary>
public partial record CardPaymentInvoice1
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
    public LineItem10? LineItem { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
