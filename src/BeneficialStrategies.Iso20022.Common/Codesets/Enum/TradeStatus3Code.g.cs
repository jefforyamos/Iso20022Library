﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeStatus3Code.  ISO2002 ID# _TRnmmAEcEeCQm6a_G2yO_w_525185238.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TRnmmAEcEeCQm6a_G2yO_w_525185238")]
[Description(@"Specifies the status of a trade in a central matching and settlement system.")]
[DerivedFrom(typeof(TradeStatusCode))]
public enum TradeStatus3Code
{
    /// <summary>
    /// Trade is invalid.
    /// Encoded/decoded by serializers as "INVA".
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_TRnmmQEcEeCQm6a_G2yO_w_-2124514623")]
    [Description(@"Trade is invalid.")]
    Invalid = TradeStatusCode.Invalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is unmatched.
    /// Encoded/decoded by serializers as "UMTC".
    /// </summary>
    [EnumMember(Value = "UMTC")]
    [IsoId("_TRnmmgEcEeCQm6a_G2yO_w_-585726181")]
    [Description(@"Trade is unmatched.")]
    Unmatched = TradeStatusCode.Unmatched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is rescinded.
    /// Encoded/decoded by serializers as "RSCD".
    /// </summary>
    [EnumMember(Value = "RSCD")]
    [IsoId("_TRnmmwEcEeCQm6a_G2yO_w_-1391920767")]
    [Description(@"Trade is rescinded.")]
    Rescinded = TradeStatusCode.Rescinded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is complete.
    /// Encoded/decoded by serializers as "STLD".
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_TRnmnAEcEeCQm6a_G2yO_w_-1213802095")]
    [Description(@"Settlement is complete.")]
    Settled = TradeStatusCode.Settled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is matched.
    /// Encoded/decoded by serializers as "FMTC".
    /// </summary>
    [EnumMember(Value = "FMTC")]
    [IsoId("_TRnmnQEcEeCQm6a_G2yO_w_294069135")]
    [Description(@"Trade is matched.")]
    Matched = TradeStatusCode.Matched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is rejected.
    /// Encoded/decoded by serializers as "RJCT".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_TRnmngEcEeCQm6a_G2yO_w_180230069")]
    [Description(@"Trade is rejected.")]
    Rejected = TradeStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade has been authorised by the settlement member guaranteeing payment.
    /// Encoded/decoded by serializers as "SMAU".
    /// </summary>
    [EnumMember(Value = "SMAU")]
    [IsoId("_TRnmnwEcEeCQm6a_G2yO_w_173185354")]
    [Description(@"Trade has been authorised by the settlement member guaranteeing payment.")]
    SettlementMemberAuthorised = TradeStatusCode.SettlementMemberAuthorised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade has not been authorised by the settlement member guaranteeing payment.
    /// Encoded/decoded by serializers as "SMNA".
    /// </summary>
    [EnumMember(Value = "SMNA")]
    [IsoId("_TRnmoAEcEeCQm6a_G2yO_w_-1014049298")]
    [Description(@"Trade has not been authorised by the settlement member guaranteeing payment.")]
    SettlementMemberNotAuthorised = TradeStatusCode.SettlementMemberNotAuthorised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade has been selected for settlement.
    /// Encoded/decoded by serializers as "SMAT".
    /// </summary>
    [EnumMember(Value = "SMAT")]
    [IsoId("_TRnmoQEcEeCQm6a_G2yO_w_-1159465200")]
    [Description(@"Trade has been selected for settlement.")]
    SettlementMature = TradeStatusCode.SettlementMature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade has been split into subtrades for settlement efficiency.
    /// Encoded/decoded by serializers as "SPLI".
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_TRxXkAEcEeCQm6a_G2yO_w_-1058596210")]
    [Description(@"Trade has been split into subtrades for settlement efficiency.")]
    Split = TradeStatusCode.Split, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade has been marked not ready for settlement.
    /// Encoded/decoded by serializers as "SUSP".
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_TRxXkQEcEeCQm6a_G2yO_w_1842556854")]
    [Description(@"Trade has been marked not ready for settlement.")]
    Suspended = TradeStatusCode.Suspended, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is not authorised.
    /// Encoded/decoded by serializers as "NAUT".
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_TRxXkgEcEeCQm6a_G2yO_w_1517398805")]
    [Description(@"Trade is not authorised.")]
    NotAuthorised = TradeStatusCode.NotAuthorised, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeStatus3CodeMetadataExtensions
{
    private static readonly TradeStatus3CodeDropdownSource _dropdownSource = new TradeStatus3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeStatus3CodeDropdownRow GetMetadata(this TradeStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


