﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StoredValueAccountType1Code.  ISO2002 ID# _qZrKMNtfEeipuvJHTHIw9A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of stored value account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qZrKMNtfEeipuvJHTHIw9A")]
[Description(@"Type of stored value account.")]
[DerivedFrom(typeof(StoredValueAccountTypeCode))]
public enum StoredValueAccountType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BankPrepaidAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_swkJEdtfEeipuvJHTHIw9A")]
    [Description(@"??")]
    BankPrepaidAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CarwashVoucher".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_sz7mIdtfEeipuvJHTHIw9A")]
    [Description(@"??")]
    CarwashVoucher,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompanyPrepaidAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_s4Kl4dtfEeipuvJHTHIw9A")]
    [Description(@"??")]
    CompanyPrepaidAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ElectronicMoneyAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_s8hhcdtfEeipuvJHTHIw9A")]
    [Description(@"??")]
    ElectronicMoneyAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GiftCard".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tBb2odtfEeipuvJHTHIw9A")]
    [Description(@"??")]
    GiftCard,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GiftCertificate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tGYBAdtfEeipuvJHTHIw9A")]
    [Description(@"??")]
    GiftCertificate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MealVoucher".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tKV7AdtfEeipuvJHTHIw9A")]
    [Description(@"??")]
    MealVoucher,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OnlineVoucher".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tPUhodtfEeipuvJHTHIw9A")]
    [Description(@"??")]
    OnlineVoucher,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MerchantAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tVqaMdtfEeipuvJHTHIw9A")]
    [Description(@"??")]
    MerchantAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrepaidAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tdEpwdtfEeipuvJHTHIw9A")]
    [Description(@"??")]
    OtherPrepaidAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PhoneCard".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_thugQdtfEeipuvJHTHIw9A")]
    [Description(@"??")]
    PhoneCard,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SmartCardTag".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tmPz4dtfEeipuvJHTHIw9A")]
    [Description(@"??")]
    SmartCardTag,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Travel".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_tquEMdtfEeipuvJHTHIw9A")]
    [Description(@"??")]
    Travel,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StoredValueAccountType1CodeMetadataExtensions
{
    private static readonly StoredValueAccountType1CodeDropdownSource _dropdownSource = new StoredValueAccountType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStoredValueAccountType1CodeDropdownRow GetMetadata(this StoredValueAccountType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


