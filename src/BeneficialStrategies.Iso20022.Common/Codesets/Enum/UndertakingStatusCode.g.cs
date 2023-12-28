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
[Derivations(typeof(UndertakingStatus1Code),typeof(UndertakingStatus2Code),typeof(UndertakingStatus3Code))]
// External derivations that should be provided by the proper interface are: 
public enum UndertakingStatusCode
{
    /// <summary>
    /// Accepted in accordance with technical validation.
    /// Encoded/decoded by serializers as "ACTC".
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_Wf67oHylEeGWJuGCfvwOsQ")]
    [Description(@"Accepted in accordance with technical validation.")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// Accepted.
    /// Encoded/decoded by serializers as "ACCP".
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_f4Ou0HylEeGWJuGCfvwOsQ")]
    [Description(@"Accepted.")]
    Accepted,
    
    /// <summary>
    /// Pending further processing.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_kdrP8HylEeGWJuGCfvwOsQ")]
    [Description(@"Pending further processing.")]
    Pending,
    
    /// <summary>
    /// Received.
    /// Encoded/decoded by serializers as "RCVD".
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_tiKvQHylEeGWJuGCfvwOsQ")]
    [Description(@"Received.")]
    Received,
    
    /// <summary>
    /// Rejected.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_0hHeYHylEeGWJuGCfvwOsQ")]
    [Description(@"Rejected.")]
    Rejected,
    
    /// <summary>
    /// Undertaking not confirmed.
    /// Encoded/decoded by serializers as "NCON".
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_IeDI0H1UEeGlwNeVP9egyg")]
    [Description(@"Undertaking not confirmed.")]
    NonConfirmation,
    
    /// <summary>
    /// Demand has been withdrawn.
    /// Encoded/decoded by serializers as "WTHD".
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_5NIuEH1UEeGlwNeVP9egyg")]
    [Description(@"Demand has been withdrawn.")]
    Withdrawn,
    
    /// <summary>
    /// Change to undertaking amount.
    /// Encoded/decoded by serializers as "AMTU".
    /// </summary>
    [EnumMember(Value = "AMTU")]
    [IsoId("_VkLcAK-xEeGNi5z8K_XPKQ")]
    [Description(@"Change to undertaking amount.")]
    UndertakingAmountChange,
    
    /// <summary>
    /// Change to counter-undertaking amount.
    /// Encoded/decoded by serializers as "AMTC".
    /// </summary>
    [EnumMember(Value = "AMTC")]
    [IsoId("_srHiYK-xEeGNi5z8K_XPKQ")]
    [Description(@"Change to counter-undertaking amount.")]
    CounterUndertakingAmountChange,
    
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


