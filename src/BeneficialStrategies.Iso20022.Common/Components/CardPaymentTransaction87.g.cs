﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction87.  ISO2002 ID# _C553sdePEeiJyp_aycJaTw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data associated with the transaction during the authorisation.
/// </summary>
public partial record CardPaymentTransaction87
{
    #nullable enable
    
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    public required IsoTrueFalseIndicator TransactionCapture { get; init; } 
    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    public CardPaymentServiceType12Code? TransactionType { get; init; } 
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    public CardPaymentServiceType9Code[] AdditionalService { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; } 
    /// <summary>
    /// Flag indicating processing of the last transaction.
    /// </summary>
    public IsoTrueFalseIndicator? LastTransactionFlag { get; init; } 
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; } 
    /// <summary>
    /// This enables retailers, if they so wish, to clearly indicate whether the consent of the customer was explicitly obtained for a given service instead of being implicitly derived.
    /// </summary>
    public IsoTrueFalseIndicator[] CustomerConsent { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// The card program proposed by a retailer to a cardholder among a series of payment programmes offered by the retailer.
    /// </summary>
    public IsoMax35Text[] CardProgrammeProposed { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// The card program actually selected by the cardholder among the ones supported by the retailer and/or the one actually proposed to him.
    /// </summary>
    public IsoMax35Text? CardProgrammeApplied { get; init; } 
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    public CardPaymentTransaction79? OriginalTransaction { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Details of the transaction.
    /// </summary>
    public required CardPaymentTransactionDetails47 TransactionDetails { get; init; } 
    /// <summary>
    /// Merchant information that must be returned unchanged in the response.
    /// </summary>
    public IsoMax70Text? MerchantReferenceData { get; init; } 
    /// <summary>
    /// Information relevant to the account where the money is taken from.
    /// </summary>
    public CardAccount15? AccountFrom { get; init; } 
    /// <summary>
    /// Information relevant to the account where the money is put.
    /// </summary>
    public CardAccount15? AccountTo { get; init; } 
    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    public IsoMax70Text[] AdditionalTransactionData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
