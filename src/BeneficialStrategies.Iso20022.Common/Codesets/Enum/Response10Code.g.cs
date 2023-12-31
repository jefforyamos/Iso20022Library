﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Response10Code.  ISO2002 ID# _gImmcPBkEeesZ516Jn5sHw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Response codes for verification
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gImmcPBkEeesZ516Jn5sHw")]
[Description(@"Response codes for verification")]
[DerivedFrom(typeof(ResponseCode))]
public enum Response10Code
{
    /// <summary>
    /// Request is still in progress.
    /// Encoded/decoded by serializers as "InProgress".
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_SpLhgX0mEemfrNOe0zHQyg")]
    [Description(@"Request is still in progress.")]
    InProgress,
    
    /// <summary>
    /// Service is under review.
    /// Encoded/decoded by serializers as "UnderReview".
    /// </summary>
    [EnumMember(Value = "UNRV")]
    [IsoId("_SpLhg30mEemfrNOe0zHQyg")]
    [Description(@"Service is under review.")]
    UnderReview,
    
    /// <summary>
    /// Other type of processing result defined at private level.
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_SpLhhX0mEemfrNOe0zHQyg")]
    [Description(@"Other type of processing result defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Other type of processing result defined at national level.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_SpLhh30mEemfrNOe0zHQyg")]
    [Description(@"Other type of processing result defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Processing of the request fails for various reasons. Some further processing according to the type of requested service, the context of the process, and some additional precision about the failure notified in the ErrorCondition data element.
    /// Encoded/decoded by serializers as "Failure".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_bt7vcX06Eem0U9m89kippg")]
    [Description(@"Processing of the request fails for various reasons. Some further processing according to the type of requested service, the context of the process, and some additional precision about the failure notified in the ErrorCondition data element.")]
    Failure,
    
    /// <summary>
    /// Processing OK. Information related to the result of the processing is contained in other parts of the response message.
    /// Encoded/decoded by serializers as "Success".
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_cQcmoX06Eem0U9m89kippg")]
    [Description(@"Processing OK. Information related to the result of the processing is contained in other parts of the response message.")]
    Success,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Response10CodeMetadataExtensions
{
    private static readonly Response10CodeDropdownSource _dropdownSource = new Response10CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResponse10CodeDropdownRow GetMetadata(this Response10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


