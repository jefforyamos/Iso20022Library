﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionOption6Code.  ISO2002 ID# _bMfEldp-Ed-ak6NoX_4Aeg_-663351235.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of corporate action options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bMfEldp-Ed-ak6NoX_4Aeg_-663351235")]
[Description(@"Specifies the type of corporate action options.")]
[DerivedFrom(typeof(CorporateActionOptionCode))]
public enum CorporateActionOption6Code
{
    /// <summary>
    /// Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.
    /// Encoded/decoded by serializers as "ABST".
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_bMfEltp-Ed-ak6NoX_4Aeg_-663351217")]
    [Description(@"Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.")]
    Abstain = CorporateActionOptionCode.Abstain, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote against management.
    /// Encoded/decoded by serializers as "AMGT".
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_bMfEl9p-Ed-ak6NoX_4Aeg_-663351200")]
    [Description(@"Vote against management.")]
    VoteAgainstManagement = CorporateActionOptionCode.VoteAgainstManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia).
    /// Encoded/decoded by serializers as "BSPL".
    /// </summary>
    [EnumMember(Value = "BSPL")]
    [IsoId("_bMfEmNp-Ed-ak6NoX_4Aeg_-663351183")]
    [Description(@"Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia).")]
    BonusSharePlan = CorporateActionOptionCode.BonusSharePlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Buy additional securities to round up position.
    /// Encoded/decoded by serializers as "BUYA".
    /// </summary>
    [EnumMember(Value = "BUYA")]
    [IsoId("_bMoOgNp-Ed-ak6NoX_4Aeg_-663351182")]
    [Description(@"Buy additional securities to round up position.")]
    BuyUp = CorporateActionOptionCode.BuyUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option to choose between different security and cash options.
    /// Encoded/decoded by serializers as "CASE".
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_bMoOgdp-Ed-ak6NoX_4Aeg_-663351165")]
    [Description(@"Option to choose between different security and cash options.")]
    CashAndSecurity = CorporateActionOptionCode.CashAndSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option to choose cash.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_bMoOgtp-Ed-ak6NoX_4Aeg_-663351164")]
    [Description(@"Option to choose cash.")]
    Cash = CorporateActionOptionCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to exchange securities.
    /// Encoded/decoded by serializers as "CEXC".
    /// </summary>
    [EnumMember(Value = "CEXC")]
    [IsoId("_bMoOg9p-Ed-ak6NoX_4Aeg_-663350857")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to exchange securities.")]
    ConsentAndExchange = CorporateActionOptionCode.ConsentAndExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote not to approve the event or proposal.
    /// Encoded/decoded by serializers as "CONN".
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_bMoOhNp-Ed-ak6NoX_4Aeg_-663350832")]
    [Description(@"Vote not to approve the event or proposal.")]
    ConsentDenied = CorporateActionOptionCode.ConsentDenied, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote to approve the event or proposal.
    /// Encoded/decoded by serializers as "CONY".
    /// </summary>
    [EnumMember(Value = "CONY")]
    [IsoId("_bMoOhdp-Ed-ak6NoX_4Aeg_-663350815")]
    [Description(@"Vote to approve the event or proposal.")]
    ConsentGranted = CorporateActionOptionCode.ConsentGranted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to tender securities for cash.
    /// Encoded/decoded by serializers as "CTEN".
    /// </summary>
    [EnumMember(Value = "CTEN")]
    [IsoId("_bMoOhtp-Ed-ak6NoX_4Aeg_-663350814")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to tender securities for cash.")]
    ConsentAndTender = CorporateActionOptionCode.ConsentAndTender, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exercise intermediate securities or warrants.
    /// Encoded/decoded by serializers as "EXER".
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_bMoOh9p-Ed-ak6NoX_4Aeg_-663350797")]
    [Description(@"Exercise intermediate securities or warrants.")]
    Exercise = CorporateActionOptionCode.Exercise, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allow event or entitled security to expire.
    /// Encoded/decoded by serializers as "LAPS".
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_bMoOiNp-Ed-ak6NoX_4Aeg_-663350796")]
    [Description(@"Allow event or entitled security to expire.")]
    Lapse = CorporateActionOptionCode.Lapse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mark down the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).
    /// Encoded/decoded by serializers as "MKDW".
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_bMoOidp-Ed-ak6NoX_4Aeg_-663350780")]
    [Description(@"Mark down the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).")]
    MarkDown = CorporateActionOptionCode.MarkDown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mark up the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).
    /// Encoded/decoded by serializers as "MKUP".
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_bMx_gNp-Ed-ak6NoX_4Aeg_-663350779")]
    [Description(@"Mark up the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).")]
    MarkUp = CorporateActionOptionCode.MarkUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote with management.
    /// Encoded/decoded by serializers as "MNGT".
    /// </summary>
    [EnumMember(Value = "MNGT")]
    [IsoId("_bMx_gdp-Ed-ak6NoX_4Aeg_-663350762")]
    [Description(@"Vote with management.")]
    VoteWithManagement = CorporateActionOptionCode.VoteWithManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option that allows a holder to elect to retain their holding, for example, a putable bond.
    /// Encoded/decoded by serializers as "MPUT".
    /// </summary>
    [EnumMember(Value = "MPUT")]
    [IsoId("_bMx_gtp-Ed-ak6NoX_4Aeg_-663350761")]
    [Description(@"Option that allows a holder to elect to retain their holding, for example, a putable bond.")]
    Retain = CorporateActionOptionCode.Retain, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters' rights.
    /// Encoded/decoded by serializers as "NOAC".
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_bMx_g9p-Ed-ak6NoX_4Aeg_-663350737")]
    [Description(@"Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters' rights.")]
    NoAction = CorporateActionOptionCode.NoAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is a non-qualified investor.
    /// Encoded/decoded by serializers as "NOQU".
    /// </summary>
    [EnumMember(Value = "NOQU")]
    [IsoId("_bMx_hNp-Ed-ak6NoX_4Aeg_-663350736")]
    [Description(@"Account owner is a non-qualified investor.")]
    NonQualifiedInvestor = CorporateActionOptionCode.NonQualifiedInvestor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.
    /// Encoded/decoded by serializers as "OFFR".
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_bMx_hdp-Ed-ak6NoX_4Aeg_-663350720")]
    [Description(@"In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.")]
    ProposedRate = CorporateActionOptionCode.ProposedRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Generic corporate action option to be used in case that no other specific code is appropriate.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bMx_htp-Ed-ak6NoX_4Aeg_-663350719")]
    [Description(@"Generic corporate action option to be used in case that no other specific code is appropriate.")]
    Other = CorporateActionOptionCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Subscribe to more equities than underlying securities position allows.
    /// Encoded/decoded by serializers as "OVER".
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_bMx_h9p-Ed-ak6NoX_4Aeg_-663350702")]
    [Description(@"Subscribe to more equities than underlying securities position allows.")]
    Oversubscribe = CorporateActionOptionCode.Oversubscribe, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issue a proxy card in case of voting.
    /// Encoded/decoded by serializers as "PROX".
    /// </summary>
    [EnumMember(Value = "PROX")]
    [IsoId("_bMx_iNp-Ed-ak6NoX_4Aeg_-663350701")]
    [Description(@"Issue a proxy card in case of voting.")]
    ProxyCard = CorporateActionOptionCode.ProxyCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is a qualified investor.
    /// Encoded/decoded by serializers as "QINV".
    /// </summary>
    [EnumMember(Value = "QINV")]
    [IsoId("_bMx_idp-Ed-ak6NoX_4Aeg_-663350677")]
    [Description(@"Account owner is a qualified investor.")]
    QualifiedInvestor = CorporateActionOptionCode.QualifiedInvestor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of securities to holders.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_bMx_itp-Ed-ak6NoX_4Aeg_-663350676")]
    [Description(@"Distribution of securities to holders.")]
    Security = CorporateActionOptionCode.Security, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sell the intermediate securities.
    /// Encoded/decoded by serializers as "SLLE".
    /// </summary>
    [EnumMember(Value = "SLLE")]
    [IsoId("_bM7wgNp-Ed-ak6NoX_4Aeg_-663350660")]
    [Description(@"Sell the intermediate securities.")]
    SellEntitlement = CorporateActionOptionCode.SellEntitlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option to give a split instruction, for example, a split voting instruction on a meeting.
    /// Encoded/decoded by serializers as "SPLI".
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_bM7wgdp-Ed-ak6NoX_4Aeg_-663350659")]
    [Description(@"Option to give a split instruction, for example, a split voting instruction on a meeting.")]
    SplitInstruction = CorporateActionOptionCode.SplitInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax instruction.
    /// Encoded/decoded by serializers as "TAXI".
    /// </summary>
    [EnumMember(Value = "TAXI")]
    [IsoId("_bM7wgtp-Ed-ak6NoX_4Aeg_-663350642")]
    [Description(@"Tax instruction.")]
    TaxInstruction = CorporateActionOptionCode.TaxInstruction, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionOption6CodeMetadataExtensions
{
    private static readonly CorporateActionOption6CodeDropdownSource _dropdownSource = new CorporateActionOption6CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionOption6CodeDropdownRow GetMetadata(this CorporateActionOption6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


