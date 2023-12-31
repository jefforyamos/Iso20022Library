﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountManagementStatusCode.  ISO2002 ID# _bqlV09p-Ed-ak6NoX_4Aeg_176271984.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an account management instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bqlV09p-Ed-ak6NoX_4Aeg_176271984")]
[Description(@"Specifies the status of an account management instruction.")]
[Derivations(typeof(AccountManagementStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum AccountManagementStatusCode
{
    /// <summary>
    /// The account management instruction has been received and is acknowledged.
    /// Encoded/decoded by serializers as "RECE".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_bqlV1Np-Ed-ak6NoX_4Aeg_1504294962")]
    [Description(@"The account management instruction has been received and is acknowledged.")]
    Received,
    
    /// <summary>
    /// The account management instruction has been validated and accepted.
    /// Encoded/decoded by serializers as "ACCP".
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_bqlV1dp-Ed-ak6NoX_4Aeg_1748103715")]
    [Description(@"The account management instruction has been validated and accepted.")]
    Accepted,
    
    /// <summary>
    /// The account management instruction is being processed and the confirmation will follow.
    /// Encoded/decoded by serializers as "EXEC".
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_bqlV1tp-Ed-ak6NoX_4Aeg_1760108911")]
    [Description(@"The account management instruction is being processed and the confirmation will follow.")]
    ProcessingOngoing,
    
    /// <summary>
    /// The account management instruction has been sent to the next party, for example, the next intermediary.
    /// Encoded/decoded by serializers as "STNP".
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_bqlV19p-Ed-ak6NoX_4Aeg_1773962673")]
    [Description(@"The account management instruction has been sent to the next party, for example, the next intermediary.")]
    SentToNextParty,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountManagementStatusCodeMetadataExtensions
{
    private static readonly AccountManagementStatusCodeDropdownSource _dropdownSource = new AccountManagementStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountManagementStatusCodeDropdownRow GetMetadata(this AccountManagementStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


