﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UKTaxGroupUnitCode.  ISO2002 ID# _YzcwpNp-Ed-ak6NoX_4Aeg_2015540550.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the UK tax group to which units belong. For UK tax, the first dividend that an investor receives from a funds investment is deemed to be part income and part return of capital. The capital element is 'equalisation', and is exempt from income tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YzcwpNp-Ed-ak6NoX_4Aeg_2015540550")]
[Description(@"Specifies the UK tax group to which units belong. For UK tax, the first dividend that an investor receives from a funds investment is deemed to be part income and part return of capital. The capital element is 'equalisation', and is exempt from income tax.")]
[Derivations(typeof(UKTaxGroupUnit1Code))]
public enum UKTaxGroupUnitCode
{
    /// <summary>
    /// The units that were purchased prior to the last ex-div date.
    /// Encoded/decoded by serializers as "GRP1".
    /// </summary>
    [EnumMember(Value = "GRP1")]
    [IsoId("_Yzcwpdp-Ed-ak6NoX_4Aeg_2015540551")]
    [Description(@"The units that were purchased prior to the last ex-div date.")]
    Group1,
    
    /// <summary>
    /// The units that were purchased since the ex-div date, and that benefit from the tax exemption.
    /// Encoded/decoded by serializers as "GRP2".
    /// </summary>
    [EnumMember(Value = "GRP2")]
    [IsoId("_Yzcwptp-Ed-ak6NoX_4Aeg_2015540552")]
    [Description(@"The units that were purchased since the ex-div date, and that benefit from the tax exemption.")]
    Group2,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UKTaxGroupUnitCodeMetadataExtensions
{
    private static readonly UKTaxGroupUnitCodeDropdownSource _dropdownSource = new UKTaxGroupUnitCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUKTaxGroupUnitCodeDropdownRow GetMetadata(this UKTaxGroupUnitCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


