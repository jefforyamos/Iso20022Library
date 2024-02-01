﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionContext8.  ISO2002 ID# _2gRB4cVbEeuips4fuphvoQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the card payment transaction
/// </summary>
public partial record TransactionContext8
{
    #nullable enable
    
    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction in accordance with ISO 18245.
    /// </summary>
    public ISO18245MerchantCategoryCode? MerchantCategoryCode { get; init; } 
    /// <summary>
    /// Further details about the merchant that is used in with the merchant category code (MCC) for the particular purchase.
    /// </summary>
    public IsoMax35Text? MerchantCategorySpecificData { get; init; } 
    /// <summary>
    /// Specifies the initiator of the fee collection message. 
    /// </summary>
    public FeeCollectionInitiator1Code? FeeCollectionInitiator { get; init; } 
    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    public TransactionInitiator1Code? TransactionInitiator { get; init; } 
    /// <summary>
    /// Indicates the partial shipment.
    /// </summary>
    public IsoTrueFalseIndicator? PartialShipmentIndicator { get; init; } 
    /// <summary>
    /// Indicates a delayed charge.
    /// </summary>
    public IsoTrueFalseIndicator? DelayedChargesIndicator { get; init; } 
    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee; property was not actually rented. 
    /// </summary>
    public IsoTrueFalseIndicator? NoShowIndicator { get; init; } 
    /// <summary>
    /// Indicates a reauthorisation.
    /// </summary>
    public IsoTrueFalseIndicator? ReauthorisationIndicator { get; init; } 
    /// <summary>
    /// Indicates a resubmission. 
    /// </summary>
    public IsoTrueFalseIndicator? ReSubmissionIndicator { get; init; } 
    /// <summary>
    /// Card programme or brand related to the transaction.
    /// ISO 8583:87 bit 24
    /// </summary>
    public CardProgrammeMode3? CardProgrammeApplied { get; init; } 
    /// <summary>
    /// Contains information that identifies or is specific to a transaction jurisdiction.
    /// </summary>
    public Jurisdiction2? Jurisdiction { get; init; } 
    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    public SettlementService4? SettlementService { get; init; } 
    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    public Reconciliation3? Reconciliation { get; init; } 
    /// <summary>
    /// Additional transaction context data.
    /// </summary>
    public AdditionalData1[] AdditionalData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
