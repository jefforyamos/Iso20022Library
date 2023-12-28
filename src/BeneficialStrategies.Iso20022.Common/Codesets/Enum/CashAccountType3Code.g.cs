﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CashAccountType3Code.  ISO2002 ID# _a3Bx99p-Ed-ak6NoX_4Aeg_-801481171.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a3Bx99p-Ed-ak6NoX_4Aeg_-801481171")]
[Description(@"Specifies the nature, or use, of the cash account.")]
[DerivedFrom(typeof(CashAccountTypeCode))]
public enum CashAccountType3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a3Bx-Np-Ed-ak6NoX_4Aeg_-729445965")]
    [Description(@"??")]
    CashPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Charges".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a3K74Np-Ed-ak6NoX_4Aeg_-728524735")]
    [Description(@"??")]
    Charges,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Settlement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a3K74dp-Ed-ak6NoX_4Aeg_-728524020")]
    [Description(@"??")]
    Settlement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Current".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a3K74tp-Ed-ak6NoX_4Aeg_-728523977")]
    [Description(@"??")]
    Current,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Savings".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a3K749p-Ed-ak6NoX_4Aeg_-728523942")]
    [Description(@"??")]
    Savings,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CashAccountType3CodeMetadataExtensions
{
    private static readonly CashAccountType3CodeDropdownSource _dropdownSource = new CashAccountType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICashAccountType3CodeDropdownRow GetMetadata(this CashAccountType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


