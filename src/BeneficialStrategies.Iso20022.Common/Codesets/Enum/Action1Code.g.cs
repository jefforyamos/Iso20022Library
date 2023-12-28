﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Action1Code.  ISO2002 ID# _bpi0B9p-Ed-ak6NoX_4Aeg_679462086.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which type of action a user should take.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bpi0B9p-Ed-ak6NoX_4Aeg_679462086")]
[Description(@"Specifies which type of action a user should take.")]
[DerivedFrom(typeof(ActionCode))]
public enum Action1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SubmitTwin".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bpi0CNp-Ed-ak6NoX_4Aeg_722866594")]
    [Description(@"??")]
    SubmitTwin,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReSubmitTwin".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bpr98Np-Ed-ak6NoX_4Aeg_722866612")]
    [Description(@"??")]
    ReSubmitTwin,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReSubmitBaseline".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bpr98dp-Ed-ak6NoX_4Aeg_722866637")]
    [Description(@"??")]
    ReSubmitBaseline,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptOrRejectDataSetMisMatches".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bpr98tp-Ed-ak6NoX_4Aeg_722866638")]
    [Description(@"??")]
    AcceptOrRejectDataSetMisMatches,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptOrRejectChangeOfStatus".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bpr989p-Ed-ak6NoX_4Aeg_722866655")]
    [Description(@"??")]
    AcceptOrRejectChangeOfStatus,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptOrRejectExtensionOfStatus".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bpr99Np-Ed-ak6NoX_4Aeg_722866672")]
    [Description(@"??")]
    AcceptOrRejectExtensionOfStatus,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WaitForBaselineEstablished".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bpr99dp-Ed-ak6NoX_4Aeg_-394921817")]
    [Description(@"??")]
    WaitForBaselineEstablished,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UpdateAndResend".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bpr99tp-Ed-ak6NoX_4Aeg_-98474441")]
    [Description(@"??")]
    UpdateAndResend,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SubmitDataSet".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bpr999p-Ed-ak6NoX_4Aeg_-851340559")]
    [Description(@"??")]
    SubmitDataSet,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptOrRejectBaselineAmendment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bpr9-Np-Ed-ak6NoX_4Aeg_1978739457")]
    [Description(@"??")]
    AcceptOrRejectBaselineAmendment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Action1CodeMetadataExtensions
{
    private static readonly Action1CodeDropdownSource _dropdownSource = new Action1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAction1CodeDropdownRow GetMetadata(this Action1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


