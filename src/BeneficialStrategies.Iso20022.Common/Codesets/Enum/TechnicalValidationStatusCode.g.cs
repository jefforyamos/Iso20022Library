﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TechnicalValidationStatusCode.  ISO2002 ID# _Yll61Np-Ed-ak6NoX_4Aeg_771598790.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the result of the technical validation carried out by the receiver (forwarding or first agent).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yll61Np-Ed-ak6NoX_4Aeg_771598790")]
[Description(@"Specifies the result of the technical validation carried out by the receiver (forwarding or first agent).")]
public enum TechnicalValidationStatusCode
{
    /// <summary>
    /// Indicates that the request has been correctly received and that the technical validation was successful.
    /// </summary>
    [EnumMember(Value = "RCCF")]
    [IsoId("_Yll61dp-Ed-ak6NoX_4Aeg_1506722144")]
    [Description(@"Indicates that the request has been correctly received and that the technical validation was successful.")]
    RCCF,
    
    /// <summary>
    /// Indicates there was an error in the reception of the request or that the technical validation was not successful.
    /// </summary>
    [EnumMember(Value = "RCER")]
    [IsoId("_Yll61tp-Ed-ak6NoX_4Aeg_1529808681")]
    [Description(@"Indicates there was an error in the reception of the request or that the technical validation was not successful.")]
    RCER,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TechnicalValidationStatusCodeMetadataExtensions
{
    private static readonly TechnicalValidationStatusCodeDropdownSource _dropdownSource = new TechnicalValidationStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITechnicalValidationStatusCodeDropdownRow GetMetadata(this TechnicalValidationStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


