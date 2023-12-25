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
public enum CorporateActionOptionTypeCode
{
    /// <summary>
    /// Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting. If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_bRQP1dp-Ed-ak6NoX_4Aeg_1772609139")]
    [Description(@"Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting. If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.")]
    ABST,
    
    /// <summary>
    /// Vote against management.
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_bRQP1tp-Ed-ak6NoX_4Aeg_1772609169")]
    [Description(@"Vote against management.")]
    AMGT,
    
    /// <summary>
    /// Combine warrants and bonds or warrants and stock to form unit.
    /// </summary>
    [EnumMember(Value = "ATCH")]
    [IsoId("_bRQP19p-Ed-ak6NoX_4Aeg_1772609170")]
    [Description(@"Combine warrants and bonds or warrants and stock to form unit.")]
    ATCH,
    
    /// <summary>
    /// Exchange from registered shares into bearer shares.
    /// </summary>
    [EnumMember(Value = "BEAR")]
    [IsoId("_bRQP2Np-Ed-ak6NoX_4Aeg_1772609200")]
    [Description(@"Exchange from registered shares into bearer shares.")]
    BEAR,
    
    /// <summary>
    /// Receive shares issued from the Share Premium Reserve of the company and considered as a capital distribution rather than a disbursement of income, with different tax implications (typically found in Australia).
    /// </summary>
    [EnumMember(Value = "BSPL")]
    [IsoId("_bRZZwNp-Ed-ak6NoX_4Aeg_1772609230")]
    [Description(@"Receive shares issued from the Share Premium Reserve of the company and considered as a capital distribution rather than a disbursement of income, with different tax implications (typically found in Australia).")]
    BSPL,
    
    /// <summary>
    /// Buy additional securities to round up position.
    /// </summary>
    [EnumMember(Value = "BUYA")]
    [IsoId("_bRZZwdp-Ed-ak6NoX_4Aeg_1772609231")]
    [Description(@"Buy additional securities to round up position.")]
    BUYA,
    
    /// <summary>
    /// Election choice includes a combination of both cash and securities.
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_bRZZwtp-Ed-ak6NoX_4Aeg_1772609261")]
    [Description(@"Election choice includes a combination of both cash and securities.")]
    CASE,
    
