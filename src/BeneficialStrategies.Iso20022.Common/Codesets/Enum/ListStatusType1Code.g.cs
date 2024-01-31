﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ListStatusType1Code.  ISO2002 ID# _afVDpdp-Ed-ak6NoX_4Aeg_-397467457.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afVDpdp-Ed-ak6NoX_4Aeg_-397467457")]
[Description(@"Identifies the type of status.")]
[DerivedFrom(typeof(ListStatusTypeCode))]
public enum ListStatusType1Code
{
    /// <summary>
    /// Status is an acknowledgement of the ListOrder.
    /// Encoded/decoded by serializers as "ACKN".
    /// </summary>
    [EnumMember(Value = "ACKN")]
    [IsoId("_afVDptp-Ed-ak6NoX_4Aeg_375253895")]
    [Description(@"Status is an acknowledgement of the ListOrder.")]
    Acknowledgement = ListStatusTypeCode.Acknowledgement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status is a response to a previously sent StatusRequest.
    /// Encoded/decoded by serializers as "RESP".
    /// </summary>
    [EnumMember(Value = "RESP")]
    [IsoId("_afVDp9p-Ed-ak6NoX_4Aeg_375253930")]
    [Description(@"Status is a response to a previously sent StatusRequest.")]
    Response = ListStatusTypeCode.Response, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status indicates that the ListOrder has been executed.
    /// Encoded/decoded by serializers as "ADON".
    /// </summary>
    [EnumMember(Value = "ADON")]
    [IsoId("_afVDqNp-Ed-ak6NoX_4Aeg_375253972")]
    [Description(@"Status indicates that the ListOrder has been executed.")]
    AllDone = ListStatusTypeCode.AllDone, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status indicates that any of the individual orders of the ListOrder have a status that requires something to be done.
    /// Encoded/decoded by serializers as "ALER".
    /// </summary>
    [EnumMember(Value = "ALER")]
    [IsoId("_afe0oNp-Ed-ak6NoX_4Aeg_375254224")]
    [Description(@"Status indicates that any of the individual orders of the ListOrder have a status that requires something to be done.")]
    Alert = ListStatusTypeCode.Alert, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status indicates that the Execution has started.
    /// Encoded/decoded by serializers as "EXST".
    /// </summary>
    [EnumMember(Value = "EXST")]
    [IsoId("_afe0odp-Ed-ak6NoX_4Aeg_375254670")]
    [Description(@"Status indicates that the Execution has started.")]
    ExecutionStarted = ListStatusTypeCode.ExecutionStarted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status indicated that time limit for the order has expired.
    /// Encoded/decoded by serializers as "TIME".
    /// </summary>
    [EnumMember(Value = "TIME")]
    [IsoId("_afe0otp-Ed-ak6NoX_4Aeg_375254705")]
    [Description(@"Status indicated that time limit for the order has expired.")]
    Timed = ListStatusTypeCode.Timed, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ListStatusType1CodeMetadataExtensions
{
    private static readonly ListStatusType1CodeDropdownSource _dropdownSource = new ListStatusType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IListStatusType1CodeDropdownRow GetMetadata(this ListStatusType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


