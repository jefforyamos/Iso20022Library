﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AllocationStatus1Code.  ISO2002 ID# _bopcJ9p-Ed-ak6NoX_4Aeg_1464332533.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of allocation of collateral to cover the instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bopcJ9p-Ed-ak6NoX_4Aeg_1464332533")]
[Description(@"Specifies the status of allocation of collateral to cover the instruction.")]
[DerivedFrom(typeof(AllocationStatusCode))]
public enum AllocationStatus1Code
{
    /// <summary>
    /// Instruction has been fully covered by collateral.
    /// Encoded/decoded by serializers as "AOLF".
    /// </summary>
    [EnumMember(Value = "AOLF")]
    [IsoId("_boymENp-Ed-ak6NoX_4Aeg_1464332565")]
    [Description(@"Instruction has been fully covered by collateral.")]
    FullyAllocated = AllocationStatusCode.FullyAllocated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been partially covered by collateral.
    /// Encoded/decoded by serializers as "AOLP".
    /// </summary>
    [EnumMember(Value = "AOLP")]
    [IsoId("_boymEdp-Ed-ak6NoX_4Aeg_1464332594")]
    [Description(@"Instruction has been partially covered by collateral.")]
    PartiallyAllocated = AllocationStatusCode.PartiallyAllocated, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AllocationStatus1CodeMetadataExtensions
{
    private static readonly AllocationStatus1CodeDropdownSource _dropdownSource = new AllocationStatus1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAllocationStatus1CodeDropdownRow GetMetadata(this AllocationStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


