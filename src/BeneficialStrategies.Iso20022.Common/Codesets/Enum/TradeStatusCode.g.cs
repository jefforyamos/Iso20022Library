﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeStatusCode.  ISO2002 ID# _YnFIkdp-Ed-ak6NoX_4Aeg_1584669409.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YnFIkdp-Ed-ak6NoX_4Aeg_1584669409")]
[Description(@"Specifies the status of a trade in a central matching and settlement system.")]
public enum TradeStatusCode
{
    /// <summary>
    /// Trade is validated.
    /// </summary>
    [EnumMember(Value = "VALI")]
    [IsoId("_YnFIktp-Ed-ak6NoX_4Aeg_668271251")]
    [Description(@"Trade is validated.")]
    VALI,
    
    /// <summary>
    /// Trade passed regulatory check.
    /// </summary>
    [EnumMember(Value = "REGC")]
    [IsoId("_YnFIk9p-Ed-ak6NoX_4Aeg_-1009437897")]
    [Description(@"Trade passed regulatory check.")]
    REGC,
    
    /// <summary>
    /// Trade is invalid.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_YnFIlNp-Ed-ak6NoX_4Aeg_-967880102")]
    [Description(@"Trade is invalid.")]
    INVA,
    
    /// <summary>
    /// Trade settlement is rejected.
    /// </summary>
    [EnumMember(Value = "SRJC")]
    [IsoId("_YnFIldp-Ed-ak6NoX_4Aeg_-966955204")]
    [Description(@"Trade settlement is rejected.")]
    SRJC,
    
    /// <summary>
    /// Trade is suspended for regulatory reasons.
    /// </summary>
    [EnumMember(Value = "REGS")]
    [IsoId("_YnFIltp-Ed-ak6NoX_4Aeg_-639105106")]
    [Description(@"Trade is suspended for regulatory reasons.")]
    REGS,
    
    /// <summary>
    /// Trade is unmatched.
    /// </summary>
    [EnumMember(Value = "UMTC")]
    [IsoId("_YnFIl9p-Ed-ak6NoX_4Aeg_-596623705")]
    [Description(@"Trade is unmatched.")]
    UMTC,
    
    /// <summary>
    /// Trade is matched.
    /// </summary>
    [EnumMember(Value = "FMTC")]
    [IsoId("_YnFImNp-Ed-ak6NoX_4Aeg_-504270578")]
    [Description(@"Trade is matched.")]
    FMTC,
    
    /// <summary>
    /// Trade is rescinded.
    /// </summary>
    [EnumMember(Value = "RSCD")]
    [IsoId("_YnO5kNp-Ed-ak6NoX_4Aeg_-222599234")]
    [Description(@"Trade is rescinded.")]
    RSCD,
    
    /// <summary>
    /// Settlement is complete.
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_YnO5kdp-Ed-ak6NoX_4Aeg_-191198402")]
    [Description(@"Settlement is complete.")]
    STLD,
    
    /// <summary>
    /// Part, but not all, of a Trade's value has settled, and no further elements of the Trade's value are expected to be settled.
    /// </summary>
    [EnumMember(Value = "PSTL")]
    [IsoId("_YnO5ktp-Ed-ak6NoX_4Aeg_374918978")]
    [Description(@"Part, but not all, of a Trade's value has settled, and no further elements of the Trade's value are expected to be settled.")]
    PSTL,
    
    /// <summary>
    /// Both the Opening and the Valuation details of an NDF trade have been matched with corresponding details of a counterparty's NDF trade.
    /// </summary>
    [EnumMember(Value = "VMTC")]
    [IsoId("_YnO5k9p-Ed-ak6NoX_4Aeg_1197286254")]
    [Description(@"Both the Opening and the Valuation details of an NDF trade have been matched with corresponding details of a counterparty's NDF trade.")]
    VMTC,
    
    /// <summary>
    /// Trade is rejected.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_YnO5lNp-Ed-ak6NoX_4Aeg_-364848834")]
    [Description(@"Trade is rejected.")]
    RJCT,
    
    /// <summary>
    /// Option has matured.
    /// </summary>
    [EnumMember(Value = "OPMA")]
    [IsoId("_YnO5ldp-Ed-ak6NoX_4Aeg_-2125018890")]
    [Description(@"Option has matured.")]
    OPMA,
    
