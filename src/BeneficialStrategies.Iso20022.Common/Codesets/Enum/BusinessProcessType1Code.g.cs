﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BusinessProcessType1Code.  ISO2002 ID# __0mdwNojEeC60axPepSq7g_-2020190846.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of business process model used to carry out the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0mdwNojEeC60axPepSq7g_-2020190846")]
[Description(@"Type of business process model used to carry out the transaction.")]
[DerivedFrom(typeof(BusinessProcessTypeCode))]
public enum BusinessProcessType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TripartiteCentralMatching".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__0mdwdojEeC60axPepSq7g_1532057379")]
    [Description(@"??")]
    TripartiteCentralMatching,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotCoveredByInvestmentInstructions".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__0mdwtojEeC60axPepSq7g_1520958602")]
    [Description(@"??")]
    NotCoveredByInvestmentInstructions,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreAccepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__0mdw9ojEeC60axPepSq7g_394185007")]
    [Description(@"??")]
    PreAccepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Reversal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__0mdxNojEeC60axPepSq7g_-1697522113")]
    [Description(@"??")]
    Reversal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OwnAccountTradeType".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__0mdxdojEeC60axPepSq7g_-73630408")]
    [Description(@"??")]
    OwnAccountTradeType,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ThroughType".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__0wOwNojEeC60axPepSq7g_1409712494")]
    [Description(@"??")]
    ThroughType,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BillateralCentralMatching".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__0wOwdojEeC60axPepSq7g_-1661996260")]
    [Description(@"??")]
    BillateralCentralMatching,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DuplexType".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__0wOwtojEeC60axPepSq7g_1051589305")]
    [Description(@"??")]
    DuplexType,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BusinessProcessType1CodeMetadataExtensions
{
    private static readonly BusinessProcessType1CodeDropdownSource _dropdownSource = new BusinessProcessType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBusinessProcessType1CodeDropdownRow GetMetadata(this BusinessProcessType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


