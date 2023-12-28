﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionOption17Code.  ISO2002 ID# _pUnToe35Eeqc-LCjwLsUVg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of corporate action options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pUnToe35Eeqc-LCjwLsUVg")]
[Description(@"Specifies the type of corporate action options.")]
[DerivedFrom(typeof(CorporateActionOptionCode))]
public enum CorporateActionOption17Code
{
    /// <summary>
    /// Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.
    /// Encoded/decoded by serializers as "Abstain".
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_qBF_Ie35Eeqc-LCjwLsUVg")]
    [Description(@"Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.")]
    Abstain,
    
    /// <summary>
    /// Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia).
    /// Encoded/decoded by serializers as "BonusSharePlan".
    /// </summary>
    [EnumMember(Value = "BSPL")]
    [IsoId("_qBF_I-35Eeqc-LCjwLsUVg")]
    [Description(@"Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia).")]
    BonusSharePlan,
    
    /// <summary>
    /// Buy additional securities to round up position.
    /// Encoded/decoded by serializers as "BuyUp".
    /// </summary>
    [EnumMember(Value = "BUYA")]
    [IsoId("_qBF_Je35Eeqc-LCjwLsUVg")]
    [Description(@"Buy additional securities to round up position.")]
    BuyUp,
    
    /// <summary>
    /// Option to choose between different security and cash options.
    /// Encoded/decoded by serializers as "CashAndSecurity".
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_qBF_J-35Eeqc-LCjwLsUVg")]
    [Description(@"Option to choose between different security and cash options.")]
    CashAndSecurity,
    
