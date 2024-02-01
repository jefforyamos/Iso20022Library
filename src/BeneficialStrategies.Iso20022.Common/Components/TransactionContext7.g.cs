﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionContext7.  ISO2002 ID# _4Dwf0YNuEeuHqfO1LgkE9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the card payment transaction.
/// </summary>
public partial record TransactionContext7
{
    #nullable enable
    
    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction in accordance with ISO 18245.
    /// </summary>
    public required ISO18245MerchantCategoryCode MerchantCategoryCode { get; init; } 
    /// <summary>
    /// Further details about the merchant that is used in with the merchant category code (MCC) for the particular purchase.
    /// </summary>
    public IsoMax35Text? MerchantCategorySpecificData { get; init; } 
    /// <summary>
    /// Notifies the express consent of the customer for a given service (used in DCC, funds transfers, money lending, etc.).
    /// True: Explicit customer consent obtained
    /// False: Implicit customer consent obtained
    /// </summary>
    public IsoTrueFalseIndicator? CustomerConsent { get; init; } 
    /// <summary>
    /// PIN pad is inoperative.
    /// Default: False - PIN pad is operative or not applicable.
    /// True: PIN pas is inoperative.
    /// </summary>
    public IsoTrueFalseIndicator? PINPadInoperative { get; init; } 
    /// <summary>
    /// Indicate the PIN entry bypass.
    /// </summary>
    public IsoTrueFalseIndicator? PINEntryBypassIndicator { get; init; } 
    /// <summary>
    /// Indicates a chip data fallback.
    /// </summary>
    public IsoTrueFalseIndicator? ICCFallbackIndicator { get; init; } 
    /// <summary>
    /// A code that provides the reason of ICC fallback. 
    /// </summary>
    public ICCFallbackReason1Code? ICCFallbackReasonCode { get; init; } 
    /// <summary>
    /// Other ICC fallback reason code defined at national or private level.
    /// </summary>
    public IsoMax35Text? OtherICCFallbackReasonCode { get; init; } 
    /// <summary>
    /// Indicates a magnetic stripe fallback.
    /// True: Fallback
    /// False: No fallback
    /// Default: False
    /// </summary>
    public IsoTrueFalseIndicator? MagneticStripeFallbackIndicator { get; init; } 
    /// <summary>
    /// Indicates a late presentment as defined by each specific implementation.
    /// True: Transaction was presented late
    /// False: Transaction was not presented late
    /// Default: False
    /// </summary>
    public IsoTrueFalseIndicator? LatePresentmentIndicator { get; init; } 
    /// <summary>
    /// Identifies final authorisation messages for the purpose of managing open-to buy or available balance. 
    /// </summary>
    public IsoTrueFalseIndicator? FinalAuthorisationIndicator { get; init; } 
    /// <summary>
    /// Indicates a deferred delivery as defined by each specific implementation.
    /// True: deferred delivery.
    /// False: Delivery is not identified as deferred.
    /// Default: False.
    /// </summary>
    public IsoTrueFalseIndicator? DeferredDeliveryIndicator { get; init; } 
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
    /// Identifies the transaction initiator.
    /// </summary>
    public TransactionInitiator1Code? TransactionInitiator { get; init; } 
    /// <summary>
    /// Indicates that the consumer authentication process is temporarily unavailable in the acceptance, acquirer or agent environment for this request.  It does not indicate an outage in the issuer processing domain (including agents acting on behalf of the issuer).
    /// </summary>
    public IsoTrueFalseIndicator? AuthenticationOutageIndicator { get; init; } 
    /// <summary>
    /// Card programme or brand related to the transaction.
    /// </summary>
    public CardProgramme2? CardProgramme { get; init; } 
    /// <summary>
    /// Contains information that identifies or is specific to a transaction jurisdiction.
    /// </summary>
    public Jurisdiction2? Jurisdiction { get; init; } 
    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    public SettlementService3? SettlementService { get; init; } 
    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    public Reconciliation3? Reconciliation { get; init; } 
    /// <summary>
    /// Further detailed information on the exchange rates that have been used in or are related to the transaction.
    /// </summary>
    public ExchangeRateInformation2[] ExchangeRateInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Date the transaction was completed and captured.
    /// ISO 8583 bit 17
    /// </summary>
    public IsoISODate? CaptureDate { get; init; } 
    /// <summary>
    /// The date on which the sale or purchase is expected to occur.
    /// </summary>
    public IsoISODate? DateAnticipated { get; init; } 
    /// <summary>
    /// Additional transaction context data.
    /// </summary>
    public AdditionalData1[] AdditionalData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
