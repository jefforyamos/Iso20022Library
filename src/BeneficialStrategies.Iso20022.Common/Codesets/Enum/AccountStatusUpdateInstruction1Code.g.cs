﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountStatusUpdateInstruction1Code.  ISO2002 ID# _PFBiUHi6EeaRm5xIK6nGuQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account status update instructed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PFBiUHi6EeaRm5xIK6nGuQ")]
[Description(@"Specifies the type of account status update instructed.")]
[DerivedFrom(typeof(AccountStatusUpdateInstructionCode))]
public enum AccountStatusUpdateInstruction1Code
{
    /// <summary>
    /// Account is to be closed.
    /// Encoded/decoded by serializers as "Close".
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_SuwCEXi6EeaRm5xIK6nGuQ")]
    [Description(@"Account is to be closed.")]
    Close,
    
    /// <summary>
    /// Account is to be reactivated, any previous instruction to close the account is rescinded.
    /// Encoded/decoded by serializers as "Reactive".
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_S6f_EXi6EeaRm5xIK6nGuQ")]
    [Description(@"Account is to be reactivated, any previous instruction to close the account is rescinded.")]
    Reactive,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountStatusUpdateInstruction1CodeMetadataExtensions
{
    private static readonly AccountStatusUpdateInstruction1CodeDropdownSource _dropdownSource = new AccountStatusUpdateInstruction1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountStatusUpdateInstruction1CodeDropdownRow GetMetadata(this AccountStatusUpdateInstruction1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


