﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMServiceType1Code.  ISO2002 ID# _yhZnkIogEeSirOZJBRz_nA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the type of withdrawal selected by the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yhZnkIogEeSirOZJBRz_nA")]
[Description(@"Describes the type of withdrawal selected by the customer.")]
[DerivedFrom(typeof(ATMServiceTypeCode))]
public enum ATMServiceType1Code
{
    /// <summary>
    /// Amount and notes values are chosen by the customer.
    /// Encoded/decoded by serializers as "ChosenWithdrawal".
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_1VkYUYogEeSirOZJBRz_nA")]
    [Description(@"Amount and notes values are chosen by the customer.")]
    ChosenWithdrawal,
    
    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.
    /// Encoded/decoded by serializers as "PreAuthorisedWithdrawal".
    /// </summary>
    [EnumMember(Value = "PATH")]
    [IsoId("_1aqTsYogEeSirOZJBRz_nA")]
    [Description(@"Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.")]
    PreAuthorisedWithdrawal,
    
    /// <summary>
    /// Amount and notes Values are pre-defined by the customer profile.
    /// Encoded/decoded by serializers as "ProfileWithdrawal".
    /// </summary>
    [EnumMember(Value = "PRFL")]
    [IsoId("_1gFmQYogEeSirOZJBRz_nA")]
    [Description(@"Amount and notes Values are pre-defined by the customer profile.")]
    ProfileWithdrawal,
    
    /// <summary>
    /// Standard withdrawal of items.
    /// Encoded/decoded by serializers as "StandardWithdrawal".
    /// </summary>
    [EnumMember(Value = "STDR")]
    [IsoId("_1mPRkYogEeSirOZJBRz_nA")]
    [Description(@"Standard withdrawal of items.")]
    StandardWithdrawal,
    
    /// <summary>
    /// Withdrawal authorised by a supervisor.
    /// Encoded/decoded by serializers as "SupervisedWithdrawal".
    /// </summary>
    [EnumMember(Value = "SPRV")]
    [IsoId("_1rPtYYogEeSirOZJBRz_nA")]
    [Description(@"Withdrawal authorised by a supervisor.")]
    SupervisedWithdrawal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMServiceType1CodeMetadataExtensions
{
    private static readonly ATMServiceType1CodeDropdownSource _dropdownSource = new ATMServiceType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMServiceType1CodeDropdownRow GetMetadata(this ATMServiceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


