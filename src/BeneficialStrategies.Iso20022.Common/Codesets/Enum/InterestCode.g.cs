﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InterestCode.  ISO2002 ID# _aZ-ChNp-Ed-ak6NoX_4Aeg_-657407757.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates which type of interest is applied to a balance left on an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aZ-ChNp-Ed-ak6NoX_4Aeg_-657407757")]
[Description(@"Indicates which type of interest is applied to a balance left on an account.")]
public enum InterestCode
{
    /// <summary>
    /// During or within a business day.
    /// </summary>
    [EnumMember(Value = "INDY")]
    [IsoId("_aZ-Chdp-Ed-ak6NoX_4Aeg_-376656461")]
    [Description(@"During or within a business day.")]
    INDY,
    
    /// <summary>
    /// Period of time between the end of a business day and the start of the next business day (usually the day after).
    /// </summary>
    [EnumMember(Value = "OVRN")]
    [IsoId("_aZ-Chtp-Ed-ak6NoX_4Aeg_-358184956")]
    [Description(@"Period of time between the end of a business day and the start of the next business day (usually the day after).")]
    OVRN,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InterestCodeMetadataExtensions
{
    private static readonly InterestCodeDropdownSource _dropdownSource = new InterestCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInterestCodeDropdownRow GetMetadata(this InterestCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


