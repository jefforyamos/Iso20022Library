﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionOptionTypeCode.  ISO2002 ID# _bRQP1Np-Ed-ak6NoX_4Aeg_1657166115.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of CA options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bRQP1Np-Ed-ak6NoX_4Aeg_1657166115")]
[Description(@"Specifies the type of CA options.")]
[Derivations(typeof(CorporateActionOptionType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CorporateActionOptionTypeCode
{
    /// <summary>
    /// Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting. If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.
    /// Encoded/decoded by serializers as "ABST".
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_bRQP1dp-Ed-ak6NoX_4Aeg_1772609139")]
    [Description(@"Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting. If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.")]
    Abstain,
    
    /// <summary>
    /// Vote against management.
    /// Encoded/decoded by serializers as "AMGT".
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_bRQP1tp-Ed-ak6NoX_4Aeg_1772609169")]
    [Description(@"Vote against management.")]
    VoteAgainst,
    
    /// <summary>
    /// Combine warrants and bonds or warrants and stock to form unit.
    /// Encoded/decoded by serializers as "ATCH".
    /// </summary>
    [EnumMember(Value = "ATCH")]
    [IsoId("_bRQP19p-Ed-ak6NoX_4Aeg_1772609170")]
    [Description(@"Combine warrants and bonds or warrants and stock to form unit.")]
    Attach,
    
    /// <summary>
    /// Exchange from registered shares into bearer shares.
    /// Encoded/decoded by serializers as "BEAR".
    /// </summary>
    [EnumMember(Value = "BEAR")]
    [IsoId("_bRQP2Np-Ed-ak6NoX_4Aeg_1772609200")]
    [Description(@"Exchange from registered shares into bearer shares.")]
    BearerShareExchange,
    
    /// <summary>
    /// Receive shares issued from the Share Premium Reserve of the company and considered as a capital distribution rather than a disbursement of income, with different tax implications (typically found in Australia).
    /// Encoded/decoded by serializers as "BSPL".
    /// </summary>
    [EnumMember(Value = "BSPL")]
    [IsoId("_bRZZwNp-Ed-ak6NoX_4Aeg_1772609230")]
    [Description(@"Receive shares issued from the Share Premium Reserve of the company and considered as a capital distribution rather than a disbursement of income, with different tax implications (typically found in Australia).")]
    BonusSharePlan,
    
    /// <summary>
    /// Buy additional securities to round up position.
    /// Encoded/decoded by serializers as "BUYA".
    /// </summary>
    [EnumMember(Value = "BUYA")]
    [IsoId("_bRZZwdp-Ed-ak6NoX_4Aeg_1772609231")]
    [Description(@"Buy additional securities to round up position.")]
    BuyUp,
    
    /// <summary>
    /// Election choice includes a combination of both cash and securities.
    /// Encoded/decoded by serializers as "CASE".
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_bRZZwtp-Ed-ak6NoX_4Aeg_1772609261")]
    [Description(@"Election choice includes a combination of both cash and securities.")]
    CashAndSecurities,
    
    /// <summary>
    /// Distribution of cash.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_bRZZw9p-Ed-ak6NoX_4Aeg_1772609292")]
    [Description(@"Distribution of cash.")]
    Cash,
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to exchange securities.
    /// Encoded/decoded by serializers as "CEXC".
    /// </summary>
    [EnumMember(Value = "CEXC")]
    [IsoId("_bRZZxNp-Ed-ak6NoX_4Aeg_1772609314")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to exchange securities.")]
    ConsentAndExchange,
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to tender securities for cash.
    /// Encoded/decoded by serializers as "CTEN".
    /// </summary>
    [EnumMember(Value = "CTEN")]
    [IsoId("_bRZZxdp-Ed-ak6NoX_4Aeg_1772609345")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to tender securities for cash.")]
    ConsentAndTender,
    
    /// <summary>
    /// Vote not to approve the event or proposal.
    /// Encoded/decoded by serializers as "CONN".
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_bRZZxtp-Ed-ak6NoX_4Aeg_1772609571")]
    [Description(@"Vote not to approve the event or proposal.")]
    ConsentDenied,
    
    /// <summary>
    /// Convert underlying securities into other securities, not cash.
    /// Encoded/decoded by serializers as "CONV".
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_bRZZx9p-Ed-ak6NoX_4Aeg_1772609623")]
    [Description(@"Convert underlying securities into other securities, not cash.")]
    Convert,
    
    /// <summary>
    /// Vote to approve the event or proposal.
    /// Encoded/decoded by serializers as "CONY".
    /// </summary>
    [EnumMember(Value = "CONY")]
    [IsoId("_bRZZyNp-Ed-ak6NoX_4Aeg_1772609654")]
    [Description(@"Vote to approve the event or proposal.")]
    ConsentGranted,
    
    /// <summary>
    /// Separate units into individual securities - warrants and bonds, warrants and equity.
    /// Encoded/decoded by serializers as "DETH".
    /// </summary>
    [EnumMember(Value = "DETH")]
    [IsoId("_bRZZydp-Ed-ak6NoX_4Aeg_1772609684")]
    [Description(@"Separate units into individual securities - warrants and bonds, warrants and equity.")]
    Detached,
    
    /// <summary>
    /// Exercise intermediate securities or warrants.
    /// Encoded/decoded by serializers as "EXER".
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_bRjKwNp-Ed-ak6NoX_4Aeg_1773529687")]
    [Description(@"Exercise intermediate securities or warrants.")]
    Exercise,
    
    /// <summary>
    /// Allow event or entitled security to expire.
    /// Encoded/decoded by serializers as "LAPS".
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_bRjKwdp-Ed-ak6NoX_4Aeg_1773529779")]
    [Description(@"Allow event or entitled security to expire.")]
    Lapse,
    
    /// <summary>
    /// Vote with management.
    /// Encoded/decoded by serializers as "MNGT".
    /// </summary>
    [EnumMember(Value = "MNGT")]
    [IsoId("_bRjKwtp-Ed-ak6NoX_4Aeg_1773529810")]
    [Description(@"Vote with management.")]
    VoteWithManagement,
    
    /// <summary>
    /// An option that allows a holder to elect to retain their holding, eg, a putable bond.
    /// Encoded/decoded by serializers as "MPUT".
    /// </summary>
    [EnumMember(Value = "MPUT")]
    [IsoId("_bRjKw9p-Ed-ak6NoX_4Aeg_1773529840")]
    [Description(@"An option that allows a holder to elect to retain their holding, eg, a putable bond.")]
    Retain,
    
    /// <summary>
    /// Option for the account owner not to take part in the event.
    /// Encoded/decoded by serializers as "NOAC".
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_bRjKxNp-Ed-ak6NoX_4Aeg_1773529901")]
    [Description(@"Option for the account owner not to take part in the event.")]
    NoAction,
    
    /// <summary>
    /// In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.
    /// Encoded/decoded by serializers as "OFFR".
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_bRjKxdp-Ed-ak6NoX_4Aeg_1773529932")]
    [Description(@"In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.")]
    ProposedRate,
    
    /// <summary>
    /// Subscribe to more equities than underlying securities position allows.
    /// Encoded/decoded by serializers as "OVER".
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_bRjKxtp-Ed-ak6NoX_4Aeg_1773530241")]
    [Description(@"Subscribe to more equities than underlying securities position allows.")]
    Oversubscribe,
    
    /// <summary>
    /// Issue a proxy card in case of voting.
    /// Encoded/decoded by serializers as "PROX".
    /// </summary>
    [EnumMember(Value = "PROX")]
    [IsoId("_bRjKx9p-Ed-ak6NoX_4Aeg_1773530302")]
    [Description(@"Issue a proxy card in case of voting.")]
    ProxyCard,
    
    /// <summary>
    /// Exchange from bearer shares into registered shares.
    /// Encoded/decoded by serializers as "REGD".
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_bRjKyNp-Ed-ak6NoX_4Aeg_1773530333")]
    [Description(@"Exchange from bearer shares into registered shares.")]
    RegisteredShareExchange,
    
    /// <summary>
    /// Exchange of securities into the Regulation S tranche. Will typically be used in the restricted period, i.e. the period when a party can change its holdings between 144A and REGS.
    /// Encoded/decoded by serializers as "REGS".
    /// </summary>
    [EnumMember(Value = "REGS")]
    [IsoId("_bRjKydp-Ed-ak6NoX_4Aeg_1773530386")]
    [Description(@"Exchange of securities into the Regulation S tranche. Will typically be used in the restricted period, i.e. the period when a party can change its holdings between 144A and REGS.")]
    RegulationsExchange,
    
    /// <summary>
    /// Distribution of securities to holders.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_bRs7wNp-Ed-ak6NoX_4Aeg_1773530695")]
    [Description(@"Distribution of securities to holders.")]
    SecuritiesOption,
    
    /// <summary>
    /// Sell the intermediate securities.
    /// Encoded/decoded by serializers as "SLLE".
    /// </summary>
    [EnumMember(Value = "SLLE")]
    [IsoId("_bRs7wdp-Ed-ak6NoX_4Aeg_1773530757")]
    [Description(@"Sell the intermediate securities.")]
    SellEntitlement,
    
    /// <summary>
    /// Option to give a split instruction, eg, a split voting instruction on a meeting.
    /// Encoded/decoded by serializers as "SPLI".
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_bRs7wtp-Ed-ak6NoX_4Aeg_1773530818")]
    [Description(@"Option to give a split instruction, eg, a split voting instruction on a meeting.")]
    SplitInstruction,
    
    /// <summary>
    /// Exchange of securities into the 144A tranche. Will typically be used in the restricted period, i.e. the period when a party can change its holdings between 144A and REGS.
    /// Encoded/decoded by serializers as "_144A".
    /// </summary>
    [EnumMember(Value = "144A")]
    [IsoId("_bRs7w9p-Ed-ak6NoX_4Aeg_1773530879")]
    [Description(@"Exchange of securities into the 144A tranche. Will typically be used in the restricted period, i.e. the period when a party can change its holdings between 144A and REGS.")]
    Rule144A,
    
    /// <summary>
    /// The account owner is a Non-Qualified Investor.
    /// Encoded/decoded by serializers as "NOQU".
    /// </summary>
    [EnumMember(Value = "NOQU")]
    [IsoId("_bRs7xNp-Ed-ak6NoX_4Aeg_-1352185912")]
    [Description(@"The account owner is a Non-Qualified Investor.")]
    NonQualifiedInvestor,
    
    /// <summary>
    /// Generic corporate action option to be used in case that no other specific code is appropriate.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bRs7xdp-Ed-ak6NoX_4Aeg_-920900071")]
    [Description(@"Generic corporate action option to be used in case that no other specific code is appropriate.")]
    Other,
    
    /// <summary>
    /// The account owner is a Qualified Investor.
    /// Encoded/decoded by serializers as "QINV".
    /// </summary>
    [EnumMember(Value = "QINV")]
    [IsoId("_bRs7xtp-Ed-ak6NoX_4Aeg_-750050641")]
    [Description(@"The account owner is a Qualified Investor.")]
    QualifiedInvestor,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionOptionTypeCodeMetadataExtensions
{
    private static readonly CorporateActionOptionTypeCodeDropdownSource _dropdownSource = new CorporateActionOptionTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionOptionTypeCodeDropdownRow GetMetadata(this CorporateActionOptionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


