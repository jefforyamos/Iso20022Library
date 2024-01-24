﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountStatusUpdateInstructionCode.  ISO2002 ID# _-lU1sHi5EeaRm5xIK6nGuQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of account status update instructed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-lU1sHi5EeaRm5xIK6nGuQ")]
[Description(@"Specifies the type of account status update instructed.")]
[Derivations(typeof(AccountStatusUpdateInstruction1Code))]
public enum AccountStatusUpdateInstructionCode
{
    /// <summary>
    /// Account is to be reactivated, any previous instruction to close the account is rescinded.
    /// Encoded/decoded by serializers as "REAC".
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_IYG-YHi6EeaRm5xIK6nGuQ")]
    [Description(@"Account is to be reactivated, any previous instruction to close the account is rescinded.")]
    Reactive,
    
    /// <summary>
    /// Account is to be closed.
    /// Encoded/decoded by serializers as "CLOS".
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_Lh2WgHi6EeaRm5xIK6nGuQ")]
    [Description(@"Account is to be closed.")]
    Close,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountStatusUpdateInstructionCodeMetadataExtensions
{
    private static readonly AccountStatusUpdateInstructionCodeDropdownSource _dropdownSource = new AccountStatusUpdateInstructionCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountStatusUpdateInstructionCodeDropdownRow GetMetadata(this AccountStatusUpdateInstructionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


