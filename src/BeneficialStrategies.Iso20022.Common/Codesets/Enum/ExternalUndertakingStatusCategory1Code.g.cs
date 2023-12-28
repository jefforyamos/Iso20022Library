﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalUndertakingStatusCategory1Code.  ISO2002 ID# _-MrKBG7iEeKo25nLKvGr8w_-479292299.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external status stage code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MrKBG7iEeKo25nLKvGr8w_-479292299")]
[Description(@"Specifies the external status stage code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalUndertakingStatusCategoryCode))]
public enum ExternalUndertakingStatusCategory1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Amendment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uRhQ2_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Amendment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CounterUndertakingAmountStatus".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uRrB0vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CounterUndertakingAmountStatus,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UndertakingAmountStatus".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uRrB1fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    UndertakingAmountStatus,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Application".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uRrB2PRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Application,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BeneficiaryAmendment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uRrB2_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    BeneficiaryAmendment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Confirmation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uRrB3vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Confirmation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Demand".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uR0LwvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Demand,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonExtension".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uR0LxfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    NonExtension,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Termination".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uR0LyPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Termination,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalUndertakingStatusCategory1CodeMetadataExtensions
{
    private static readonly ExternalUndertakingStatusCategory1CodeDropdownSource _dropdownSource = new ExternalUndertakingStatusCategory1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalUndertakingStatusCategory1CodeDropdownRow GetMetadata(this ExternalUndertakingStatusCategory1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

