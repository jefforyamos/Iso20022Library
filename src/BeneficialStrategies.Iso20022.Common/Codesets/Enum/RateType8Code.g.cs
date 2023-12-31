﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RateType8Code.  ISO2002 ID# _ZZmKp9p-Ed-ak6NoX_4Aeg_-516051900.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZmKp9p-Ed-ak6NoX_4Aeg_-516051900")]
[Description(@"Specifies the type of tax rate.")]
[DerivedFrom(typeof(RateTypeCode))]
public enum RateType8Code
{
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as "WithholdingOfLocalTax".
    /// </summary>
    [EnumMember(Value = "WITL")]
    [IsoId("_ZZvUkNp-Ed-ak6NoX_4Aeg_-440320575")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfLocalTax,
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as "WithholdingOfForeignTax".
    /// </summary>
    [EnumMember(Value = "WITF")]
    [IsoId("_ZZvUkdp-Ed-ak6NoX_4Aeg_-71837844")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfForeignTax,
    
    /// <summary>
    /// Interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).
    /// Encoded/decoded by serializers as "LocalTax".
    /// </summary>
    [EnumMember(Value = "LIDT")]
    [IsoId("_ZZvUktp-Ed-ak6NoX_4Aeg_-98555748")]
    [Description(@"Interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).")]
    LocalTax,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RateType8CodeMetadataExtensions
{
    private static readonly RateType8CodeDropdownSource _dropdownSource = new RateType8CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRateType8CodeDropdownRow GetMetadata(this RateType8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


