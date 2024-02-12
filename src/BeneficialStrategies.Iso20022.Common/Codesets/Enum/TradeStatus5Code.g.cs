﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeStatus5Code.  ISO2002 ID# _csiU4JK1EeKOmdt7wkELkg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_csiU4JK1EeKOmdt7wkELkg")]
[Description(@"Specifies the status of a trade in a central matching and settlement system.")]
[DerivedFrom(typeof(TradeStatusCode))]
public enum TradeStatus5Code
{
    /// <summary>
    /// Trade is invalid.
    /// Encoded/decoded by serializers as "INVA".
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_sFFzQZK1EeKOmdt7wkELkg")]
    [Description(@"Trade is invalid.")]
    Invalid = TradeStatusCode.Invalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is matched.
    /// Encoded/decoded by serializers as "FMTC".
    /// </summary>
    [EnumMember(Value = "FMTC")]
    [IsoId("_sUSF0ZK1EeKOmdt7wkELkg")]
    [Description(@"Trade is matched.")]
    Matched = TradeStatusCode.Matched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is amended.
    /// Encoded/decoded by serializers as "AMUI".
    /// </summary>
    [EnumMember(Value = "AMUI")]
    [IsoId("_sg8o0ZK1EeKOmdt7wkELkg")]
    [Description(@"Trade is amended.")]
    Amended = TradeStatusCode.Amended, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade has been selected for settlement and is pending.
    /// Encoded/decoded by serializers as "SMAP".
    /// </summary>
    [EnumMember(Value = "SMAP")]
    [IsoId("_syY-IZK1EeKOmdt7wkELkg")]
    [Description(@"Trade has been selected for settlement and is pending.")]
    SettlementMaturePending = TradeStatusCode.SettlementMaturePending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is not authorised.
    /// Encoded/decoded by serializers as "NAUT".
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_tgbv4ZK1EeKOmdt7wkELkg")]
    [Description(@"Trade is not authorised.")]
    NotAuthorised = TradeStatusCode.NotAuthorised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is rejected.
    /// Encoded/decoded by serializers as "RJCT".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_uXbCQZK1EeKOmdt7wkELkg")]
    [Description(@"Trade is rejected.")]
    Rejected = TradeStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is rescinded.
    /// Encoded/decoded by serializers as "RSCD".
    /// </summary>
    [EnumMember(Value = "RSCD")]
    [IsoId("_ufxF8ZK1EeKOmdt7wkELkg")]
    [Description(@"Trade is rescinded.")]
    Rescinded = TradeStatusCode.Rescinded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement is complete.
    /// Encoded/decoded by serializers as "STLD".
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_vBJUsZK1EeKOmdt7wkELkg")]
    [Description(@"Settlement is complete.")]
    Settled = TradeStatusCode.Settled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade has been authorised by the settlement member guaranteeing payment.
    /// Encoded/decoded by serializers as "SMAU".
    /// </summary>
    [EnumMember(Value = "SMAU")]
    [IsoId("_x-GOAZK1EeKOmdt7wkELkg")]
    [Description(@"Trade has been authorised by the settlement member guaranteeing payment.")]
    SettlementMemberAuthorised = TradeStatusCode.SettlementMemberAuthorised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade has not been authorised by the settlement member guaranteeing payment.
    /// Encoded/decoded by serializers as "SMNA".
    /// </summary>
    [EnumMember(Value = "SMNA")]
    [IsoId("_yVCuYZK1EeKOmdt7wkELkg")]
    [Description(@"Trade has not been authorised by the settlement member guaranteeing payment.")]
    SettlementMemberNotAuthorised = TradeStatusCode.SettlementMemberNotAuthorised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade has been split into subtrades for settlement efficiency.
    /// Encoded/decoded by serializers as "SPLI".
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_yva9QZK1EeKOmdt7wkELkg")]
    [Description(@"Trade has been split into subtrades for settlement efficiency.")]
    Split = TradeStatusCode.Split, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade has been marked not ready for settlement.
    /// Encoded/decoded by serializers as "SUSP".
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_zVamQZK1EeKOmdt7wkELkg")]
    [Description(@"Trade has been marked not ready for settlement.")]
    Suspended = TradeStatusCode.Suspended, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade is unmatched.
    /// Encoded/decoded by serializers as "UMTC".
    /// </summary>
    [EnumMember(Value = "UMTC")]
    [IsoId("_zofTQZK1EeKOmdt7wkELkg")]
    [Description(@"Trade is unmatched.")]
    Unmatched = TradeStatusCode.Unmatched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade has been selected for settlement.
    /// Encoded/decoded by serializers as "SMAT".
    /// </summary>
    [EnumMember(Value = "SMAT")]
    [IsoId("_JAhRweKMEeKM3LYZSgb7xw")]
    [Description(@"Trade has been selected for settlement.")]
    SettlementMature = TradeStatusCode.SettlementMature, // same ordinal as derivation source for type conversions
    
}
