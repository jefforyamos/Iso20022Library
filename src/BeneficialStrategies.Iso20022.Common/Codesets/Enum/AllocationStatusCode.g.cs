﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AllocationStatusCode.  ISO2002 ID# _boymEtp-Ed-ak6NoX_4Aeg_-1844046552.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of allocation of collateral to cover the instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_boymEtp-Ed-ak6NoX_4Aeg_-1844046552")]
[Description(@"Specifies the status of allocation of collateral to cover the instruction.")]
public enum AllocationStatusCode
{
    /// <summary>
    /// Instruction has been fully covered by collateral.
    /// Encoded/decoded by serializers as "AOLF".
    /// </summary>
    [EnumMember(Value = "AOLF")]
    [IsoId("_boymE9p-Ed-ak6NoX_4Aeg_-1510657003")]
    [Description(@"Instruction has been fully covered by collateral.")]
    FullyAllocated,
    
    /// <summary>
    /// Instruction has been partially covered by collateral.
    /// Encoded/decoded by serializers as "AOLP".
    /// </summary>
    [EnumMember(Value = "AOLP")]
    [IsoId("_boymFNp-Ed-ak6NoX_4Aeg_-1510654068")]
    [Description(@"Instruction has been partially covered by collateral.")]
    PartiallyAllocated,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AllocationStatusCodeMetadataExtensions
{
    private static readonly AllocationStatusCodeDropdownSource _dropdownSource = new AllocationStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAllocationStatusCodeDropdownRow GetMetadata(this AllocationStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


