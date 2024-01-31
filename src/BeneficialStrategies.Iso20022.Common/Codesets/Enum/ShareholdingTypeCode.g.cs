﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ShareholdingTypeCode.  ISO2002 ID# _oLAXQD6IEemPvNTzinB5Vw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of shareholding.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oLAXQD6IEemPvNTzinB5Vw")]
[Description(@"Specifies the type of shareholding.")]
[Derivations(typeof(ShareholdingType1Code))]
public enum ShareholdingTypeCode
{
    /// <summary>
    /// Shares are held by the responding intermediary for its own account.
    /// Usage: this type should only be used to report the intermediary’s own assets if and when the intermediary comingles them with the one of their clients.  Within jurisdictions where commingling is not allowed, this type should not be used.
    /// Encoded/decoded by serializers as "OOAC".
    /// </summary>
    [EnumMember(Value = "OOAC")]
    [IsoId("_tZ5eAD6IEemPvNTzinB5Vw")]
    [Description(@"Shares are held by the responding intermediary for its own account.|Usage: this type should only be used to report the intermediary’s own assets if and when the intermediary comingles them with the one of their clients.  Within jurisdictions where commingling is not allowed, this type should not be used.")]
    OnOwnAccount,
    
    /// <summary>
    /// Shares are held on behalf of an intermediary.
    /// Usage: this type should be used to report assets the intermediary holds on behalf of another intermediary.
    /// Encoded/decoded by serializers as "NOMI".
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_MHyHoD6JEemPvNTzinB5Vw")]
    [Description(@"Shares are held on behalf of an intermediary.|Usage: this type should be used to report assets the intermediary holds on behalf of another intermediary.")]
    NomineeShareholding,
    
    /// <summary>
    /// Shares are held on behalf of the beneficial owner. 
    /// Usage: this type should be used to report assets the intermediary holds on behalf of a final beneficial owner.
    /// Encoded/decoded by serializers as "BENE".
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_c6OKED6JEemPvNTzinB5Vw")]
    [Description(@"Shares are held on behalf of the beneficial owner. |Usage: this type should be used to report assets the intermediary holds on behalf of a final beneficial owner.")]
    BeneficialShareholding,
    
    /// <summary>
    /// Shareholding type is unknown.
    /// Usage: this type should be used when the intermediary’s client hasn’t been classified.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_sibOAD6JEemPvNTzinB5Vw")]
    [Description(@"Shareholding type is unknown.|Usage: this type should be used when the intermediary’s client hasn’t been classified.")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ShareholdingTypeCodeMetadataExtensions
{
    private static readonly ShareholdingTypeCodeDropdownSource _dropdownSource = new ShareholdingTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IShareholdingTypeCodeDropdownRow GetMetadata(this ShareholdingTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


