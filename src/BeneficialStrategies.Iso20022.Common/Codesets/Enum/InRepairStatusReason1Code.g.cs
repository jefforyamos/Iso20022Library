﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InRepairStatusReason1Code.  ISO2002 ID# _aWsFBdp-Ed-ak6NoX_4Aeg_2109635063.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a In Repair status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aWsFBdp-Ed-ak6NoX_4Aeg_2109635063")]
[Description(@"Specifies the reason for a In Repair status.")]
[DerivedFrom(typeof(InRepairStatusReasonCode))]
public enum InRepairStatusReason1Code
{
    /// <summary>
    /// Order has been accepted and centralised before the cut off, but with different sales agreement than the one provided in the order.
    /// Encoded/decoded by serializers as "COMA".
    /// </summary>
    [EnumMember(Value = "COMA")]
    [IsoId("_aWsFBtp-Ed-ak6NoX_4Aeg_2109635082")]
    [Description(@"Order has been accepted and centralised before the cut off, but with different sales agreement than the one provided in the order.")]
    CommercialAgreement = InRepairStatusReasonCode.CommercialAgreement, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InRepairStatusReason1CodeMetadataExtensions
{
    private static readonly InRepairStatusReason1CodeDropdownSource _dropdownSource = new InRepairStatusReason1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInRepairStatusReason1CodeDropdownRow GetMetadata(this InRepairStatusReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


