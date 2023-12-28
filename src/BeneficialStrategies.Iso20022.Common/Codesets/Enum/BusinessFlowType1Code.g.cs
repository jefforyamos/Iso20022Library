﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BusinessFlowType1Code.  ISO2002 ID# _p7MmMPsMEeCZF5_uug7xyA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p7MmMPsMEeCZF5_uug7xyA")]
[Description(@"Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).")]
[DerivedFrom(typeof(BusinessFlowTypeCode))]
public enum BusinessFlowType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SingleLegDeliveringParty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ad9YDv8xEeC-e_lDNJKWcg")]
    [Description(@"??")]
    SingleLegDeliveringParty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SingleLegReceivingParty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aiItbv8xEeC-e_lDNJKWcg")]
    [Description(@"??")]
    SingleLegReceivingParty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DoubleLegProcess".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bIIWbv8xEeC-e_lDNJKWcg")]
    [Description(@"??")]
    DoubleLegProcess,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BusinessFlowType1CodeMetadataExtensions
{
    private static readonly BusinessFlowType1CodeDropdownSource _dropdownSource = new BusinessFlowType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBusinessFlowType1CodeDropdownRow GetMetadata(this BusinessFlowType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


