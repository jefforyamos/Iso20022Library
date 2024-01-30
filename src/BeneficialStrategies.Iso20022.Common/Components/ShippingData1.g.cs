﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ShippingData1.  ISO2002 ID# _ScxsW_cjEeiW-auGnDPZIw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Shipping or Courier Service delivery. 
/// </summary>
public partial record ShippingData1
{
    #nullable enable
    
    /// <summary>
    /// Contains the invoice number.
    /// </summary>
    public IsoMax70Text? InvoiceNumber { get; init; } 
    /// <summary>
    /// Contains the date and time the electronic invoice was created.
    /// </summary>
    public IsoISODateTime? InvoiceCreationDateTime { get; init; } 
    /// <summary>
    /// Contains a card acceptor designated code for the shipping service provided.
    /// </summary>
    public IsoMax40Text? ServiceDescriptorCode { get; init; } 
    /// <summary>
    /// Contains the amount of any incentives applied to the transaction. 
    /// </summary>
    public IsoImpliedCurrencyAndAmount? IncentiveAmount { get; init; } 
    /// <summary>
    /// Contains the amount of any miscellaneous expenses applicable to the transaction. 
    /// </summary>
    public IsoImpliedCurrencyAndAmount? MiscellaneousExpenses { get; init; } 
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    /// <summary>
    /// Amount of insurance.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    /// <summary>
    /// Contains the net amount of shipping expenses.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? NetAmount { get; init; } 
    /// <summary>
    /// Contains the total tax amount for the entire purchase. 
    /// </summary>
    public Tax33? Tax { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    /// <summary>
    /// Contains the total number of packages being shipped or sent by the service provider.
    /// </summary>
    public IsoMax6NumericText? NumberOfPackages { get; init; } 
    /// <summary>
    /// Contains the details of the package being shipped. 
    /// </summary>
    public ShippingPackage1? Package { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Contains additional shipping data.
    /// </summary>
    public IsoMax350Text? AdditionalData { get; init; } 
    
    #nullable disable
}
