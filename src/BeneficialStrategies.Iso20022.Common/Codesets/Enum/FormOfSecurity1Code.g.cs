﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FormOfSecurity1Code.  ISO2002 ID# _arP_wdp-Ed-ak6NoX_4Aeg_1608809377.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Form of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_arP_wdp-Ed-ak6NoX_4Aeg_1608809377")]
[Description(@"Form of a financial instrument.")]
[DerivedFrom(typeof(FormOfSecurityCode))]
public enum FormOfSecurity1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Bearer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1Gk9wN1OEeGAp99n2TKigg_1287612204")]
    [Description(@"??")]
    Bearer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Registered".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3TsVkN1OEeGAp99n2TKigg_1858924413")]
    [Description(@"??")]
    Registered,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FormOfSecurity1CodeMetadataExtensions
{
    private static readonly FormOfSecurity1CodeDropdownSource _dropdownSource = new FormOfSecurity1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFormOfSecurity1CodeDropdownRow GetMetadata(this FormOfSecurity1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

