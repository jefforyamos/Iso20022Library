﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BillingCurrencyType2Code.  ISO2002 ID# _6WzSkZqlEeGSON8vddiWzQ_-1596461946.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of currency to be used for the billing of a service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WzSkZqlEeGSON8vddiWzQ_-1596461946")]
[Description(@"Defines the type of currency to be used for the billing of a service.")]
[DerivedFrom(typeof(BillingCurrencyTypeCode))]
public enum BillingCurrencyType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Account".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6WzSkpqlEeGSON8vddiWzQ_-1127654531")]
    [Description(@"??")]
    Account,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Settlement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6WzSk5qlEeGSON8vddiWzQ_-541707505")]
    [Description(@"??")]
    Settlement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pricing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6WzSlJqlEeGSON8vddiWzQ_-1424940792")]
    [Description(@"??")]
    Pricing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Host".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6WzSlZqlEeGSON8vddiWzQ_-1920390448")]
    [Description(@"??")]
    Host,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BillingCurrencyType2CodeMetadataExtensions
{
    private static readonly BillingCurrencyType2CodeDropdownSource _dropdownSource = new BillingCurrencyType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBillingCurrencyType2CodeDropdownRow GetMetadata(this BillingCurrencyType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


