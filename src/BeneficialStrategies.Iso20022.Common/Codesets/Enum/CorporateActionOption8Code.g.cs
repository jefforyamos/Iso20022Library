﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionOption8Code.  ISO2002 ID# _cjvSoQq_EeGFLZ_5tFfOnw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of corporate action options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cjvSoQq_EeGFLZ_5tFfOnw")]
[Description(@"Specifies the type of corporate action options.")]
[DerivedFrom(typeof(CorporateActionOptionCode))]
public enum CorporateActionOption8Code
{
    /// <summary>
    /// Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.
    /// Encoded/decoded by serializers as "Abstain".
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_cjvSpwq_EeGFLZ_5tFfOnw")]
    [Description(@"Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.")]
    Abstain,
    
    /// <summary>
    /// Vote against management.
    /// Encoded/decoded by serializers as "VoteAgainstManagement".
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_cjvSqwq_EeGFLZ_5tFfOnw")]
    [Description(@"Vote against management.")]
    VoteAgainstManagement,
    
    /// <summary>
    /// Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia).
    /// Encoded/decoded by serializers as "BonusSharePlan".
    /// </summary>
    [EnumMember(Value = "BSPL")]
    [IsoId("_cjvSrwq_EeGFLZ_5tFfOnw")]
    [Description(@"Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia).")]
    BonusSharePlan,
    
    /// <summary>
    /// Buy additional securities to round up position.
    /// Encoded/decoded by serializers as "BuyUp".
    /// </summary>
    [EnumMember(Value = "BUYA")]
    [IsoId("_cjvSswq_EeGFLZ_5tFfOnw")]
    [Description(@"Buy additional securities to round up position.")]
    BuyUp,
    
    /// <summary>
    /// Option to choose between different security and cash options.
    /// Encoded/decoded by serializers as "CashAndSecurity".
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_cjvStwq_EeGFLZ_5tFfOnw")]
    [Description(@"Option to choose between different security and cash options.")]
    CashAndSecurity,
    
