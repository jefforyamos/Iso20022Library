﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResidualCash1Code.  ISO2002 ID# _9onxIPpeEeCLMa5EIHtDrg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether there is cash in the account that is awaiting investment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9onxIPpeEeCLMa5EIHtDrg")]
[Description(@"Specifies whether there is cash in the account that is awaiting investment.")]
[DerivedFrom(typeof(ResidualCashCode))]
public enum ResidualCash1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotResidualCashTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WcfODv8uEeC87tbx-VXRVA")]
    [Description(@"??")]
    NotResidualCashTransfer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ResidualCashTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WgN3fv8uEeC87tbx-VXRVA")]
    [Description(@"??")]
    ResidualCashTransfer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResidualCash1CodeMetadataExtensions
{
    private static readonly ResidualCash1CodeDropdownSource _dropdownSource = new ResidualCash1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResidualCash1CodeDropdownRow GetMetadata(this ResidualCash1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


