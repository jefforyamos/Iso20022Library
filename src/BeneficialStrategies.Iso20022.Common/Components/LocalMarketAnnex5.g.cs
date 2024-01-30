﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LocalMarketAnnex5.  ISO2002 ID# _VyQSsdATEeuSBa1PsnseFg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
/// </summary>
public partial record LocalMarketAnnex5
{
    #nullable enable
    
    /// <summary>
    /// Country of the local fund order desk.
    /// </summary>
    public CountryCode? Country { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Local entity appointed by the fund, to which orders should be submitted. 
    /// </summary>
    public required OrderDesk1 LocalOrderDesk { get; init; } 
    /// <summary>
    /// Processing characteristics linked to a subscription to the investment fund or alternative/hedge fund.
    /// </summary>
    public ProcessingCharacteristics8? SubscriptionProcessingCharacteristics { get; init; } 
    /// <summary>
    /// Processing characteristics linked to a redemption to the investment fund or alternative/hedge fund.
    /// </summary>
    public ProcessingCharacteristics5? RedemptionProcessingCharacteristics { get; init; } 
    /// <summary>
    /// Processing characteristics linked to a switch of the investment fund or alternative/hedge fund.
    /// </summary>
    public ProcessingCharacteristics6? SwitchProcessingCharacteristics { get; init; } 
    /// <summary>
    /// Account to be used for cash settlement.
    /// </summary>
    public CashAccount205? CashSettlementDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information about the fund order desk.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
