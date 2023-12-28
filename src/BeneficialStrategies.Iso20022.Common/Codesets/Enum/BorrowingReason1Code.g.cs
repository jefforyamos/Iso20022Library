﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BorrowingReason1Code.  ISO2002 ID# __0Ti1dojEeC60axPepSq7g_467150193.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the underlying reason for the borrowing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0Ti1dojEeC60axPepSq7g_467150193")]
[Description(@"Identifies the underlying reason for the borrowing.")]
[DerivedFrom(typeof(BorrowingReasonCode))]
public enum BorrowingReason1Code
{
    /// <summary>
    /// The borrowing reason is for Self consumption.
    /// Encoded/decoded by serializers as "SelfConsumption".
    /// </summary>
    [EnumMember(Value = "SFCT")]
    [IsoId("__0dT0NojEeC60axPepSq7g_-351803488")]
    [Description(@"The borrowing reason is for Self consumption.")]
    SelfConsumption,
    
    /// <summary>
    /// The borrowing reason is for Transfer to thrid party.
    /// Encoded/decoded by serializers as "TransferToThirdParty".
    /// </summary>
    [EnumMember(Value = "TTTP")]
    [IsoId("__0dT0dojEeC60axPepSq7g_1231215891")]
    [Description(@"The borrowing reason is for Transfer to thrid party.")]
    TransferToThirdParty,
    
    /// <summary>
    /// The borrowing reason is for Market making purpose.
    /// Encoded/decoded by serializers as "MarketMakingPurpose".
    /// </summary>
    [EnumMember(Value = "MMPP")]
    [IsoId("__0dT0tojEeC60axPepSq7g_-1596602642")]
    [Description(@"The borrowing reason is for Market making purpose.")]
    MarketMakingPurpose,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BorrowingReason1CodeMetadataExtensions
{
    private static readonly BorrowingReason1CodeDropdownSource _dropdownSource = new BorrowingReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBorrowingReason1CodeDropdownRow GetMetadata(this BorrowingReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


