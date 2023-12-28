﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BuyInStateCode.  ISO2002 ID# _FentwJwVEeqtp-LOti013g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the state of the buy-in transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FentwJwVEeqtp-LOti013g")]
[Description(@"Specifies the state of the buy-in transaction.")]
[Derivations(typeof(BuyInState1Code))]
// External derivations that should be provided by the proper interface are: 
public enum BuyInStateCode
{
    /// <summary>
    /// Buy-in was successful.
    /// Encoded/decoded by serializers as "BSSY".
    /// </summary>
    [EnumMember(Value = "BSSY")]
    [IsoId("_bHt9IJwVEeqtp-LOti013g")]
    [Description(@"Buy-in was successful.")]
    Successful,
    
    /// <summary>
    /// Buy-in was unsuccessful.
    /// Encoded/decoded by serializers as "BSSN".
    /// </summary>
    [EnumMember(Value = "BSSN")]
    [IsoId("_bOt9AJwVEeqtp-LOti013g")]
    [Description(@"Buy-in was unsuccessful.")]
    Unsuccesssful,
    
    /// <summary>
    /// Buy-in was partially successful.
    /// Encoded/decoded by serializers as "BSSP".
    /// </summary>
    [EnumMember(Value = "BSSP")]
    [IsoId("_bUEXEJwVEeqtp-LOti013g")]
    [Description(@"Buy-in was partially successful.")]
    PartiallySuccessful,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BuyInStateCodeMetadataExtensions
{
    private static readonly BuyInStateCodeDropdownSource _dropdownSource = new BuyInStateCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBuyInStateCodeDropdownRow GetMetadata(this BuyInStateCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


