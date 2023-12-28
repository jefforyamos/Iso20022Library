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
    /// Climate Bonds Initiative (CBI) Climate Bonds Standard.
    /// Encoded/decoded by serializers as "CBIClimateBonds".
    /// </summary>
    [EnumMember(Value = "E005")]
    [IsoId("_6j68gdA7EeuSBa1PsnseFg")]
    [Description(@"Climate Bonds Initiative (CBI) Climate Bonds Standard.")]
    CBIClimateBonds,
    
    /// <summary>
    /// EU Ecolabel for financial products.
    /// Encoded/decoded by serializers as "EUEcolabel".
    /// </summary>
    [EnumMember(Value = "C003")]
    [IsoId("_6o14wdA7EeuSBa1PsnseFg")]
    [Description(@"EU Ecolabel for financial products.")]
    EUEcolabel,
    
    /// <summary>
    /// EU Green Bond Standard.
    /// Encoded/decoded by serializers as "EUGreenBond".
    /// </summary>
    [EnumMember(Value = "B002")]
    [IsoId("_6w5BgdA7EeuSBa1PsnseFg")]
    [Description(@"EU Green Bond Standard.")]
    EUGreenBond,
    
    /// <summary>
    /// Febelfin Towards Sustainability label.
    /// Encoded/decoded by serializers as "FebelfinTowardsSustainability".
    /// </summary>
    [EnumMember(Value = "L012")]
    [IsoId("_62_pgdA7EeuSBa1PsnseFg")]
    [Description(@"Febelfin Towards Sustainability label.")]
    FebelfinTowardsSustainability,
    
    /// <summary>
    /// FNG-Siegel.
    /// Encoded/decoded by serializers as "FNGSiegel".
    /// </summary>
    [EnumMember(Value = "D004")]
    [IsoId("_6_CyQdA7EeuSBa1PsnseFg")]
    [Description(@"FNG-Siegel.")]
    FNGSiegel,
    
    /// <summary>
    /// Greenfin label.
    /// Encoded/decoded by serializers as "GreenfinLabel".
    /// </summary>
    [EnumMember(Value = "O015")]
    [IsoId("_7KEWgdA7EeuSBa1PsnseFg")]
    [Description(@"Greenfin label.")]
    GreenfinLabel,
    
    /// <summary>
    /// International Capital Markets Association (ICMA) Green Bond Principles.
    /// Encoded/decoded by serializers as "ICMAGreenBond".
    /// </summary>
    [EnumMember(Value = "A001")]
    [IsoId("_7PIcsdA7EeuSBa1PsnseFg")]
    [Description(@"International Capital Markets Association (ICMA) Green Bond Principles.")]
    ICMAGreenBond,
    
    /// <summary>
    /// International Capital Markets Association (ICMA) Social Bonds Principles.
    /// Encoded/decoded by serializers as "ICMASocialBonds".
    /// </summary>
    [EnumMember(Value = "F006")]
    [IsoId("_7UgE4dA7EeuSBa1PsnseFg")]
    [Description(@"International Capital Markets Association (ICMA) Social Bonds Principles.")]
    ICMASocialBonds,
    
    /// <summary>
    /// Label "Investissement Socialement Responsable" (ISR).
    /// Encoded/decoded by serializers as "ISR".
    /// </summary>
    [EnumMember(Value = "K011")]
    [IsoId("_7Z3GAdA7EeuSBa1PsnseFg")]
    [Description(@"Label ""Investissement Socialement Responsable"" (ISR).")]
    ISR,
    
    /// <summary>
    /// Kein Verstoss gegen Atomwaffensperrvertrag.
    /// Encoded/decoded by serializers as "KeinVerstoßGegenAtomwaffensperrvertrag".
    /// </summary>
    [EnumMember(Value = "J010")]
    [IsoId("_7iW6sdA7EeuSBa1PsnseFg")]
    [Description(@"Kein Verstoss gegen Atomwaffensperrvertrag.")]
    KeinVerstoßGegenAtomwaffensperrvertrag,
    
    /// <summary>
    /// LuxFLAG climate finance label.
    /// Encoded/decoded by serializers as "LuxFLAGClimate".
    /// </summary>
    [EnumMember(Value = "H008")]
    [IsoId("_7oBd0dA7EeuSBa1PsnseFg")]
    [Description(@"LuxFLAG climate finance label.")]
    LuxFLAGClimate,
    
    /// <summary>
    /// LuxFLAG environment label.
    /// Encoded/decoded by serializers as "LuxFLAGEnvironment".
    /// </summary>
    [EnumMember(Value = "I009")]
    [IsoId("_7uR20dA7EeuSBa1PsnseFg")]
    [Description(@"LuxFLAG environment label.")]
    LuxFLAGEnvironment,
    
    /// <summary>
    /// LuxFLAG ESG label.
    /// Encoded/decoded by serializers as "LuxFLAGESG".
    /// </summary>
    [EnumMember(Value = "G007")]
    [IsoId("_70iP0dA7EeuSBa1PsnseFg")]
    [Description(@"LuxFLAG ESG label.")]
    LuxFLAGESG,
    
    /// <summary>
    /// Nordic Swan Ecolabel.
    /// Encoded/decoded by serializers as "NordicSwan".
    /// </summary>
    [EnumMember(Value = "N014")]
    [IsoId("_78vJkdA7EeuSBa1PsnseFg")]
    [Description(@"Nordic Swan Ecolabel.")]
    NordicSwan,
    
    /// <summary>
    /// UZ49 - das Oesterreichische Umweltzeichen.
    /// Encoded/decoded by serializers as "UZ49".
    /// </summary>
    [EnumMember(Value = "M013")]
    [IsoId("_8EohUdA7EeuSBa1PsnseFg")]
    [Description(@"UZ49 - das Oesterreichische Umweltzeichen.")]
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