    /// <summary>
    /// Trade has been authorised by the settlement member guaranteeing payment.
    /// </summary>
    [EnumMember(Value = "SMAU")]
    [IsoId("_TXIYsAEcEeCQm6a_G2yO_w_-1476343454")]
    [Description(@"Trade has been authorised by the settlement member guaranteeing payment.")]
    SMAU,
    
    /// <summary>
    /// Trade has not been authorised by the settlement member guaranteeing payment.
    /// </summary>
    [EnumMember(Value = "SMNA")]
    [IsoId("_TXIYsQEcEeCQm6a_G2yO_w_-507682625")]
    [Description(@"Trade has not been authorised by the settlement member guaranteeing payment.")]
    SMNA,
    
    /// <summary>
    /// Trade has been selected for settlement.
    /// </summary>
    [EnumMember(Value = "SMAT")]
    [IsoId("_TXIYsgEcEeCQm6a_G2yO_w_-214067986")]
    [Description(@"Trade has been selected for settlement.")]
    SMAT,
    
    /// <summary>
    /// Trade has been split into subtrades for settlement efficiency.
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_TXIYswEcEeCQm6a_G2yO_w_1116960621")]
    [Description(@"Trade has been split into subtrades for settlement efficiency.")]
    SPLI,
    
    /// <summary>
    /// Trade has been marked not ready for settlement.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_TXIYtAEcEeCQm6a_G2yO_w_1676857510")]
    [Description(@"Trade has been marked not ready for settlement.")]
    SUSP,
    
    /// <summary>
    /// Trade is not authorised.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_TXIYtQEcEeCQm6a_G2yO_w_1108438667")]
    [Description(@"Trade is not authorised.")]
    NAUT,
    
    /// <summary>
    /// Trade is amended.
    /// </summary>
    [EnumMember(Value = "AMUI")]
    [IsoId("_xkKnQL74EeKP7-K7N5UExg_-1620147750")]
    [Description(@"Trade is amended.")]
    AMUI,
    
    /// <summary>
    /// Trade has been selected for settlement and is pending.
    /// </summary>
    [EnumMember(Value = "SMAP")]
    [IsoId("_xkKnQb74EeKP7-K7N5UExg_2039787700")]
    [Description(@"Trade has been selected for settlement and is pending.")]
    SMAP,
    
    /// <summary>
    /// Trade has been netted by the central system.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_21Y18JU-EeaYkf5FCqYMeA")]
    [Description(@"Trade has been netted by the central system.")]
    NETT,
    
    /// <summary>
    /// For NDF trades, the trade is marked as open match when both open confirmations from both parties match.
    /// </summary>
    [EnumMember(Value = "OMTC")]
    [IsoId("_-MaG0JU-EeaYkf5FCqYMeA")]
    [Description(@"For NDF trades, the trade is marked as open match when both open confirmations from both parties match.")]
    OMTC,
    
    /// <summary>
    /// For NDF instructions, if a party has submitted both the open and fix confirmations and the counterparty is yet to submit the open and fix confirmation the instruction is updated to ‘Fix Unmatched’ Status.
    /// </summary>
    [EnumMember(Value = "FUMT")]
    [IsoId("_gZW4UJU_EeaYkf5FCqYMeA")]
    [Description(@"For NDF instructions, if a party has submitted both the open and fix confirmations and the counterparty is yet to submit the open and fix confirmation the instruction is updated to ‘Fix Unmatched’ Status.")]
    FUMT,
    
    /// <summary>
    /// For NDF instructions, open confirmations are matched and the Fix confirmations are not matched.
    /// </summary>
    [EnumMember(Value = "PFIX")]
    [IsoId("_0EPHgJU_EeaYkf5FCqYMeA")]
    [Description(@"For NDF instructions, open confirmations are matched and the Fix confirmations are not matched.")]
    PFIX,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeStatusCodeMetadataExtensions
{
    private static readonly TradeStatusCodeDropdownSource _dropdownSource = new TradeStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeStatusCodeDropdownRow GetMetadata(this TradeStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