    /// <summary>
    /// Distribution of cash.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_bRZZw9p-Ed-ak6NoX_4Aeg_1772609292")]
    [Description(@"Distribution of cash.")]
    CASH,
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to exchange securities.
    /// </summary>
    [EnumMember(Value = "CEXC")]
    [IsoId("_bRZZxNp-Ed-ak6NoX_4Aeg_1772609314")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to exchange securities.")]
    CEXC,
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to tender securities for cash.
    /// </summary>
    [EnumMember(Value = "CTEN")]
    [IsoId("_bRZZxdp-Ed-ak6NoX_4Aeg_1772609345")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to tender securities for cash.")]
    CTEN,
    
    /// <summary>
    /// Vote not to approve the event or proposal.
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_bRZZxtp-Ed-ak6NoX_4Aeg_1772609571")]
    [Description(@"Vote not to approve the event or proposal.")]
    CONN,
    
    /// <summary>
    /// Convert underlying securities into other securities, not cash.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_bRZZx9p-Ed-ak6NoX_4Aeg_1772609623")]
    [Description(@"Convert underlying securities into other securities, not cash.")]
    CONV,
    
    /// <summary>
    /// Vote to approve the event or proposal.
    /// </summary>
    [EnumMember(Value = "CONY")]
    [IsoId("_bRZZyNp-Ed-ak6NoX_4Aeg_1772609654")]
    [Description(@"Vote to approve the event or proposal.")]
    CONY,
    
    /// <summary>
    /// Separate units into individual securities - warrants and bonds, warrants and equity.
    /// </summary>
    [EnumMember(Value = "DETH")]
    [IsoId("_bRZZydp-Ed-ak6NoX_4Aeg_1772609684")]
    [Description(@"Separate units into individual securities - warrants and bonds, warrants and equity.")]
    DETH,
    
    /// <summary>
    /// Exercise intermediate securities or warrants.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_bRjKwNp-Ed-ak6NoX_4Aeg_1773529687")]
    [Description(@"Exercise intermediate securities or warrants.")]
    EXER,
    
    /// <summary>
    /// Allow event or entitled security to expire.
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_bRjKwdp-Ed-ak6NoX_4Aeg_1773529779")]
    [Description(@"Allow event or entitled security to expire.")]
    LAPS,
    
    /// <summary>
    /// Vote with management.
    /// </summary>
    [EnumMember(Value = "MNGT")]
    [IsoId("_bRjKwtp-Ed-ak6NoX_4Aeg_1773529810")]
    [Description(@"Vote with management.")]
    MNGT,
    
    /// <summary>
    /// An option that allows a holder to elect to retain their holding, eg, a putable bond.
    /// </summary>
    [EnumMember(Value = "MPUT")]
    [IsoId("_bRjKw9p-Ed-ak6NoX_4Aeg_1773529840")]
    [Description(@"An option that allows a holder to elect to retain their holding, eg, a putable bond.")]
    MPUT,
    
    /// <summary>
    /// Option for the account owner not to take part in the event.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_bRjKxNp-Ed-ak6NoX_4Aeg_1773529901")]
    [Description(@"Option for the account owner not to take part in the event.")]
    NOAC,
    
    /// <summary>
    /// In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_bRjKxdp-Ed-ak6NoX_4Aeg_1773529932")]
    [Description(@"In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.")]
    OFFR,
    
    /// <summary>
    /// Subscribe to more equities than underlying securities position allows.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_bRjKxtp-Ed-ak6NoX_4Aeg_1773530241")]
    [Description(@"Subscribe to more equities than underlying securities position allows.")]
    OVER,
    
    /// <summary>
    /// Issue a proxy card in case of voting.
    /// </summary>
    [EnumMember(Value = "PROX")]
    [IsoId("_bRjKx9p-Ed-ak6NoX_4Aeg_1773530302")]
    [Description(@"Issue a proxy card in case of voting.")]
    PROX,
    
    /// <summary>
    /// Exchange from bearer shares into registered shares.
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_bRjKyNp-Ed-ak6NoX_4Aeg_1773530333")]
    [Description(@"Exchange from bearer shares into registered shares.")]
    REGD,
    
    /// <summary>
    /// Exchange of securities into the Regulation S tranche. Will typically be used in the restricted period, i.e. the period when a party can change its holdings between 144A and REGS.
    /// </summary>
    [EnumMember(Value = "REGS")]
    [IsoId("_bRjKydp-Ed-ak6NoX_4Aeg_1773530386")]
    [Description(@"Exchange of securities into the Regulation S tranche. Will typically be used in the restricted period, i.e. the period when a party can change its holdings between 144A and REGS.")]
    REGS,
    
    /// <summary>
    /// Distribution of securities to holders.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_bRs7wNp-Ed-ak6NoX_4Aeg_1773530695")]
    [Description(@"Distribution of securities to holders.")]
    SECU,
    
    /// <summary>
    /// Sell the intermediate securities.
    /// </summary>
    [EnumMember(Value = "SLLE")]
    [IsoId("_bRs7wdp-Ed-ak6NoX_4Aeg_1773530757")]
    [Description(@"Sell the intermediate securities.")]
    SLLE,
    
    /// <summary>
    /// Option to give a split instruction, eg, a split voting instruction on a meeting.
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_bRs7wtp-Ed-ak6NoX_4Aeg_1773530818")]
    [Description(@"Option to give a split instruction, eg, a split voting instruction on a meeting.")]
    SPLI,
    
    /// <summary>
    /// Exchange of securities into the 144A tranche. Will typically be used in the restricted period, i.e. the period when a party can change its holdings between 144A and REGS.
    /// </summary>
    [EnumMember(Value = "144A")]
    [IsoId("_bRs7w9p-Ed-ak6NoX_4Aeg_1773530879")]
    [Description(@"Exchange of securities into the 144A tranche. Will typically be used in the restricted period, i.e. the period when a party can change its holdings between 144A and REGS.")]
    _144A,
    
    /// <summary>
    /// The account owner is a Non-Qualified Investor.
    /// </summary>
    [EnumMember(Value = "NOQU")]
    [IsoId("_bRs7xNp-Ed-ak6NoX_4Aeg_-1352185912")]
    [Description(@"The account owner is a Non-Qualified Investor.")]
    NOQU,
    
    /// <summary>
    /// Generic corporate action option to be used in case that no other specific code is appropriate.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bRs7xdp-Ed-ak6NoX_4Aeg_-920900071")]
    [Description(@"Generic corporate action option to be used in case that no other specific code is appropriate.")]
    OTHR,
    
    /// <summary>
    /// The account owner is a Qualified Investor.
    /// </summary>
    [EnumMember(Value = "QINV")]
    [IsoId("_bRs7xtp-Ed-ak6NoX_4Aeg_-750050641")]
    [Description(@"The account owner is a Qualified Investor.")]
    QINV,
    
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


