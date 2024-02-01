﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalInformation12.  ISO2002 ID# _6HUmz5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional specific modification criteria.
/// </summary>
public partial record AdditionalInformation12
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction as known by the account owner. Will be used in a unilateral split to provide the executing party with the account owner identification of each split transaction.
    /// </summary>
    public IsoRestrictedFINXMax16Text? AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Type of instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    public ClassificationType33Choice_? ClassificationType { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount30? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Identification of the financial instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Quantity of financial instrument concerned by the settlement condition modification request.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? Quantity { get; init; } 
    /// <summary>
    /// Date/time when the request should take effect.
    /// </summary>
    public DateAndDateTimeChoice_? EffectiveDate { get; init; } 
    /// <summary>
    /// Date/time when the request should cease to be in effect.
    /// </summary>
    public DateAndDateTimeChoice_? ExpiryDate { get; init; } 
    /// <summary>
    /// Date/time of the release.
    /// </summary>
    public DateAndDateTimeChoice_? CutOffDate { get; init; } 
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    public PartyIdentification111? Investor { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    public PartyIdentificationAndAccount146? DeliveringParty1 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    public PartyIdentificationAndAccount146? ReceivingParty1 { get; init; } 
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    public ProcessingStatus59Choice_? ProcessingStatus { get; init; } 
    
    #nullable disable
}
