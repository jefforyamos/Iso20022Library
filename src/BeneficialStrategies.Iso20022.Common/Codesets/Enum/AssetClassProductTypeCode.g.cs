﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassProductTypeCode.  ISO2002 ID# _bI7sQQnYEeWa7rBfPECYsw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Commodity derivative base product code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bI7sQQnYEeWa7rBfPECYsw")]
[Description(@"Commodity derivative base product code list.")]
[Derivations(typeof(AssetClassProductType7Code),typeof(AssetClassProductType4Code),typeof(AssetClassProductType9Code),typeof(AssetClassProductType8Code),typeof(AssetClassProductType3Code),typeof(AssetClassProductType1Code),typeof(AssetClassProductType11Code),typeof(AssetClassProductType5Code),typeof(AssetClassProductType2Code),typeof(AssetClassProductType6Code),typeof(AssetClassProductType13Code),typeof(AssetClassProductType12Code),typeof(AssetClassProductType14Code),typeof(AssetClassProductType15Code),typeof(AssetClassProductType16Code))]
// External derivations that should be provided by the proper interface are: 
public enum AssetClassProductTypeCode
{
    /// <summary>
    /// Commodity of type agricultural.
    /// Encoded/decoded by serializers as "AGRI".
    /// </summary>
    [EnumMember(Value = "AGRI")]
    [IsoId("_eSXiYAnYEeWa7rBfPECYsw")]
    [Description(@"Commodity of type agricultural.")]
    Agricultural,
    
    /// <summary>
    /// Commodity of type energy.
    /// Encoded/decoded by serializers as "NRGY".
    /// </summary>
    [EnumMember(Value = "NRGY")]
    [IsoId("_epu5gAnYEeWa7rBfPECYsw")]
    [Description(@"Commodity of type energy.")]
    Energy,
    
    /// <summary>
    /// Commodity of type environmental.
    /// Encoded/decoded by serializers as "ENVR".
    /// </summary>
    [EnumMember(Value = "ENVR")]
    [IsoId("_etJZ4AnYEeWa7rBfPECYsw")]
    [Description(@"Commodity of type environmental.")]
    Environmental,
    
    /// <summary>
    /// Commodity of type freight.
    /// Encoded/decoded by serializers as "FRGT".
    /// </summary>
    [EnumMember(Value = "FRGT")]
    [IsoId("_evFTkAnYEeWa7rBfPECYsw")]
    [Description(@"Commodity of type freight.")]
    Freight,
    
    /// <summary>
    /// Commodity of type fertilizer.
    /// Encoded/decoded by serializers as "FRTL".
    /// </summary>
    [EnumMember(Value = "FRTL")]
    [IsoId("_exBNQAnYEeWa7rBfPECYsw")]
    [Description(@"Commodity of type fertilizer.")]
    Fertilizer,
    
    /// <summary>
    /// Commodity of type industrial product.
    /// Encoded/decoded by serializers as "INDP".
    /// </summary>
    [EnumMember(Value = "INDP")]
    [IsoId("_eyqMAAnYEeWa7rBfPECYsw")]
    [Description(@"Commodity of type industrial product.")]
    IndustrialProduct,
    
    /// <summary>
    /// Commodity of type metal.
    /// Encoded/decoded by serializers as "METL".
    /// </summary>
    [EnumMember(Value = "METL")]
    [IsoId("_0Lg_8AnYEeWa7rBfPECYsw")]
    [Description(@"Commodity of type metal.")]
    Metal,
    
    /// <summary>
    /// Commodity of type multi commodity exotic.
    /// Encoded/decoded by serializers as "MCEX".
    /// </summary>
    [EnumMember(Value = "MCEX")]
    [IsoId("_S2ITIQnZEeWa7rBfPECYsw")]
    [Description(@"Commodity of type multi commodity exotic.")]
    MultiCommodityExotic,
    
    /// <summary>
    /// Commodity of type paper.
    /// Encoded/decoded by serializers as "PAPR".
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_V1wF8AnZEeWa7rBfPECYsw")]
    [Description(@"Commodity of type paper.")]
    Paper,
    
    /// <summary>
    /// Commodity of type polypropylene.
    /// Encoded/decoded by serializers as "POLY".
    /// </summary>
    [EnumMember(Value = "POLY")]
    [IsoId("_ci9k0AnZEeWa7rBfPECYsw")]
    [Description(@"Commodity of type polypropylene.")]
    Polypropylene,
    
    /// <summary>
    /// Commodity of type inflation.
    /// Encoded/decoded by serializers as "INFL".
    /// </summary>
    [EnumMember(Value = "INFL")]
    [IsoId("_iUqdsAnZEeWa7rBfPECYsw")]
    [Description(@"Commodity of type inflation.")]
    Inflation,
    
    /// <summary>
    /// Commodity of type official economic statistic.
    /// Encoded/decoded by serializers as "OEST".
    /// </summary>
    [EnumMember(Value = "OEST")]
    [IsoId("_lTipoAnZEeWa7rBfPECYsw")]
    [Description(@"Commodity of type official economic statistic.")]
    OfficialEconomicStatistic,
    
    /// <summary>
    /// Commodity of other type C10.
    /// Encoded/decoded by serializers as "OTHC".
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_9vcX0AnZEeWa7rBfPECYsw")]
    [Description(@"Commodity of other type C10.")]
    OtherC10,
    
    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_AKnZwAnaEeWa7rBfPECYsw")]
    [Description(@"Commodity of other type.")]
    Other,
    
    /// <summary>
    /// Index type of commodities.
    /// Encoded/decoded by serializers as "INDX".
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_zkf6EE7JEe2PGo0mhYCh1g")]
    [Description(@"Index type of commodities.")]
    Index,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassProductTypeCodeMetadataExtensions
{
    private static readonly AssetClassProductTypeCodeDropdownSource _dropdownSource = new AssetClassProductTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassProductTypeCodeDropdownRow GetMetadata(this AssetClassProductTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


