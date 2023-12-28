﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InitialPhysicalForm2Code.  ISO2002 ID# _hblKoGliEeGaMcKyqKNRfQ_-773946621.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the physical form of the securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hblKoGliEeGaMcKyqKNRfQ_-773946621")]
[Description(@"Indicates the physical form of the securities.")]
[DerivedFrom(typeof(InitialPhysicalFormCode))]
public enum InitialPhysicalForm2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GP".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbu7kGliEeGaMcKyqKNRfQ_1457267840")]
    [Description(@"??")]
    GP,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Definitive".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hbu7kWliEeGaMcKyqKNRfQ_-428414513")]
    [Description(@"??")]
    Definitive,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InitialPhysicalForm2CodeMetadataExtensions
{
    private static readonly InitialPhysicalForm2CodeDropdownSource _dropdownSource = new InitialPhysicalForm2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInitialPhysicalForm2CodeDropdownRow GetMetadata(this InitialPhysicalForm2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


