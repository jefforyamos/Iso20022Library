﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StoredValueAccountTypeCode.  ISO2002 ID# _gjAHYNtcEeipuvJHTHIw9A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of stored value account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gjAHYNtcEeipuvJHTHIw9A")]
[Description(@"Type of stored value account.")]
[Derivations(typeof(StoredValueAccountType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum StoredValueAccountTypeCode
{
    /// <summary>
    /// Payment mean issued by retailers or banks as a substitute to a non-monetary gift. Usually, this Stored Value item is used only once.
    /// Encoded/decoded by serializers as "GIFT".
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_kZ4SUNtcEeipuvJHTHIw9A")]
    [Description(@"Payment mean issued by retailers or banks as a substitute to a non-monetary gift. Usually, this Stored Value item is used only once.")]
    GiftCard,
    
    /// <summary>
    /// Stored value instrument used to pay telephone services (e.g. card or identifier).
    /// Encoded/decoded by serializers as "PHON".
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_oPTrwNtcEeipuvJHTHIw9A")]
    [Description(@"Stored value instrument used to pay telephone services (e.g. card or identifier).")]
    PhoneCard,
    
    /// <summary>
    /// Other non listed stored value instrument.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_q_yPUNtcEeipuvJHTHIw9A")]
    [Description(@"Other non listed stored value instrument.")]
    OtherPrepaidAccount,
    
    /// <summary>
    /// Certificate to be given to a customer. Usually one shot voucher.
    /// Encoded/decoded by serializers as "GCER".
    /// </summary>
    [EnumMember(Value = "GCER")]
    [IsoId("_AmJTwNtdEeipuvJHTHIw9A")]
    [Description(@"Certificate to be given to a customer. Usually one shot voucher.")]
    GiftCertificate,
    
    /// <summary>
    /// Stored value account hold on the chip of a smart card. 
    /// Encoded/decoded by serializers as "CARD".
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_C7YFwNtdEeipuvJHTHIw9A")]
    [Description(@"Stored value account hold on the chip of a smart card. ")]
    SmartCardTag,
    
    /// <summary>
    /// Voucher that can be used online once or in several times.
    /// Encoded/decoded by serializers as "OLVC".
    /// </summary>
    [EnumMember(Value = "OLVC")]
    [IsoId("_FytfQNtdEeipuvJHTHIw9A")]
    [Description(@"Voucher that can be used online once or in several times.")]
    OnlineVoucher,
    
    /// <summary>
    /// Car wash specific account.
    /// Encoded/decoded by serializers as "CWVC".
    /// </summary>
    [EnumMember(Value = "CWVC")]
    [IsoId("_IomHQNtdEeipuvJHTHIw9A")]
    [Description(@"Car wash specific account.")]
    CarwashVoucher,
    
    /// <summary>
    /// Meal and check voucher for restaurants.
    /// Encoded/decoded by serializers as "MLVC".
    /// </summary>
    [EnumMember(Value = "MLVC")]
    [IsoId("_LqE7QNtdEeipuvJHTHIw9A")]
    [Description(@"Meal and check voucher for restaurants.")]
    MealVoucher,
    
    /// <summary>
    /// Prepaid account open with a merchant or big retailers.
    /// Encoded/decoded by serializers as "MERC".
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_OGLKQNtdEeipuvJHTHIw9A")]
    [Description(@"Prepaid account open with a merchant or big retailers.")]
    MerchantAccount,
    
    /// <summary>
    /// Travel prepaid account.
    /// Encoded/decoded by serializers as "TRVL".
    /// </summary>
    [EnumMember(Value = "TRVL")]
    [IsoId("_RhJcUNtdEeipuvJHTHIw9A")]
    [Description(@"Travel prepaid account.")]
    Travel,
    
    /// <summary>
    /// Account supporting e-money issued by an electronic money issuer.
    /// Encoded/decoded by serializers as "ELMY".
    /// </summary>
    [EnumMember(Value = "ELMY")]
    [IsoId("_VKEDwNtdEeipuvJHTHIw9A")]
    [Description(@"Account supporting e-money issued by an electronic money issuer.")]
    ElectronicMoneyAccount,
    
    /// <summary>
    /// Prepaid account managed by a financial institution for low income customers.
    /// Encoded/decoded by serializers as "BNKA".
    /// </summary>
    [EnumMember(Value = "BNKA")]
    [IsoId("_hcWp4NtfEeipuvJHTHIw9A")]
    [Description(@"Prepaid account managed by a financial institution for low income customers.")]
    BankPrepaidAccount,
    
    /// <summary>
    /// Specific prepaid account for companies or professionals expenses.
    /// Encoded/decoded by serializers as "CPYA".
    /// </summary>
    [EnumMember(Value = "CPYA")]
    [IsoId("_lCYVYNtfEeipuvJHTHIw9A")]
    [Description(@"Specific prepaid account for companies or professionals expenses.")]
    CompanyPrepaidAccount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StoredValueAccountTypeCodeMetadataExtensions
{
    private static readonly StoredValueAccountTypeCodeDropdownSource _dropdownSource = new StoredValueAccountTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStoredValueAccountTypeCodeDropdownRow GetMetadata(this StoredValueAccountTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


