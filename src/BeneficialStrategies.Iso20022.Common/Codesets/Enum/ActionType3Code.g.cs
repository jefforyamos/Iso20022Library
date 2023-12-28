﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ActionType3Code.  ISO2002 ID# _3I4WYTGeEeO118ZQJgaQSQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of action to be performed by the point of interaction (POI).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3I4WYTGeEeO118ZQJgaQSQ")]
[Description(@"Type of action to be performed by the point of interaction (POI).")]
[DerivedFrom(typeof(ActionTypeCode))]
public enum ActionType3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Busy".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3ZsZkTGeEeO118ZQJgaQSQ")]
    [Description(@"??")]
    Busy,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CaptureCard".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3ZsZkzGeEeO118ZQJgaQSQ")]
    [Description(@"??")]
    CaptureCard,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DisplayMessage".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3ZsZlTGeEeO118ZQJgaQSQ")]
    [Description(@"??")]
    DisplayMessage,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForbidOverride".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3ZsZlzGeEeO118ZQJgaQSQ")]
    [Description(@"??")]
    ForbidOverride,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IdentificationRequired".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3ZsZmTGeEeO118ZQJgaQSQ")]
    [Description(@"??")]
    IdentificationRequired,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PINLastTry".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3ZsZmzGeEeO118ZQJgaQSQ")]
    [Description(@"??")]
    PINLastTry,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PINRetry".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3ZsZnTGeEeO118ZQJgaQSQ")]
    [Description(@"??")]
    PINRetry,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PrintMessage".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3ZsZnzGeEeO118ZQJgaQSQ")]
    [Description(@"??")]
    PrintMessage,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Referral".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3ZsZoTGeEeO118ZQJgaQSQ")]
    [Description(@"??")]
    Referral,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RequestData".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3ZsZozGeEeO118ZQJgaQSQ")]
    [Description(@"??")]
    RequestData,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptCurrencyConversion".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_450IgTGeEeO118ZQJgaQSQ")]
    [Description(@"??")]
    AcceptCurrencyConversion,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ActionType3CodeMetadataExtensions
{
    private static readonly ActionType3CodeDropdownSource _dropdownSource = new ActionType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IActionType3CodeDropdownRow GetMetadata(this ActionType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


