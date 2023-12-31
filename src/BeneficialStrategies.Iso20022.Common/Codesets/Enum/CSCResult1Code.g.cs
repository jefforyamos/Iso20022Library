﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CSCResult1Code.  ISO2002 ID# _TS9qZgEcEeCQm6a_G2yO_w_2096541332.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Result of the printed CSC (Card Security Code) validation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TS9qZgEcEeCQm6a_G2yO_w_2096541332")]
[Description(@"Result of the printed CSC (Card Security Code) validation.")]
[DerivedFrom(typeof(CSCResultCode))]
public enum CSCResult1Code
{
    /// <summary>
    /// Card security code match.
    /// Encoded/decoded by serializers as "CSCMatch".
    /// </summary>
    [EnumMember(Value = "CMCH")]
    [IsoId("_TS9qZwEcEeCQm6a_G2yO_w_153972600")]
    [Description(@"Card security code match.")]
    CSCMatch,
    
    /// <summary>
    /// No card security code match.
    /// Encoded/decoded by serializers as "CSCNoMatch".
    /// </summary>
    [EnumMember(Value = "CNMH")]
    [IsoId("_TS9qaAEcEeCQm6a_G2yO_w_-1576057323")]
    [Description(@"No card security code match.")]
    CSCNoMatch,
    
    /// <summary>
    /// Card security code not processed for technical reason.
    /// Encoded/decoded by serializers as "CSCTechnical".
    /// </summary>
    [EnumMember(Value = "CNMT")]
    [IsoId("_TS9qaQEcEeCQm6a_G2yO_w_-1689896389")]
    [Description(@"Card security code not processed for technical reason.")]
    CSCTechnical,
    
    /// <summary>
    /// Card security code not processed for non-technical reason.
    /// Encoded/decoded by serializers as "CSCNotTechnical".
    /// </summary>
    [EnumMember(Value = "CNMO")]
    [IsoId("_TS9qagEcEeCQm6a_G2yO_w_-1542897554")]
    [Description(@"Card security code not processed for non-technical reason.")]
    CSCNotTechnical,
    
    /// <summary>
    /// Card security code missing in request.
    /// Encoded/decoded by serializers as "CSCMissing".
    /// </summary>
    [EnumMember(Value = "CMSS")]
    [IsoId("_TS9qawEcEeCQm6a_G2yO_w_394327619")]
    [Description(@"Card security code missing in request.")]
    CSCMissing,
    
    /// <summary>
    /// Card security code not used by issuer.
    /// Encoded/decoded by serializers as "CSCNotUsed".
    /// </summary>
    [EnumMember(Value = "CNUS")]
    [IsoId("_TS9qbAEcEeCQm6a_G2yO_w_-1425026569")]
    [Description(@"Card security code not used by issuer.")]
    CSCNotUsed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CSCResult1CodeMetadataExtensions
{
    private static readonly CSCResult1CodeDropdownSource _dropdownSource = new CSCResult1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICSCResult1CodeDropdownRow GetMetadata(this CSCResult1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


