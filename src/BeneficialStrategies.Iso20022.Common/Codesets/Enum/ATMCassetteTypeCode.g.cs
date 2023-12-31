﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMCassetteTypeCode.  ISO2002 ID# _W-ddQIqfEeS4a4abTJTSSw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of cassette.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_W-ddQIqfEeS4a4abTJTSSw")]
[Description(@"Type of cassette.")]
[Derivations(typeof(ATMCassetteType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ATMCassetteTypeCode
{
    /// <summary>
    /// Cassette for deposits.
    /// Encoded/decoded by serializers as "DPST".
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_ZQDFYIqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for deposits.")]
    In,
    
    /// <summary>
    /// Cassette for dispense.
    /// Encoded/decoded by serializers as "DISP".
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_cvkgQIqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for dispense.")]
    Out,
    
    /// <summary>
    /// Cassette for recycling.
    /// Encoded/decoded by serializers as "RCYC".
    /// </summary>
    [EnumMember(Value = "RCYC")]
    [IsoId("_fI5vIIqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for recycling.")]
    Recycling,
    
    /// <summary>
    /// Cassette for replenishment.
    /// Encoded/decoded by serializers as "RPLT".
    /// </summary>
    [EnumMember(Value = "RPLT")]
    [IsoId("_hhCrMIqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for replenishment.")]
    Replenishment,
    
    /// <summary>
    /// Cassette for reject.
    /// Encoded/decoded by serializers as "RJCT".
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_kgFPMIqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for reject.")]
    Reject,
    
    /// <summary>
    /// Cassette for retract.
    /// Encoded/decoded by serializers as "RTRC".
    /// </summary>
    [EnumMember(Value = "RTRC")]
    [IsoId("_nSTfMIqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for retract.")]
    Retract,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMCassetteTypeCodeMetadataExtensions
{
    private static readonly ATMCassetteTypeCodeDropdownSource _dropdownSource = new ATMCassetteTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMCassetteTypeCodeDropdownRow GetMetadata(this ATMCassetteTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


