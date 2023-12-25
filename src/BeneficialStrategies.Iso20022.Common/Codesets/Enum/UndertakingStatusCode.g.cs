﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UndertakingStatusCode.  ISO2002 ID# _uQUrMHykEeGWJuGCfvwOsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the undertaking status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uQUrMHykEeGWJuGCfvwOsQ")]
[Description(@"Specifies the undertaking status.")]
public enum UndertakingStatusCode
{
    /// <summary>
    /// Accepted in accordance with technical validation.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_Wf67oHylEeGWJuGCfvwOsQ")]
    [Description(@"Accepted in accordance with technical validation.")]
    ACTC,
    
    /// <summary>
    /// Accepted.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_f4Ou0HylEeGWJuGCfvwOsQ")]
    [Description(@"Accepted.")]
    ACCP,
    
    /// <summary>
    /// Pending further processing.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_kdrP8HylEeGWJuGCfvwOsQ")]
    [Description(@"Pending further processing.")]
    PEND,
    
    /// <summary>
    /// Received.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_tiKvQHylEeGWJuGCfvwOsQ")]
    [Description(@"Received.")]
    RCVD,
    
    /// <summary>
    /// Rejected.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_0hHeYHylEeGWJuGCfvwOsQ")]
    [Description(@"Rejected.")]
    REJT,
    
    /// <summary>
    /// Undertaking not confirmed.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_IeDI0H1UEeGlwNeVP9egyg")]
    [Description(@"Undertaking not confirmed.")]
    NCON,
    
    /// <summary>
    /// Demand has been withdrawn.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_5NIuEH1UEeGlwNeVP9egyg")]
    [Description(@"Demand has been withdrawn.")]
    WTHD,
    
    /// <summary>
    /// Change to undertaking amount.
    /// </summary>
    [EnumMember(Value = "AMTU")]
    [IsoId("_VkLcAK-xEeGNi5z8K_XPKQ")]
    [Description(@"Change to undertaking amount.")]
    AMTU,
    
    /// <summary>
    /// Change to counter-undertaking amount.
    /// </summary>
    [EnumMember(Value = "AMTC")]
    [IsoId("_srHiYK-xEeGNi5z8K_XPKQ")]
    [Description(@"Change to counter-undertaking amount.")]
    AMTC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UndertakingStatusCodeMetadataExtensions
{
    private static readonly UndertakingStatusCodeDropdownSource _dropdownSource = new UndertakingStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUndertakingStatusCodeDropdownRow GetMetadata(this UndertakingStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


