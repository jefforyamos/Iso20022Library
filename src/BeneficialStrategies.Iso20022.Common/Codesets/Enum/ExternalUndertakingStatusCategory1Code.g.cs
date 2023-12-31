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
    /// Status is related to an undertaking amendment.
    /// Encoded/decoded by serializers as "Amendment".
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_uRhQ2_RYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking amendment.")]
    Amendment,
    
    /// <summary>
    /// Status is related to a counter-undertaking amount.
    /// Encoded/decoded by serializers as "CounterUndertakingAmountStatus".
    /// </summary>
    [EnumMember(Value = "AMTC")]
    [IsoId("_uRrB0vRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to a counter-undertaking amount.")]
    CounterUndertakingAmountStatus,
    
    /// <summary>
    /// Status is related to an undertaking amount.
    /// Encoded/decoded by serializers as "UndertakingAmountStatus".
    /// </summary>
    [EnumMember(Value = "AMTU")]
    [IsoId("_uRrB1fRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking amount.")]
    UndertakingAmountStatus,
    
    /// <summary>
    /// Status is related to an undertaking application.
    /// Encoded/decoded by serializers as "Application".
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_uRrB2PRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking application.")]
    Application,
    
    /// <summary>
    /// Status is related to an undertaking amendment requested by the beneficiary.
    /// Encoded/decoded by serializers as "BeneficiaryAmendment".
    /// </summary>
    [EnumMember(Value = "BAMD")]
    [IsoId("_uRrB2_RYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking amendment requested by the beneficiary.")]
    BeneficiaryAmendment,
    
    /// <summary>
    /// Status is related to an undertaking confirmation.
    /// Encoded/decoded by serializers as "Confirmation".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uRrB3vRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking confirmation.")]
    Confirmation,
    
    /// <summary>
    /// Status is related to an undertaking demand.
    /// Encoded/decoded by serializers as "Demand".
    /// </summary>
    [EnumMember(Value = "DEMD")]
    [IsoId("_uR0LwvRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking demand.")]
    Demand,
    
    /// <summary>
    /// Status is related to an undertaking non-extension request.
    /// Encoded/decoded by serializers as "NonExtension".
    /// </summary>
    [EnumMember(Value = "NEXT")]
    [IsoId("_uR0LxfRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking non-extension request.")]
    NonExtension,
    
    /// <summary>
    /// Status is related to an undertaking termination.
    /// Encoded/decoded by serializers as "Termination".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_uR0LyPRYEeuLhpyIdtJzwg")]
    [Description(@"Status is related to an undertaking termination.")]
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