    /// <summary>
    /// Option to choose cash.
    /// Encoded/decoded by serializers as "Cash".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_cjvSuwq_EeGFLZ_5tFfOnw")]
    [Description(@"Option to choose cash.")]
    Cash,
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to exchange securities.
    /// Encoded/decoded by serializers as "ConsentAndExchange".
    /// </summary>
    [EnumMember(Value = "CEXC")]
    [IsoId("_cjvSvwq_EeGFLZ_5tFfOnw")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to exchange securities.")]
    ConsentAndExchange,
    
    /// <summary>
    /// Vote not to approve the event or proposal.
    /// Encoded/decoded by serializers as "ConsentDenied".
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_cjvSwwq_EeGFLZ_5tFfOnw")]
    [Description(@"Vote not to approve the event or proposal.")]
    ConsentDenied,
    
    /// <summary>
    /// Vote to approve the event or proposal.
    /// Encoded/decoded by serializers as "ConsentGranted".
    /// </summary>
    [EnumMember(Value = "CONY")]
    [IsoId("_cjvSxwq_EeGFLZ_5tFfOnw")]
    [Description(@"Vote to approve the event or proposal.")]
    ConsentGranted,
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to tender securities for cash.
    /// Encoded/decoded by serializers as "ConsentAndTender".
    /// </summary>
    [EnumMember(Value = "CTEN")]
    [IsoId("_cjvSywq_EeGFLZ_5tFfOnw")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to tender securities for cash.")]
    ConsentAndTender,
    
    /// <summary>
    /// Exercise intermediate securities or warrants.
    /// Encoded/decoded by serializers as "Exercise".
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_cjvSzwq_EeGFLZ_5tFfOnw")]
    [Description(@"Exercise intermediate securities or warrants.")]
    Exercise,
    
    /// <summary>
    /// Allow event or entitled security to expire.
    /// Encoded/decoded by serializers as "Lapse".
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_cjvS0wq_EeGFLZ_5tFfOnw")]
    [Description(@"Allow event or entitled security to expire.")]
    Lapse,
    
    /// <summary>
    /// Mark down the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).
    /// Encoded/decoded by serializers as "MarkDown".
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_cjvS1wq_EeGFLZ_5tFfOnw")]
    [Description(@"Mark down the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).")]
    MarkDown,
    
    /// <summary>
    /// Mark up the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).
    /// Encoded/decoded by serializers as "MarkUp".
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_cjvS2wq_EeGFLZ_5tFfOnw")]
    [Description(@"Mark up the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).")]
    MarkUp,
    
    /// <summary>
    /// Vote with management.
    /// Encoded/decoded by serializers as "VoteWithManagement".
    /// </summary>
    [EnumMember(Value = "MNGT")]
    [IsoId("_cjvS3wq_EeGFLZ_5tFfOnw")]
    [Description(@"Vote with management.")]
    VoteWithManagement,
    
    /// <summary>
    /// Option that allows a holder to elect to retain their holding, for example, a putable bond.
    /// Encoded/decoded by serializers as "Retain".
    /// </summary>
    [EnumMember(Value = "MPUT")]
    [IsoId("_cjvS4wq_EeGFLZ_5tFfOnw")]
    [Description(@"Option that allows a holder to elect to retain their holding, for example, a putable bond.")]
    Retain,
    
    /// <summary>
    /// Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters' rights.
    /// Encoded/decoded by serializers as "NoAction".
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_cjvS5wq_EeGFLZ_5tFfOnw")]
    [Description(@"Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters' rights.")]
    NoAction,
    
    /// <summary>
    /// Account owner is a non-qualified investor.
    /// Encoded/decoded by serializers as "NonQualifiedInvestor".
    /// </summary>
    [EnumMember(Value = "NOQU")]
    [IsoId("_cjvS6wq_EeGFLZ_5tFfOnw")]
    [Description(@"Account owner is a non-qualified investor.")]
    NonQualifiedInvestor,
    
    /// <summary>
    /// In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.
    /// Encoded/decoded by serializers as "ProposedRate".
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_cjvS7wq_EeGFLZ_5tFfOnw")]
    [Description(@"In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.")]
    ProposedRate,
    
    /// <summary>
    /// Generic corporate action option to be used in case that no other specific code is appropriate.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_cjvS8wq_EeGFLZ_5tFfOnw")]
    [Description(@"Generic corporate action option to be used in case that no other specific code is appropriate.")]
    Other,
    
    /// <summary>
    /// Subscribe to more equities than underlying securities position allows.
    /// Encoded/decoded by serializers as "Oversubscribe".
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_cjvS9wq_EeGFLZ_5tFfOnw")]
    [Description(@"Subscribe to more equities than underlying securities position allows.")]
    Oversubscribe,
    
    /// <summary>
    /// Issue a proxy card in case of voting.
    /// Encoded/decoded by serializers as "ProxyCard".
    /// </summary>
    [EnumMember(Value = "PROX")]
    [IsoId("_cjvS-wq_EeGFLZ_5tFfOnw")]
    [Description(@"Issue a proxy card in case of voting.")]
    ProxyCard,
    
    /// <summary>
    /// Account owner is a qualified investor.
    /// Encoded/decoded by serializers as "QualifiedInvestor".
    /// </summary>
    [EnumMember(Value = "QINV")]
    [IsoId("_cjvS_wq_EeGFLZ_5tFfOnw")]
    [Description(@"Account owner is a qualified investor.")]
    QualifiedInvestor,
    
    /// <summary>
    /// Distribution of securities to holders.
    /// Encoded/decoded by serializers as "Security".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_cjvTAwq_EeGFLZ_5tFfOnw")]
    [Description(@"Distribution of securities to holders.")]
    Security,
    
    /// <summary>
    /// Sell the intermediate securities.
    /// Encoded/decoded by serializers as "SellEntitlement".
    /// </summary>
    [EnumMember(Value = "SLLE")]
    [IsoId("_cjvTBwq_EeGFLZ_5tFfOnw")]
    [Description(@"Sell the intermediate securities.")]
    SellEntitlement,
    
    /// <summary>
    /// Option to give a split instruction, for example, a split voting instruction on a meeting.
    /// Encoded/decoded by serializers as "SplitInstruction".
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_cjvTCwq_EeGFLZ_5tFfOnw")]
    [Description(@"Option to give a split instruction, for example, a split voting instruction on a meeting.")]
    SplitInstruction,
    
    /// <summary>
    /// Proceeds not known during election period. The option can result in cash and/or securities.
    /// Encoded/decoded by serializers as "UnknownProceeds".
    /// </summary>
    [EnumMember(Value = "PRUN")]
    [IsoId("_dXmYggq_EeGFLZ_5tFfOnw")]
    [Description(@"Proceeds not known during election period. The option can result in cash and/or securities.")]
    UnknownProceeds,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionOption8CodeMetadataExtensions
{
    private static readonly CorporateActionOption8CodeDropdownSource _dropdownSource = new CorporateActionOption8CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionOption8CodeDropdownRow GetMetadata(this CorporateActionOption8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


