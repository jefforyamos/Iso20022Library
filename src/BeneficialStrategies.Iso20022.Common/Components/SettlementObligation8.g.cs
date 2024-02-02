﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementObligation8.  ISO2002 ID# _71U0BS9dEeS94oXWDaBauA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the settlement obligation.
/// </summary>
[DataContract]
[XmlType]
public partial record SettlementObligation8
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the settlement obligation.
    /// </summary>
    [DataMember]
    public required IsoMax35Text SettlementObligationIdentification { get; init; } 
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [DataMember]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Intended settlement date of the position.
    /// </summary>
    [DataMember]
    public required DateFormat11Choice_ IntendedSettlementDate { get; init; } 
    /// <summary>
    /// Specifies the quantity related to the settlement obligation.
    /// </summary>
    [DataMember]
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    /// <summary>
    /// Provides the total amount to be settled.
    /// </summary>
    [DataMember]
    public required AmountAndDirection27 SettlementAmount { get; init; } 
    /// <summary>
    /// Place at which the security is traded.
    /// </summary>
    [DataMember]
    public required MarketIdentification84 PlaceOfTrade { get; init; } 
    /// <summary>
    /// Provides the trade date.
    /// </summary>
    [DataMember]
    public TradeDate3Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Identifies the trading capacity of seller.
    /// </summary>
    [DataMember]
    public TradingCapacity5Code? TradingCapacity { get; init; } 
    /// <summary>
    /// Specifies the clearing account type.
    /// </summary>
    [DataMember]
    public ClearingAccountType1Code? ClearingAccountType { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [DataMember]
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Clearing member account at the central securities depository.
    /// </summary>
    [DataMember]
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Indicates if the obligation will result in a receive or a delivery of securities.
    /// </summary>
    [DataMember]
    public ReceiveDelivery1Code? SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies the amount to be paid under a specific obligation.
    /// </summary>
    [DataMember]
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Provides details on the parties that are part of the settlement chain.
    /// </summary>
    [DataMember]
    public SettlementParties4Choice_? SettlementParties { get; init; } 
    /// <summary>
    /// Provides additional information about the settlement obligation details.
    /// </summary>
    [DataMember]
    public ValueList<SettlementObligation5> AdditionalSettlementObligationDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
