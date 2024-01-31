﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountUsageTypeCode.  ISO2002 ID# _LjTZABKCEeKj15WxqwlXPw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of usage of the account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LjTZABKCEeKj15WxqwlXPw")]
[Description(@"Specifies the type of usage of the account.")]
[Derivations(typeof(AccountUsageType1Code),typeof(AccountUsageType2Code))]
public enum AccountUsageTypeCode
{
    /// <summary>
    /// Investor.
    /// Encoded/decoded by serializers as "INVE".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_Tv_toBKCEeKj15WxqwlXPw")]
    [Description(@"Investor.")]
    Investor,
    
    /// <summary>
    /// Settlement participant.
    /// Encoded/decoded by serializers as "SETP".
    /// </summary>
    [EnumMember(Value = "SETP")]
    [IsoId("_YImsoBKCEeKj15WxqwlXPw")]
    [Description(@"Settlement participant.")]
    SettlementParticipant,
    
    /// <summary>
    /// Trading participant.
    /// Encoded/decoded by serializers as "TRDP".
    /// </summary>
    [EnumMember(Value = "TRDP")]
    [IsoId("_vsNZ0L-EEeWfsa741pI6WA")]
    [Description(@"Trading participant.")]
    TradingParticipant,
    
    /// <summary>
    /// Issuing participant.
    /// Encoded/decoded by serializers as "ISSP".
    /// </summary>
    [EnumMember(Value = "ISSP")]
    [IsoId("_v5KQsL-EEeWfsa741pI6WA")]
    [Description(@"Issuing participant.")]
    IssuingParticipant,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountUsageTypeCodeMetadataExtensions
{
    private static readonly AccountUsageTypeCodeDropdownSource _dropdownSource = new AccountUsageTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountUsageTypeCodeDropdownRow GetMetadata(this AccountUsageTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


