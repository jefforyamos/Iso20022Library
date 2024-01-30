﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvoiceLineItem1.  ISO2002 ID# _AQ89wPNBEei4qfiLgRIZBA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Item purchased with the transaction
/// </summary>
public partial record InvoiceLineItem1
{
    #nullable enable
    
    /// <summary>
    /// Invoice date.
    /// </summary>
    public IsoISODate? Date { get; init; } 
    /// <summary>
    /// Invoice order date.
    /// </summary>
    public IsoISODate? OrderDate { get; init; } 
    /// <summary>
    /// Contains the corporate contract number.
    /// </summary>
    public IsoMax70Text? ContractNumber { get; init; } 
    /// <summary>
    /// Shipping date of the product or the date services rendered. 
    /// </summary>
    public IsoISODate? ShippingDate { get; init; } 
    /// <summary>
    /// Rebilling indicator. 
    /// </summary>
    public IsoTrueFalseIndicator? RebillingIndicator { get; init; } 
    /// <summary>
    /// Indicates whether or not the invoice line item represents a medical service.
    /// </summary>
    public IsoTrueFalseIndicator? MedicalServicesIndicator { get; init; } 
    /// <summary>
    /// Contains the health industry number to which the medical services are being shipped (for example, Medical Services ship to Health Industry Number).
    /// </summary>
    public IsoMax50Text? ShipToIndustryCode { get; init; } 
    /// <summary>
    /// Product code of the item.
    /// </summary>
    public IsoMax70Text? ProductCode { get; init; } 
    /// <summary>
    /// Contains a code that identifies the product number qualifier of the product (for example, medical services).
    /// </summary>
    public IsoMax35Text? ProductQualifier { get; init; } 
    /// <summary>
    /// May contain further clarifying data, such as event name, etc.
    /// </summary>
    public IsoMax256Text? Description { get; init; } 
    /// <summary>
    /// Indicates whether the purchase is categorized
    /// as goods or services.
    /// </summary>
    public IsoMax10Text? TypeOfSupply { get; init; } 
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    /// <summary>
    /// Other unit of measure.
    /// </summary>
    public IsoMax35Text? OtherUnitOfMeasure { get; init; } 
    /// <summary>
    /// Contains the price for one unit of the product or service.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? UnitPrice { get; init; } 
    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    public IsoDecimalNumber? ProductQuantity { get; init; } 
    /// <summary>
    /// Total line item amount, inclusive of adjustments and exclusive of taxes.
    /// </summary>
    public Adjustment11? Adjustment { get; init; } 
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    /// <summary>
    /// Cost of the insurance purchased.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    public Tax33? Tax { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the value-added tax (VAT) invoice or tax receipt.
    /// </summary>
    public IsoMax35Text? UniqueVATInvoiceReference { get; init; } 
    /// <summary>
    /// Total amount of line item, inclusive of any applicable adjustments and taxes.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    /// <summary>
    /// Indicates whether or not the line item is a credit amount.
    /// </summary>
    public IsoTrueFalseIndicator? CreditIndicator { get; init; } 
    /// <summary>
    /// Indicates whether or not the line item carries a cost. 
    /// True : Line item does not have any cost associated to the customer.
    /// False : Line item has cost associated to the customer.
    /// </summary>
    public IsoTrueFalseIndicator? ZeroCostToCustomerIndicator { get; init; } 
    /// <summary>
    /// Additional data.
    /// </summary>
    public IsoMax350Text? AdditionalData { get; init; } 
    
    #nullable disable
}
