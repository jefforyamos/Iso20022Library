﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OvernightIndexSwapTypeCode.  ISO2002 ID# _yb-YIbu8EeSXxOgurgHGgw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of overnight index swap transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yb-YIbu8EeSXxOgurgHGgw")]
[Description(@"Specifies the type of overnight index swap transaction.")]
public enum OvernightIndexSwapTypeCode
{
    /// <summary>
    /// Fixed interest rate is paid by the reporting agent.
    /// Encoded/decoded by serializers as "PAID".
    /// </summary>
    [EnumMember(Value = "PAID")]
    [IsoId("_82nLALu8EeSXxOgurgHGgw")]
    [Description(@"Fixed interest rate is paid by the reporting agent.")]
    Paid,
    
    /// <summary>
    /// Fixed interest rate is received by the reporting agent.
    /// Encoded/decoded by serializers as "RECE".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_9D2VwLu8EeSXxOgurgHGgw")]
    [Description(@"Fixed interest rate is received by the reporting agent.")]
    Received,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OvernightIndexSwapTypeCodeMetadataExtensions
{
    private static readonly OvernightIndexSwapTypeCodeDropdownSource _dropdownSource = new OvernightIndexSwapTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOvernightIndexSwapTypeCodeDropdownRow GetMetadata(this OvernightIndexSwapTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

