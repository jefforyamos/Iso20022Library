﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountStatusUpdateRequestReasonCode.  ISO2002 ID# _-snCEHi8EeaRm5xIK6nGuQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for an instruction to change to an account status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-snCEHi8EeaRm5xIK6nGuQ")]
[Description(@"Specifies the reason for an instruction to change to an account status.")]
public enum AccountStatusUpdateRequestReasonCode
{
    /// <summary>
    /// Previous account closure instruction was sent in error.
    /// Encoded/decoded by serializers as "CLOE".
    /// </summary>
    [EnumMember(Value = "CLOE")]
    [IsoId("_BHVYEHi9EeaRm5xIK6nGuQ")]
    [Description(@"Previous account closure instruction was sent in error.")]
    AccountClosureInstructionError,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountStatusUpdateRequestReasonCodeMetadataExtensions
{
    private static readonly AccountStatusUpdateRequestReasonCodeDropdownSource _dropdownSource = new AccountStatusUpdateRequestReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountStatusUpdateRequestReasonCodeDropdownRow GetMetadata(this AccountStatusUpdateRequestReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

