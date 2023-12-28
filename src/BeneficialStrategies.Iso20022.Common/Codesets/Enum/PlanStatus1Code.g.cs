﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PlanStatus1Code.  ISO2002 ID# _QAWLUAjcEeS5F6qHcKOrew.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a plan.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QAWLUAjcEeS5F6qHcKOrew")]
[Description(@"Specifies the status of a plan.")]
[DerivedFrom(typeof(PlanStatusCode))]
public enum PlanStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Active".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_RvyIoQjcEeS5F6qHcKOrew")]
    [Description(@"??")]
    Active,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Closed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_R4tbIQjcEeS5F6qHcKOrew")]
    [Description(@"??")]
    Closed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Suspended".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_SBC3wQjcEeS5F6qHcKOrew")]
    [Description(@"??")]
    Suspended,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PlanStatus1CodeMetadataExtensions
{
    private static readonly PlanStatus1CodeDropdownSource _dropdownSource = new PlanStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPlanStatus1CodeDropdownRow GetMetadata(this PlanStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


