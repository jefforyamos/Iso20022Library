﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CalculationBasisCode.  ISO2002 ID# _bVa-INp-Ed-ak6NoX_4Aeg_-1889057025.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the calculation basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bVa-INp-Ed-ak6NoX_4Aeg_-1889057025")]
[Description(@"Specifies the calculation basis.")]
[Derivations(typeof(CalculationBasis1Code),typeof(CalculationBasis2Code))]
// External derivations that should be provided by the proper interface are: 
public enum CalculationBasisCode
{
    /// <summary>
    /// Average basis.
    /// Encoded/decoded by serializers as "AVER".
    /// </summary>
    [EnumMember(Value = "AVER")]
    [IsoId("_bVa-Idp-Ed-ak6NoX_4Aeg_-1432837646")]
    [Description(@"Average basis.")]
    Average,
    
    /// <summary>
    /// Daily basis.
    /// Encoded/decoded by serializers as "DAIL".
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_bVa-Itp-Ed-ak6NoX_4Aeg_-1432837628")]
    [Description(@"Daily basis.")]
    Daily,
    
    /// <summary>
    /// Another type of calculation basis.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bVa-I9p-Ed-ak6NoX_4Aeg_-797941073")]
    [Description(@"Another type of calculation basis.")]
    Other,
    
    /// <summary>
    /// Monthly basis.
    /// Encoded/decoded by serializers as "MNTH".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_bVa-JNp-Ed-ak6NoX_4Aeg_-1394980831")]
    [Description(@"Monthly basis.")]
    Monthly,
    
    /// <summary>
    /// Yearly basis.
    /// Encoded/decoded by serializers as "YEAR".
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_bVa-Jdp-Ed-ak6NoX_4Aeg_-1394980754")]
    [Description(@"Yearly basis.")]
    Annual,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CalculationBasisCodeMetadataExtensions
{
    private static readonly CalculationBasisCodeDropdownSource _dropdownSource = new CalculationBasisCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICalculationBasisCodeDropdownRow GetMetadata(this CalculationBasisCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