    /// <summary>
    /// Option to choose cash.
    /// Encoded/decoded by serializers as "Cash".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_qBF_Ke35Eeqc-LCjwLsUVg")]
    [Description(@"Option to choose cash.")]
    Cash,
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to exchange securities.
    /// Encoded/decoded by serializers as "ConsentAndExchange".
    /// </summary>
    [EnumMember(Value = "CEXC")]
    [IsoId("_qBF_K-35Eeqc-LCjwLsUVg")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to exchange securities.")]
    ConsentAndExchange,
    
    /// <summary>
    /// Vote not to approve the event or proposal.
    /// Encoded/decoded by serializers as "ConsentDenied".
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_qBF_Le35Eeqc-LCjwLsUVg")]
    [Description(@"Vote not to approve the event or proposal.")]
    ConsentDenied,
    
    /// <summary>
    /// Vote to approve the event or proposal.
    /// Encoded/decoded by serializers as "ConsentGranted".
    /// </summary>
    [EnumMember(Value = "CONY")]
    [IsoId("_qBF_L-35Eeqc-LCjwLsUVg")]
    [Description(@"Vote to approve the event or proposal.")]
    ConsentGranted,
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to tender securities for cash.
    /// Encoded/decoded by serializers as "ConsentAndTender".
    /// </summary>
    [EnumMember(Value = "CTEN")]
    [IsoId("_qBF_Me35Eeqc-LCjwLsUVg")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to tender securities for cash.")]
    ConsentAndTender,
    
    /// <summary>
    /// Exercise intermediate securities or warrants.
    /// Encoded/decoded by serializers as "Exercise".
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_qBF_M-35Eeqc-LCjwLsUVg")]
    [Description(@"Exercise intermediate securities or warrants.")]
    Exercise,
    
    /// <summary>
    /// Allow event or entitled security to expire.
    /// Encoded/decoded by serializers as "Lapse".
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_qBF_Ne35Eeqc-LCjwLsUVg")]
    [Description(@"Allow event or entitled security to expire.")]
    Lapse,
    
    /// <summary>
    /// Mark down the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).
    /// Encoded/decoded by serializers as "MarkDown".
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_qBF_N-35Eeqc-LCjwLsUVg")]
    [Description(@"Mark down the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).")]
    MarkDown,
    
    /// <summary>
    /// Mark up the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).
    /// Encoded/decoded by serializers as "MarkUp".
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_qBF_Oe35Eeqc-LCjwLsUVg")]
    [Description(@"Mark up the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).")]
    MarkUp,
    
    /// <summary>
    /// Option that allows a holder to elect to retain their holding, for example, a putable bond.
    /// Encoded/decoded by serializers as "Retain".
    /// </summary>
    [EnumMember(Value = "MPUT")]
    [IsoId("_qBF_O-35Eeqc-LCjwLsUVg")]
    [Description(@"Option that allows a holder to elect to retain their holding, for example, a putable bond.")]
    Retain,
    
    /// <summary>
    /// Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters' rights.
    /// Encoded/decoded by serializers as "NoAction".
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_qBF_Pe35Eeqc-LCjwLsUVg")]
    [Description(@"Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters' rights.")]
    NoAction,
    
    /// <summary>
    /// Account owner is a non-qualified investor.
    /// Encoded/decoded by serializers as "NonQualifiedInvestor".
    /// </summary>
    [EnumMember(Value = "NOQU")]
    [IsoId("_qBF_P-35Eeqc-LCjwLsUVg")]
    [Description(@"Account owner is a non-qualified investor.")]
    NonQualifiedInvestor,
    
    /// <summary>
    /// In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.
    /// Encoded/decoded by serializers as "ProposedRate".
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_qBF_Qe35Eeqc-LCjwLsUVg")]
    [Description(@"In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.")]
    ProposedRate,
    
    /// <summary>
    /// Generic corporate action option to be used in case that no other specific code is appropriate.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_qBF_Q-35Eeqc-LCjwLsUVg")]
    [Description(@"Generic corporate action option to be used in case that no other specific code is appropriate.")]
    Other,
    
    /// <summary>
    /// Subscribe to more equities than underlying securities position allows.
    /// Encoded/decoded by serializers as "Oversubscribe".
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_qBF_Re35Eeqc-LCjwLsUVg")]
    [Description(@"Subscribe to more equities than underlying securities position allows.")]
    Oversubscribe,
    
    /// <summary>
    /// Account owner is a qualified investor.
    /// Encoded/decoded by serializers as "QualifiedInvestor".
    /// </summary>
    [EnumMember(Value = "QINV")]
    [IsoId("_qBF_R-35Eeqc-LCjwLsUVg")]
    [Description(@"Account owner is a qualified investor.")]
    QualifiedInvestor,
    
    /// <summary>
    /// Distribution of securities to holders.
    /// Encoded/decoded by serializers as "Security".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_qBF_Se35Eeqc-LCjwLsUVg")]
    [Description(@"Distribution of securities to holders.")]
    Security,
    
    /// <summary>
    /// Sell the intermediate securities.
    /// Encoded/decoded by serializers as "SellEntitlement".
    /// </summary>
    [EnumMember(Value = "SLLE")]
    [IsoId("_qBF_S-35Eeqc-LCjwLsUVg")]
    [Description(@"Sell the intermediate securities.")]
    SellEntitlement,
    
    /// <summary>
    /// Tax instruction.
    /// Encoded/decoded by serializers as "TaxInstruction".
    /// </summary>
    [EnumMember(Value = "TAXI")]
    [IsoId("_qBF_Te35Eeqc-LCjwLsUVg")]
    [Description(@"Tax instruction.")]
    TaxInstruction,
    
    /// <summary>
    /// Proceeds not known during election period. The option can result in cash and/or securities.
    /// Encoded/decoded by serializers as "UnknownProceeds".
    /// </summary>
    [EnumMember(Value = "PRUN")]
    [IsoId("_qBF_T-35Eeqc-LCjwLsUVg")]
    [Description(@"Proceeds not known during election period. The option can result in cash and/or securities.")]
    UnknownProceeds,
    
    /// <summary>
    /// Breakdown of beneficial ownership required for withholding tax reclaim event.
    /// Encoded/decoded by serializers as "BeneficialOwnerBreakdownRequest".
    /// </summary>
    [EnumMember(Value = "BOBD")]
    [IsoId("_riPo0e35Eeqc-LCjwLsUVg")]
    [Description(@"Breakdown of beneficial ownership required for withholding tax reclaim event.")]
    BeneficialOwnerBreakdownRequest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionOption17CodeMetadataExtensions
{
    private static readonly CorporateActionOption17CodeDropdownSource _dropdownSource = new CorporateActionOption17CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionOption17CodeDropdownRow GetMetadata(this CorporateActionOption17Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


