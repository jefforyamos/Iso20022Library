﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PhysicalTransferType1Code.  ISO2002 ID# _sXY0QPrqEeCJc7cZxzE2fg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the financial instrument is to be physically delivered or is a dematerialised transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sXY0QPrqEeCJc7cZxzE2fg")]
[Description(@"Specifies whether the financial instrument is to be physically delivered or is a dematerialised transfer.")]
[DerivedFrom(typeof(PhysicalTransferTypeCode))]
public enum PhysicalTransferType1Code
{
    /// <summary>
    /// Dematerialised transfer.
    /// Encoded/decoded by serializers as "Dematerialised".
    /// </summary>
    [EnumMember(Value = "DEMT")]
    [IsoId("_kzEcnv8vEeCuNd2SpsBr7g")]
    [Description(@"Dematerialised transfer.")]
    Dematerialised,
    
    /// <summary>
    /// Physical transfer.
    /// Encoded/decoded by serializers as "Physical".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_k2gLHv8vEeCuNd2SpsBr7g")]
    [Description(@"Physical transfer.")]
    Physical,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PhysicalTransferType1CodeMetadataExtensions
{
    private static readonly PhysicalTransferType1CodeDropdownSource _dropdownSource = new PhysicalTransferType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPhysicalTransferType1CodeDropdownRow GetMetadata(this PhysicalTransferType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


