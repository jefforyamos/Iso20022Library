﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalInformation7.  ISO2002 ID# _eaw-ReaOEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional specific modification criteria.
/// </summary>
[DataContract]
[XmlType]
public partial record AdditionalInformation7
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction as known by the account owner. Will be used in a unilateral split to provide the executing party with the account owner identification of each split transaction.
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Type of instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [DataMember]
    public ClassificationType1Choice_? ClassificationType { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [DataMember]
    public SecuritiesAccount13? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Identification of the financial instrument involved in the transactions on which the modification request should apply.
    /// </summary>
    [DataMember]
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Quantity of financial instrument concerned by the settlement condition modification request.
    /// </summary>
    [DataMember]
    public FinancialInstrumentQuantity1Choice_? Quantity { get; init; } 
    /// <summary>
    /// Date/time when the request should take effect.
    /// </summary>
    [DataMember]
    public DateAndDateTimeChoice_? EffectiveDate { get; init; } 
    /// <summary>
    /// Date/time when the request should cease to be in effect.
    /// </summary>
    [DataMember]
    public DateAndDateTimeChoice_? ExpiryDate { get; init; } 
    /// <summary>
    /// Date/time of the release.
    /// </summary>
    [DataMember]
    public DateAndDateTimeChoice_? CutOffDate { get; init; } 
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [DataMember]
    public PartyIdentification43Choice_? Investor { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [DataMember]
    public PartyIdentificationAndAccount43? DeliveringParty1 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [DataMember]
    public PartyIdentificationAndAccount43? ReceivingParty1 { get; init; } 
    
    #nullable disable
}
