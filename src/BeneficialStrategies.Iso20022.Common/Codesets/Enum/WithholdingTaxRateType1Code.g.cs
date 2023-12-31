﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for WithholdingTaxRateType1Code.  ISO2002 ID# _Y7v0kCeGEeOXAt_43VmZGw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of withholding tax rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y7v0kCeGEeOXAt_43VmZGw")]
[Description(@"Specifies the type of withholding tax rate.")]
[DerivedFrom(typeof(WithholdingTaxRateTypeCode))]
public enum WithholdingTaxRateType1Code
{
    /// <summary>
    /// Withholding tax related to payments subject to back up withholding.
    /// Encoded/decoded by serializers as "BackUpWithholding".
    /// </summary>
    [EnumMember(Value = "BWIT")]
    [IsoId("_dtVUQSeGEeOXAt_43VmZGw")]
    [Description(@"Withholding tax related to payments subject to back up withholding.")]
    BackUpWithholding,
    
    /// <summary>
    /// Withholding tax related to income subject to FATCA (Foreign Account Tax Compliance Act).
    /// Encoded/decoded by serializers as "FATCATax".
    /// </summary>
    [EnumMember(Value = "FTCA")]
    [IsoId("_d4CvcSeGEeOXAt_43VmZGw")]
    [Description(@"Withholding tax related to income subject to FATCA (Foreign Account Tax Compliance Act).")]
    FATCATax,
    
    /// <summary>
    /// Withholding tax related to income subject to NRA (Non Resident Alien).
    /// Encoded/decoded by serializers as "NRATax".
    /// </summary>
    [EnumMember(Value = "NRAT")]
    [IsoId("_d8qJsSeGEeOXAt_43VmZGw")]
    [Description(@"Withholding tax related to income subject to NRA (Non Resident Alien).")]
    NRATax,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class WithholdingTaxRateType1CodeMetadataExtensions
{
    private static readonly WithholdingTaxRateType1CodeDropdownSource _dropdownSource = new WithholdingTaxRateType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IWithholdingTaxRateType1CodeDropdownRow GetMetadata(this WithholdingTaxRateType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


