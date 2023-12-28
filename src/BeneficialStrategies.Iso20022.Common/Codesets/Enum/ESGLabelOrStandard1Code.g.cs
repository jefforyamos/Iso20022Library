﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ESGLabelOrStandard1Code.  ISO2002 ID# _eSB0MNA7EeuSBa1PsnseFg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the ESG label or standard of a product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eSB0MNA7EeuSBa1PsnseFg")]
[Description(@"Specifies the ESG label or standard of a product.")]
[DerivedFrom(typeof(ESGLabelOrStandardCode))]
public enum ESGLabelOrStandard1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CBIClimateBonds".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6j68gdA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    CBIClimateBonds,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EUEcolabel".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6o14wdA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    EUEcolabel,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EUGreenBond".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6w5BgdA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    EUGreenBond,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FebelfinTowardsSustainability".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_62_pgdA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    FebelfinTowardsSustainability,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FNGSiegel".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6_CyQdA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    FNGSiegel,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GreenfinLabel".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7KEWgdA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    GreenfinLabel,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ICMAGreenBond".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7PIcsdA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    ICMAGreenBond,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ICMASocialBonds".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7UgE4dA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    ICMASocialBonds,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISR".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7Z3GAdA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    ISR,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "KeinVerstoßGegenAtomwaffensperrvertrag".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7iW6sdA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    KeinVerstoßGegenAtomwaffensperrvertrag,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LuxFLAGClimate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7oBd0dA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    LuxFLAGClimate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LuxFLAGEnvironment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7uR20dA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    LuxFLAGEnvironment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LuxFLAGESG".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_70iP0dA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    LuxFLAGESG,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NordicSwan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_78vJkdA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    NordicSwan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UZ49".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_8EohUdA7EeuSBa1PsnseFg")]
    [Description(@"??")]
    UZ49,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ESGLabelOrStandard1CodeMetadataExtensions
{
    private static readonly ESGLabelOrStandard1CodeDropdownSource _dropdownSource = new ESGLabelOrStandard1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IESGLabelOrStandard1CodeDropdownRow GetMetadata(this ESGLabelOrStandard1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

