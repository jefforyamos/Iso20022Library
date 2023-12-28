﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxRecord1Code.  ISO2002 ID# _YiBCZ9p-Ed-ak6NoX_4Aeg_278106710.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax details.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YiBCZ9p-Ed-ak6NoX_4Aeg_278106710")]
[Description(@"Specifies the type of tax details.")]
[DerivedFrom(typeof(TaxRecordCode))]
public enum TaxRecord1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WithholdingTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YiBCaNp-Ed-ak6NoX_4Aeg_278106712")]
    [Description(@"??")]
    WithholdingTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ValueAddedTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YiKMUNp-Ed-ak6NoX_4Aeg_278106740")]
    [Description(@"??")]
    ValueAddedTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IncomePaymentDetails".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YiKMUdp-Ed-ak6NoX_4Aeg_278106771")]
    [Description(@"??")]
    IncomePaymentDetails,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TotalAmountForIncomePayments".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YiKMUtp-Ed-ak6NoX_4Aeg_278106772")]
    [Description(@"??")]
    TotalAmountForIncomePayments,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MoneyPaymentDetails".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YiKMU9p-Ed-ak6NoX_4Aeg_278106802")]
    [Description(@"??")]
    MoneyPaymentDetails,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TotalAmountForMoneyPayments".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YiKMVNp-Ed-ak6NoX_4Aeg_278107073")]
    [Description(@"??")]
    TotalAmountForMoneyPayments,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YiKMVdp-Ed-ak6NoX_4Aeg_278107081")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxRecord1CodeMetadataExtensions
{
    private static readonly TaxRecord1CodeDropdownSource _dropdownSource = new TaxRecord1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxRecord1CodeDropdownRow GetMetadata(this TaxRecord1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


