﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FractionalSecurityRuleCode.  ISO2002 ID# _1rgnQDL3EeKU9IrkkToqcw_126985823.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the fractional security handling rule that does not have an ISO value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1rgnQDL3EeKU9IrkkToqcw_126985823")]
[Description(@"Specifies the fractional security handling rule that does not have an ISO value.")]
public enum FractionalSecurityRuleCode
{
    /// <summary>
    /// Round Up x and above on the beneficial owner fractions, where x is the rounding factor. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.
    /// </summary>
    [EnumMember(Value = "BORU")]
    [IsoId("_1rgnQTL3EeKU9IrkkToqcw_-428904472")]
    [Description(@"Round Up x and above on the beneficial owner fractions, where x is the rounding factor. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.")]
    BORU,
    
    /// <summary>
    /// Cash in Lieu on the beneficial owner fractions.
    /// </summary>
    [EnumMember(Value = "BCIL")]
    [IsoId("_1rgnQjL3EeKU9IrkkToqcw_1097474043")]
    [Description(@"Cash in Lieu on the beneficial owner fractions.")]
    BCIL,
    
    /// <summary>
    /// Round Down x and below beneficial owner fractions, where x is the rounding factor. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.
    /// </summary>
    [EnumMember(Value = "BORD")]
    [IsoId("_1rgnQzL3EeKU9IrkkToqcw_1047506999")]
    [Description(@"Round Down x and below beneficial owner fractions, where x is the rounding factor. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.")]
    BORD,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FractionalSecurityRuleCodeMetadataExtensions
{
    private static readonly FractionalSecurityRuleCodeDropdownSource _dropdownSource = new FractionalSecurityRuleCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFractionalSecurityRuleCodeDropdownRow GetMetadata(this FractionalSecurityRuleCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


