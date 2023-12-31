﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxType4Code.  ISO2002 ID# _Ykix-dp-Ed-ak6NoX_4Aeg_-858033368.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ykix-dp-Ed-ak6NoX_4Aeg_-858033368")]
[Description(@"Specifies the type of tax.")]
[DerivedFrom(typeof(TaxTypeCode))]
public enum TaxType4Code
{
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as "WithholdingOfForeignTax".
    /// </summary>
    [EnumMember(Value = "WITF")]
    [IsoId("_Yksi8Np-Ed-ak6NoX_4Aeg_-858031567")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfForeignTax,
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as "WithholdingOfLocalTax".
    /// </summary>
    [EnumMember(Value = "WITL")]
    [IsoId("_Yksi8dp-Ed-ak6NoX_4Aeg_-858031464")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfLocalTax,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxType4CodeMetadataExtensions
{
    private static readonly TaxType4CodeDropdownSource _dropdownSource = new TaxType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxType4CodeDropdownRow GetMetadata(this TaxType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


