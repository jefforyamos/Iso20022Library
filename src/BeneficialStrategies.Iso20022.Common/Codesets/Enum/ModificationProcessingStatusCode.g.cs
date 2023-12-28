﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ModificationProcessingStatusCode.  ISO2002 ID# _jQp0g-5NEeCisYr99QEiWA_266324205.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jQp0g-5NEeCisYr99QEiWA_266324205")]
[Description(@"Specifies the status of a cancellation request.")]
public enum ModificationProcessingStatusCode
{
    /// <summary>
    /// Modification has been completed.
    /// Encoded/decoded by serializers as "MODC".
    /// </summary>
    [EnumMember(Value = "MODC")]
    [IsoId("_jQp0hO5NEeCisYr99QEiWA_152485139")]
    [Description(@"Modification has been completed.")]
    Completed,
    
    /// <summary>
    /// Modification is pending. It is not known at this time whether modified can be executed.
    /// Encoded/decoded by serializers as "MODP".
    /// </summary>
    [EnumMember(Value = "MODP")]
    [IsoId("_jQzlgO5NEeCisYr99QEiWA_874616089")]
    [Description(@"Modification is pending. It is not known at this time whether modified can be executed.")]
    Pending,
    
    /// <summary>
    /// Modification will not be executed.
    /// Encoded/decoded by serializers as "DEND".
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_jQzlge5NEeCisYr99QEiWA_-1727820501")]
    [Description(@"Modification will not be executed.")]
    Denied,
    
    /// <summary>
    /// Modification request has been acknowledged for further processing by the account servicer.
    /// Encoded/decoded by serializers as "PACK".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_jQzlgu5NEeCisYr99QEiWA_751120761")]
    [Description(@"Modification request has been acknowledged for further processing by the account servicer.")]
    Accepted,
    
    /// <summary>
    /// Modification has been rejected for further processing.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_jQzlg-5NEeCisYr99QEiWA_-359790658")]
    [Description(@"Modification has been rejected for further processing.")]
    Rejected,
    
    /// <summary>
    /// Modification request is in repair.
    /// Encoded/decoded by serializers as "REPR".
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_jQzlhO5NEeCisYr99QEiWA_-1534981683")]
    [Description(@"Modification request is in repair.")]
    InRepair,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ModificationProcessingStatusCodeMetadataExtensions
{
    private static readonly ModificationProcessingStatusCodeDropdownSource _dropdownSource = new ModificationProcessingStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IModificationProcessingStatusCodeDropdownRow GetMetadata(this ModificationProcessingStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


