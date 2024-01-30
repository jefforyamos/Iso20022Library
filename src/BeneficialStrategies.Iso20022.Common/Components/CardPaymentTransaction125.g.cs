﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction125.  ISO2002 ID# _TSZawXDuEe2MCaKO5AtGsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction information in the completion advice message.
/// </summary>
public partial record CardPaymentTransaction125
{
    #nullable enable
    
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    public IsoTrueFalseIndicator? TransactionCapture { get; init; } 
    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    public CardPaymentServiceType12Code? TransactionType { get; init; } 
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    public CardPaymentServiceType9Code? AdditionalService { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    public CardPaymentServiceType14Code? ServiceAttribute { get; init; } 
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
    public IsoTrueFalseIndicator? CustomerConsent { get; init; } 
    /// <summary>
    /// Specifies the card program proposed by a retailer to a cardholder among a series of payment programmes offered by the retailer.
    /// </summary>
    public IsoMax35Text? CardProgrammeProposed { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the card program actually selected by the cardholder among the ones supported by the retailer and/or the one actually proposed to him.
    /// </summary>
    public IsoMax35Text? CardProgrammeApplied { get; init; } 
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    public CardPaymentTransaction122? OriginalTransaction { get; init; } 
    /// <summary>
    /// Outcome of the transaction at the acceptor.
    /// </summary>
    public required IsoTrueFalseIndicator TransactionSuccess { get; init; } 
    /// <summary>
    /// Notify that a previous transaction has to be reversed if this original transaction has been approved by the acquirer.
    /// </summary>
    public IsoTrueFalseIndicator? Reversal { get; init; } 
    /// <summary>
    /// Indicate that the acceptor has forced the transaction in spite of the authorisation result (online or offline), or incident to complete the transaction.
    /// </summary>
    public IsoTrueFalseIndicator? MerchantOverride { get; init; } 
    /// <summary>
    /// List of incidents during the transaction.
    /// </summary>
    public FailureReason3Code? FailureReason { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    public IsoMax140Text? RecipientTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Interchange information related to the card scheme.
    /// </summary>
    public IsoMax140Text? InterchangeData { get; init; } 
    /// <summary>
    /// Identification, given by the Issuer, of the transaction processed with the cardholder that legitimates this merchant initiated transaction.
    /// </summary>
    public IsoMax140Text? IssuerCITIdentification { get; init; } 
    /// <summary>
    /// Identification, given by the merchant, of the transaction processed with the cardholder that legitimates this merchant initiated transaction.
    /// </summary>
    public IsoMax140Text? MerchantCITIdentification { get; init; } 
    /// <summary>
    /// Details of the transaction.
    /// </summary>
    public required CardPaymentTransactionDetails52 TransactionDetails { get; init; } 
    /// <summary>
    /// Outcome of the authorisation request.
    /// </summary>
    public AuthorisationResult18? AuthorisationResult { get; init; } 
    /// <summary>
    /// Result of the performed verifications for the transaction.
    /// </summary>
    public TransactionVerificationResult4? TransactionVerificationResult { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Merchant information that must be returned unchanged in the response.
    /// </summary>
    public IsoMax70Text? MerchantReferenceData { get; init; } 
    /// <summary>
    /// Information relevant to the account where the money is taken from.
    /// </summary>
    public CardAccount16? AccountFrom { get; init; } 
    /// <summary>
    /// Information relevant to the account where the money is put.
    /// </summary>
    public CardAccount16? AccountTo { get; init; } 
    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    public IsoMax70Text? AdditionalTransactionData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
