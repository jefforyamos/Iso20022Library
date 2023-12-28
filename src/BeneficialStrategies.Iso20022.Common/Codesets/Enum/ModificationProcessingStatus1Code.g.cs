﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ModificationProcessingStatus1Code.  ISO2002 ID# _jQgqke5NEeCisYr99QEiWA_-1469267591.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jQgqke5NEeCisYr99QEiWA_-1469267591")]
[Description(@"Specifies the status of a cancellation request.")]
[DerivedFrom(typeof(ModificationProcessingStatusCode))]
public enum ModificationProcessingStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jQgqku5NEeCisYr99QEiWA_1714788286")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jQgqk-5NEeCisYr99QEiWA_1892906958")]
    [Description(@"??")]
    Rejected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Completed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jQgqlO5NEeCisYr99QEiWA_-1404987985")]
    [Description(@"??")]
    Completed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Denied".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jQp0gO5NEeCisYr99QEiWA_2006746024")]
    [Description(@"??")]
    Denied,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jQp0ge5NEeCisYr99QEiWA_1828627352")]
    [Description(@"??")]
    Pending,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InRepair".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jQp0gu5NEeCisYr99QEiWA_831554999")]
    [Description(@"??")]
    InRepair,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ModificationProcessingStatus1CodeMetadataExtensions
{
    private static readonly ModificationProcessingStatus1CodeDropdownSource _dropdownSource = new ModificationProcessingStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IModificationProcessingStatus1CodeDropdownRow GetMetadata(this ModificationProcessingStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

