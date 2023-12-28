﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionEventProcessingStatusCode.  ISO2002 ID# _bDZaBtp-Ed-ak6NoX_4Aeg_391924005.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the stage in the corporate action event life cycle.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bDZaBtp-Ed-ak6NoX_4Aeg_391924005")]
[Description(@"Specifies the stage in the corporate action event life cycle.")]
public enum CorporateActionEventProcessingStatusCode
{
    /// <summary>
    /// Specifies that a corporate action event processing has been completed.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_bDZaB9p-Ed-ak6NoX_4Aeg_428864814")]
    [Description(@"Specifies that a corporate action event processing has been completed.")]
    Complete,
    
    /// <summary>
    /// Specifies that a corporate action event processing has not been completed.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_bDZaCNp-Ed-ak6NoX_4Aeg_429787479")]
    [Description(@"Specifies that a corporate action event processing has not been completed.")]
    Pending,
    
    /// <summary>
    /// Corporate action event processing specifying that the funds paid have been reconciled with the funds received from the agent (meaning that there is no more risk of payment to be reversed).
    /// Encoded/decoded by serializers as "RECD".
    /// </summary>
    [EnumMember(Value = "RECD")]
    [IsoId("_bDij8Np-Ed-ak6NoX_4Aeg_430710847")]
    [Description(@"Corporate action event processing specifying that the funds paid have been reconciled with the funds received from the agent (meaning that there is no more risk of payment to be reversed).")]
    Reconciled,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionEventProcessingStatusCodeMetadataExtensions
{
    private static readonly CorporateActionEventProcessingStatusCodeDropdownSource _dropdownSource = new CorporateActionEventProcessingStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionEventProcessingStatusCodeDropdownRow GetMetadata(this CorporateActionEventProcessingStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

