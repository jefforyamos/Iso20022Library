﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CashAccountType1Code.  ISO2002 ID# _a24A8dp-Ed-ak6NoX_4Aeg_2050502101.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a24A8dp-Ed-ak6NoX_4Aeg_2050502101")]
[Description(@"Specifies the nature, or use, of the cash account.")]
[DerivedFrom(typeof(CashAccountTypeCode))]
public enum CashAccountType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Settlement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a24A8tp-Ed-ak6NoX_4Aeg_2050502103")]
    [Description(@"??")]
    Settlement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Current".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a24A89p-Ed-ak6NoX_4Aeg_2050502104")]
    [Description(@"??")]
    Current,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Savings".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a24A9Np-Ed-ak6NoX_4Aeg_2050502105")]
    [Description(@"??")]
    Savings,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CashAccountType1CodeMetadataExtensions
{
    private static readonly CashAccountType1CodeDropdownSource _dropdownSource = new CashAccountType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICashAccountType1CodeDropdownRow GetMetadata(this CashAccountType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


