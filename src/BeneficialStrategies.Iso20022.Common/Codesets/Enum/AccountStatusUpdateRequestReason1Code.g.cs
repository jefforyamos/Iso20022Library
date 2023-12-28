﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountStatusUpdateRequestReason1Code.  ISO2002 ID# _OJzv4Hi9EeaRm5xIK6nGuQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Sepcifes the reason for a request for a change to an account status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OJzv4Hi9EeaRm5xIK6nGuQ")]
[Description(@"Sepcifes the reason for a request for a change to an account status.")]
[DerivedFrom(typeof(AccountStatusUpdateRequestReasonCode))]
public enum AccountStatusUpdateRequestReason1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountClosureInstructionError".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cw_7YXjAEeaRm5xIK6nGuQ")]
    [Description(@"??")]
    AccountClosureInstructionError,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountStatusUpdateRequestReason1CodeMetadataExtensions
{
    private static readonly AccountStatusUpdateRequestReason1CodeDropdownSource _dropdownSource = new AccountStatusUpdateRequestReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountStatusUpdateRequestReason1CodeDropdownRow GetMetadata(this AccountStatusUpdateRequestReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


